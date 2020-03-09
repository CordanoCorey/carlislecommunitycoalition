import { NgModule } from '@angular/core';

import { GamesRoutingModule } from './games-routing.module';
import { GamesComponent } from './games.component';
import { GameModule } from '../game/game.module';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [GamesComponent],
  imports: [SharedModule, GamesRoutingModule, GameModule]
})
export class GamesModule {}
