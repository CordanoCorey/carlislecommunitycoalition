import { NgModule } from '@angular/core';

import { SummerLeagueRoutingModule } from './summer-league-routing.module';
import { SummerLeagueComponent } from './summer-league.component';
import { SummerLeagueSignupModule } from './summer-league-signup/summer-league-signup.module';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [SharedModule, SummerLeagueRoutingModule, SummerLeagueSignupModule],
  declarations: [SummerLeagueComponent],
  exports: [SummerLeagueSignupModule]
})
export class SummerLeagueModule { }
