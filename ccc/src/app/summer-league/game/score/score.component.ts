import {
  Component,
  OnInit,
  Input,
  ChangeDetectionStrategy
} from '@angular/core';
import { Game } from '../../../shared/models';

@Component({
  selector: 'ccc-score',
  templateUrl: './score.component.html',
  styleUrls: ['./score.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ScoreComponent implements OnInit {
  @Input() game: Game = new Game();
  constructor() {}

  ngOnInit() {}
}
