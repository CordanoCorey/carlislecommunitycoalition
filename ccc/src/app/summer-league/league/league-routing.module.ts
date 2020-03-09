import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LeagueComponent } from './league.component';
import { StandingsComponent } from './standings/standings.component';

const routes: Routes = [
  {
    path: '',
    component: LeagueComponent,
    data: { routeName: 'league', routeLabel: 'League' },
    children: [
      {
        path: 'games',
        loadChildren: () =>
          import('../games/games.module').then(m => m.GamesModule)
      },
      {
        path: 'standings',
        component: StandingsComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LeagueRoutingModule {}
