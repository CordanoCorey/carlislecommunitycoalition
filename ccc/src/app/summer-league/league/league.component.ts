import { Component, OnInit } from '@angular/core';
import {
  SmartComponent,
  routeParamSelector,
  routeNameSelector
} from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

@Component({
  selector: 'ccc-league',
  templateUrl: './league.component.html',
  styleUrls: ['./league.component.scss']
})
export class LeagueComponent extends SmartComponent implements OnInit {
  leagueName$: Observable<'10U' | '12U' | '14U'>;
  routeName$: Observable<string>;

  constructor(public store: Store<any>) {
    super(store);
    this.leagueName$ = routeParamSelector(store, 'leagueName');
    this.routeName$ = routeNameSelector(store);
  }

  ngOnInit() {}
}
