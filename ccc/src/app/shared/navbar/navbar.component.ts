import {
  Component,
  OnInit,
  Input,
  ChangeDetectionStrategy
} from '@angular/core';
import { toArray } from '@caiu/library';

import { MenuItem } from '../models';

@Component({
  selector: 'ccc-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class NavbarComponent implements OnInit {
  @Input() isMobile = false;
  @Input() menuItems: MenuItem[] = [];
  @Input() width = 0;

  constructor() { }

  get paddingLeft(): number {
    return this.isMobile ? 30 : 150;
  }

  get innerWidth(): number {
    return this.width - this.paddingLeft;
  }

  get menuItemWidth(): number {
    return this.innerWidth / toArray(this.menuItems).length;
  }

  ngOnInit() { }
}
