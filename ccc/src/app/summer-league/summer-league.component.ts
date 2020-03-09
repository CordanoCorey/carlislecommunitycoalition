import { Component, OnInit } from '@angular/core';
import {
  SmartComponent,
  routeNameSelector,
  build,
  routeParamSelector
} from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { MenuItem } from '../shared/models';
import { isMobileSelector } from '../shared/selectors';

@Component({
  selector: 'ccc-summer-league',
  templateUrl: './summer-league.component.html',
  styleUrls: ['./summer-league.component.scss']
})
export class SummerLeagueComponent extends SmartComponent implements OnInit {
  isMobile = false;
  isMobile$: Observable<boolean>;
  leagueName$: Observable<'10U' | '12U' | '14U'>;
  routeName = '';
  routeName$: Observable<string>;
  _leagueName: '10U' | '12U' | '14U';
  navbarMenuItems: MenuItem[] = [];
  sidenavMenuItems: MenuItem[] = [];

  constructor(public store: Store<any>) {
    super(store);
    this.isMobile$ = isMobileSelector(store);
    this.leagueName$ = routeParamSelector(store, 'leagueName');
    this.routeName$ = routeNameSelector(store);
  }

  get cols(): number {
    // return this.isMobile ? 1 : 3;
    return 1;
  }

  set leagueName(value: '10U' | '12U' | '14U') {
    this._leagueName = value;
    this.setMenuItems();
  }

  get leagueName(): '10U' | '12U' | '14U' {
    return this._leagueName;
  }

  ngOnInit() {
    this.sync(['isMobile', 'leagueName', 'routeName']);
  }

  setMenuItems() {
    this.navbarMenuItems = this.leagueName
      ? [
        build(MenuItem, {
          routerLink: `/summer-league/${this.leagueName}`,
          label: `League`
        }),
        build(MenuItem, {
          routerLink: `/summer-league/${this.leagueName}/games`,
          label: 'Games'
        }),
        build(MenuItem, {
          externalLink: `/assets/summer-league/${
            this.leagueName
            } Schedule.pdf`,
          label: 'Schedule'
        }),
        build(MenuItem, {
          externalLink: `/assets/summer-league/${
            this.leagueName
            } Rosters.pdf`,
          label: 'Rosters'
        }),
        build(MenuItem, {
          routerLink: `/summer-league/${this.leagueName}/standings`,
          label: 'Standings'
        })
      ]
      : [
        build(MenuItem, {
          routerLink: `/about`,
          label: 'About Us'
        }),
        build(MenuItem, {
          routerLink: `/contact`,
          label: 'Contact Us'
        }),
        build(MenuItem, { routerLink: '/summer-league/players/0/signup', label: 'Summer League 2020' }),
        build(MenuItem, { routerLink: '/summer-league', label: 'Summer League 2019' })
      ];

    this.sidenavMenuItems = this.leagueName ?
      [
        build(MenuItem, {
          routerLink: '/summer-league/10U',
          label: '10U',
          matIcon: 'group'
        }),
        build(MenuItem, {
          routerLink: '/summer-league/12U',
          label: '12U',
          matIcon: 'group'
        }),
        build(MenuItem, {
          routerLink: '/summer-league/14U',
          label: '14U',
          matIcon: 'group'
        })
      ]
      : [
        build(MenuItem, {
          routerLink: '/about',
          label: 'About Us',
          matIcon: 'info'
        }),
        build(MenuItem, {
          routerLink: '/contact',
          label: 'Contact Us',
          matIcon: 'contact_support'
        }),
        build(MenuItem, {
          routerLink: '/summer-league/players/0/signup',
          label: 'Summer League 2020 Signup',
          matIcon: 'assignment_ind'
        }),
        build(MenuItem, {
          routerLink: '/summer-league',
          label: 'Summer League 2019',
          matIcon: 'sports_basketball'
        })
      ]
  }
}
