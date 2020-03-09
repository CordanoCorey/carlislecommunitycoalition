import { Component, OnInit } from '@angular/core';
import {
  SmartComponent,
  routeNameSelector,
  routeParamSelector
} from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { Game } from '../../shared/models';
import { gameScoresSelector } from '../../shared/selectors';

@Component({
  selector: 'ccc-games',
  templateUrl: './games.component.html',
  styleUrls: ['./games.component.scss']
})
export class GamesComponent extends SmartComponent implements OnInit {
  games$: Observable<Game[]>;
  leagueName: '10U' | '12U' | '14U';
  leagueName$: Observable<'10U' | '12U' | '14U'>;
  routeName$: Observable<string>;

  constructor(public store: Store<any>) {
    super(store);
    this.games$ = gameScoresSelector(store);
    this.leagueName$ = routeParamSelector(store, 'leagueName');
    this.routeName$ = routeNameSelector(store);
  }

  ngOnInit() {
    this.sync(['leagueName']);
  }

  getLink(game): string {
    return `/summer-league/${this.leagueName}/games/${game.id}`;
  }
}
