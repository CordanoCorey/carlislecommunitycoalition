import {
  Component,
  OnInit,
  Input,
  ChangeDetectionStrategy
} from '@angular/core';

@Component({
  selector: 'ccc-team-box-score',
  templateUrl: './team-box-score.component.html',
  styleUrls: ['./team-box-score.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TeamBoxScoreComponent implements OnInit {
  @Input() dataSource: any[] = [];
  @Input() displayedColumns: string[] = [];
  @Input() teamName = '';
  @Input() teamColor = '';

  constructor() {}

  ngOnInit() {}

  getTotal(statCat: string): number {
    return this.dataSource.reduce((acc, x) => {
      return acc + x[statCat];
    }, 0);
  }
}
