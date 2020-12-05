import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Control, SmartComponent, LookupValue, lookupValuesSelector, HttpService, toArray, build, buildQueryStringFromObject, HttpActions, RouterActions } from '@caiu/library';
import { Store } from '@ngrx/store';
import {
  lightSpeedInOnEnterAnimation,
  lightSpeedOutOnLeaveAnimation
} from 'angular-animations';
import { Observable, Subject, merge } from 'rxjs';
import { filter, switchMap, map, distinctUntilChanged } from 'rxjs/operators';

import { Player, PlayerLeagueSeason } from 'src/app/shared/models';
import { calculateAge } from '../../shared/utils';
import { PlayersActions, PlayerActions } from 'src/app/shared/actions';
import { playerSelector, isMobileSelector } from 'src/app/shared/selectors';

@Component({
  selector: 'ccc-summer-league-signup',
  templateUrl: './summer-league-signup.component.html',
  styleUrls: ['./summer-league-signup.component.scss'],
  animations: [
    lightSpeedInOnEnterAnimation(),
    lightSpeedOutOnLeaveAnimation()
  ]
})
export class SummerLeagueSignupComponent extends SmartComponent implements OnInit {

  @Control(Player) form: FormGroup;
  age = 0;
  lkpSizes$: Observable<LookupValue[]>;
  isMobile = false;
  isMobile$: Observable<boolean>;
  _matches: Player[] = [];
  matches$: Observable<Player[]>;
  matchesSubject = new Subject<Player[]>();
  _player: Player = new Player();
  player$: Observable<Player>;

  constructor(public store: Store<any>, private http: HttpService) {
    super(store);
    this.lkpSizes$ = lookupValuesSelector(store, 'Size');
    this.matches$ = merge(this.matchesSubject.asObservable(), this.form.valueChanges.pipe(
      filter(value => value.firstName || value.lastName || value.email),
      map(value => {
        return `players${buildQueryStringFromObject({
          take: 10,
          firstName: value.firstName,
          lastName: value.lastName,
          email: value.email
        })}`;
      }),
      distinctUntilChanged(),
      switchMap(url => this.http.get(url)),
      map(response => {
        return toArray(response)
          .filter(x => !(x.firstName === this.form.value.firstName && x.lastName === this.form.value.lastName && x.email === this.form.value.email))
          .map(x => {
            const season = build(PlayerLeagueSeason, toArray(x.seasons).find(y => y.leagueSeasonId === 4 || y.leagueSeasonId === 5 || y.leagueSeasonId === 6));
            return build(Player, x, {
              jerseySizeId: season.jerseySizeId,
              jerseyNumberChoice1: season.jerseyNumberChoice1,
              jerseyNumberChoice2: season.jerseyNumberChoice2,
              jerseyNumberChoice3: season.jerseyNumberChoice3
            });
          });
      })
    ));
    this.player$ = playerSelector(store);
    this.isMobile$ = isMobileSelector(store);
  }

  set matches(value: Player[]) {
    this.store.dispatch({
      type: PlayersActions.GET,
      payload: value
    });
    this._matches = value;
  }

  get matches(): Player[] {
    return this._matches;
  }

  set player(value: Player) {
    this._player = value;
    this.setValue(build(Player, value, {

    }));
  }

  get player(): Player {
    return this._player;
  }

  get startDate(): Date {
    return new Date(2007, 0, 1);
  }

  get valueOut(): Player {
    const age = calculateAge(this.form.value.birthDate);
    const season = build(PlayerLeagueSeason, {
      playerId: this.player.id,
      leagueSeasonId: age <= 10 ? 4 : age <= 12 ? 5 : 6,
      jerseySizeId: this.form.value.jerseySizeId || null,
      jerseyNumberChoice1: this.form.value.jerseyNumberChoice1,
      jerseyNumberChoice2: this.form.value.jerseyNumberChoice2,
      jerseyNumberChoice3: this.form.value.jerseyNumberChoice3,
      nickname: this.player.nickname
    });
    return build(Player, this.form.value, {
      contactId: this.player.contactId,
      seasons: [...this.player.seasons.filter(x => x.leagueSeasonId !== season.leagueSeasonId), season]
    });
  }

  ngOnInit() {
    this.sync(['isMobile', 'matches', 'player']);
    this.isMobile$.subscribe(x => { console.log(x); });
  }

  onSave() {
    const value = this.valueOut;
    if (value.id === 0) {
      this.addPlayer(value);
    } else {
      this.updatePlayer(value);
    }
  }

  clear() {
    this.setValue(new Player());
  }

  addPlayer(e: Player) {
    this.dispatch(HttpActions.post(`players`, e, PlayersActions.POST, PlayersActions.POST_ERROR));
  }

  updatePlayer(e: Player) {
    this.dispatch(HttpActions.put(`players/${e.id}`, e, PlayerActions.PUT, PlayerActions.PUT_ERROR));
  }

  changeBirthDate(value: Date) {
    this.setAge(new Date(value));
  }

  match(e: Player) {
    if (e.id) {
      this.dispatch(RouterActions.navigate(`/summer-league/players/${e.id}/signup`));
    }
    // this.player = e;
    // setTimeout(() => {
    //   this.matchesSubject.next([]);
    // }, 0);
  }

  setAge(birthDate: Date) {
    this.age = calculateAge(birthDate);
  }
}
