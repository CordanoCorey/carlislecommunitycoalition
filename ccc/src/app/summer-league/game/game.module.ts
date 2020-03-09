import { NgModule } from '@angular/core';

import { GameRoutingModule } from './game-routing.module';
import { GameComponent } from './game.component';
import { BoxScoreComponent } from './box-score/box-score.component';
import { ScoreComponent } from './score/score.component';
import { TeamBoxScoreComponent } from './team-box-score/team-box-score.component';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [
    GameComponent,
    BoxScoreComponent,
    ScoreComponent,
    TeamBoxScoreComponent
  ],
  imports: [SharedModule, GameRoutingModule],
  exports: [BoxScoreComponent, ScoreComponent]
})
export class GameModule {}
