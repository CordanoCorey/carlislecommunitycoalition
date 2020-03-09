import {
  Component,
  OnInit,
  Input,
  ChangeDetectionStrategy
} from '@angular/core';

import { MenuItem } from '../models';

@Component({
  selector: 'ccc-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class SidenavComponent implements OnInit {
  @Input() menuItems: MenuItem[] = [];

  constructor() {}

  ngOnInit() {}
}
