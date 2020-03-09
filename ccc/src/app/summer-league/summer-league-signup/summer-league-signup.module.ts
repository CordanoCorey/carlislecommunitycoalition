import { NgModule } from '@angular/core';

import { SummerLeagueSignupComponent } from './summer-league-signup.component';
import { SummerLeagueSignupConfirmationComponent } from '../summer-league-signup-confirmation/summer-league-signup-confirmation.component';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    SummerLeagueSignupComponent,
    SummerLeagueSignupConfirmationComponent
  ],
  imports: [
    SharedModule
  ],
  exports: [
    SummerLeagueSignupComponent,
    SummerLeagueSignupConfirmationComponent
  ]
})
export class SummerLeagueSignupModule { }
