import { NgModule } from '@angular/core';

import { PlayerRoutingModule } from './player-routing.module';
import { PlayerComponent } from './player.component';
import { SummerLeagueSignupModule } from '../summer-league-signup/summer-league-signup.module';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [PlayerComponent],
  imports: [
    SharedModule,
    PlayerRoutingModule,
    SummerLeagueSignupModule
  ]
})
export class PlayerModule { }
