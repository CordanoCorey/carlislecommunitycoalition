import { NgModule } from '@angular/core';

import { PortalRoutingModule } from './portal-routing.module';
import { PortalComponent } from './portal.component';
import { SummerLeagueModule } from '../summer-league/summer-league.module';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [SharedModule, PortalRoutingModule, SummerLeagueModule],
  declarations: [PortalComponent]
})
export class PortalModule { }
