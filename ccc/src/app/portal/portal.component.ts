import { Component, OnInit } from '@angular/core';

import { MenuItem } from '../shared/models';
import { build } from '../shared/utils';

@Component({
  selector: 'ccc-portal',
  templateUrl: './portal.component.html',
  styleUrls: ['./portal.component.scss']
})
export class PortalComponent implements OnInit {
  navbarMenuItems: MenuItem[] = [
    build(MenuItem, { routerLink: '/about', label: 'About Us' }),
    build(MenuItem, { routerLink: '/contact', label: 'Contact Us' }),
    build(MenuItem, { routerLink: '/summer-league/players/0/signup', label: 'Summer League 2020' }),
    build(MenuItem, { routerLink: '/summer-league', label: 'Summer League 2019' })
  ];
  sidenavMenuItems: MenuItem[] = [
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
  ];

  constructor() { }

  ngOnInit() { }
}
