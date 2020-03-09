import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GamesComponent } from './games.component';

const routes: Routes = [
  {
    path: '',
    component: GamesComponent,
    data: { routeName: 'games', routeLabel: 'Games' },
    children: [
      {
        path: ':gameId',
        loadChildren: () =>
          import('./../game/game.module').then(m => m.GameModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GamesRoutingModule {}
