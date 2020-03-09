import { NgModule } from '@angular/core';
import { Routes, RouterModule, Route } from '@angular/router';

import { PortalComponent } from './portal.component';

const PortalRoute: Route = {
    path: '',
    component: PortalComponent,
    data: { routeName: 'portal', routeLabel: 'Portal' }
};

const routes: Routes = [PortalRoute];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PortalRoutingModule { }
