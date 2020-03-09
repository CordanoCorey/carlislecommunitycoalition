import { Component, OnInit } from '@angular/core';
import { SmartComponent } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { BoxScore } from '../../../shared/models';
import { boxScoreSelector, isMobileSelector } from '../../../shared/selectors';

@Component({
  selector: 'ccc-box-score',
  templateUrl: './box-score.component.html',
  styleUrls: ['./box-score.component.scss']
})
export class BoxScoreComponent extends SmartComponent implements OnInit {
  boxScore$: Observable<BoxScore>;
  _boxScore: BoxScore = new BoxScore();
  displayedColumns: string[] = ['number', 'pts', 'reb', 'ast', 'blk', 'stl'];
  data: any[][] = [];
  isMobile = false;
  isMobile$: Observable<boolean>;

  constructor(public store: Store<any>) {
    super(store);
    this.boxScore$ = boxScoreSelector(store);
    this.isMobile$ = isMobileSelector(store);
  }

  set boxScore(value: BoxScore) {
    this._boxScore = value;
    this.data = value.statlines;
  }

  get boxScore(): BoxScore {
    return this._boxScore;
  }

  ngOnInit() {
    this.sync(['boxScore', 'isMobile']);
  }
}
