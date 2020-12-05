import { Component, OnInit } from '@angular/core';
import { SmartComponent, routeParamIdSelector } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { playerNameSelector } from 'src/app/shared/selectors';

@Component({
  selector: 'ccc-summer-league-signup-confirmation',
  templateUrl: './summer-league-signup-confirmation.component.html',
  styleUrls: ['./summer-league-signup-confirmation.component.scss']
})
export class SummerLeagueSignupConfirmationComponent extends SmartComponent implements OnInit {

  playerId = 0;
  playerId$: Observable<number>;
  playerName$: Observable<string>;

  constructor(public store: Store<any>) {
    super(store);
    this.playerId$ = routeParamIdSelector(store, 'playerId');
    this.playerName$ = playerNameSelector(store);
  }

  ngOnInit() {
    this.sync(['playerId']);
  }

}
