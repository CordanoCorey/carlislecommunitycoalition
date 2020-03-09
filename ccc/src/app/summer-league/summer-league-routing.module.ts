import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SummerLeagueComponent } from './summer-league.component';
import { SummerLeagueSignupComponent } from './summer-league-signup/summer-league-signup.component';
import { SummerLeagueSignupConfirmationComponent } from './summer-league-signup-confirmation/summer-league-signup-confirmation.component';

const routes: Routes = [
  {
    path: '',
    component: SummerLeagueComponent,
    data: { routeName: 'summer-league', routeLabel: 'Summer League' },
    children: [
      {
        path: 'players/:playerId',
        loadChildren: () => import('./player/player.module').then(m => m.PlayerModule)
      },
      {
        path: 'players/:playerId/signup',
        component: SummerLeagueSignupComponent,
        data: { routeName: 'signup', routeLabel: 'Signup' }
      },
      {
        path: 'players/:playerId/signup-confirmation',
        component: SummerLeagueSignupConfirmationComponent,
        data: { routeName: 'signup-confirmation', routeLabel: 'Signup Confirmation' }
      },
      {
        path: ':leagueName',
        loadChildren: () => import('./league/league.module').then(m => m.LeagueModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SummerLeagueRoutingModule { }
