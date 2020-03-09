import { Component, OnInit, Input } from '@angular/core';
import { SmartComponent, build } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable, BehaviorSubject } from 'rxjs';
import { distinctUntilChanged, filter } from 'rxjs/operators';

import { StatCategory, Stat } from '../../../shared/models';
import { statCategoriesSelector, leagueLeadersSelector } from '../../../shared/selectors';

@Component({
  selector: 'ccc-league-leaders',
  templateUrl: './league-leaders.component.html',
  styleUrls: ['./league-leaders.component.scss']
})
export class LeagueLeadersComponent extends SmartComponent implements OnInit {
  leagueLeaders: Stat[] = [];
  leagueLeaders$: Observable<Stat[]>;
  statCategories: StatCategory[] = [];
  statCategories$: Observable<StatCategory[]>;
  _statCategoryId = 0;
  statCategoryIdBehaviorSubject = new BehaviorSubject<number>(0);

  constructor(public store: Store<any>) {
    super(store);
    this.leagueLeaders$ = leagueLeadersSelector(
      store,
      this.statCategoryIdBehaviorSubject.asObservable().pipe(
        filter(x => x !== 0),
        distinctUntilChanged()
      )
    );
    this.statCategories$ = statCategoriesSelector(store);
  }

  @Input()
  set statCategoryId(value: number) {
    this._statCategoryId = value;
    this.statCategoryIdBehaviorSubject.next(value);
  }

  get statCategoryId(): number {
    return this._statCategoryId;
  }

  get color(): string {
    // return '#c0c0c0';
    return Array.isArray(this.leagueLeaders) && this.leagueLeaders.length > 0 ? this.leagueLeaders[0].teamColor : '#8e8e8e';
  }

  get labelColor(): string {
    return this.color === 'black' ? '#8e8e8e' : '#000';
  }

  get statCategoryName(): string {
    return build(StatCategory, this.statCategories.find(x => x.id === this.statCategoryId)).name;
  }

  ngOnInit() {
    this.sync(['leagueLeaders', 'statCategories']);
  }
}
