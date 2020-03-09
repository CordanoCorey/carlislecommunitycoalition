import { NgModule } from '@angular/core';

import { LeagueRoutingModule } from './league-routing.module';
import { LeagueComponent } from './league.component';
import { LeagueLeadersComponent } from './league-leaders/league-leaders.component';
import { StandingsComponent } from './standings/standings.component';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [LeagueComponent, LeagueLeadersComponent, StandingsComponent],
  imports: [SharedModule, LeagueRoutingModule]
})
export class LeagueModule {}
