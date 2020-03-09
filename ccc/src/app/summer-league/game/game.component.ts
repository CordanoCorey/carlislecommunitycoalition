import { Component, OnInit } from '@angular/core';
import { SmartComponent } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { Game } from '../../shared/models';
import { gameSelector } from '../../shared/selectors';

@Component({
  selector: 'ccc-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss']
})
export class GameComponent extends SmartComponent implements OnInit {
  game$: Observable<Game>;

  constructor(public store: Store<any>) {
    super(store);
    this.game$ = gameSelector(store);
  }

  ngOnInit() {}
}
