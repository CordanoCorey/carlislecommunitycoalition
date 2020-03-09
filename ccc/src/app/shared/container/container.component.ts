import { Component, OnInit, HostListener, Input } from '@angular/core';
import { SmartComponent } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { Image, MenuItem } from '../models';
import { isMobileSelector } from '../selectors';
import { build } from '../utils';

@Component({
  selector: 'ccc-container',
  templateUrl: './container.component.html',
  styleUrls: ['./container.component.scss']
})
export class ContainerComponent extends SmartComponent implements OnInit {
  @Input() hasWallpaper = true;
  @Input() backgroundImageUrl = null;
  @Input() navbarMenuItems: MenuItem[] = [];
  @Input() sidenavMenuItems: MenuItem[] = [];
  isMobile = false;
  isMobile$: Observable<boolean>;
  images = [
    build(Image, {
      src: 'assets/v/1.jpg',
      height: 1641,
      width: 2048,
      cols: 2,
      color: '#000',
      name: 'billy-o'
    }),
    build(Image, {
      src: 'assets/v/7.jpg',
      height: 569,
      width: 500,
      cols: 3,
      name: 'hamilton-restaurant'
    }),
    build(Image, {
      src: 'assets/h/2.jpg',
      height: 305,
      width: 452,
      cols: 2,
      name: 'carlisle-borough-sign'
    }),
    build(Image, {
      src: 'assets/h/12.jpg',
      height: 366,
      width: 650,
      cols: 2,
      name: 'carlisle-police'
    }),
    build(Image, {
      src: 'assets/h/1.jpg',
      height: 655,
      width: 1600,
      cols: 3,
      name: 'proudly-serving'
    }),

    build(Image, { src: 'assets/v/5.jpg', height: 503, width: 450, cols: 2 }),
    build(Image, {
      src: 'assets/v/10.jpg',
      height: 1536,
      width: 2048,
      cols: 3,
      name: 'bison'
    }),
    build(Image, {
      src: 'assets/h/3.jpg',
      height: 640,
      width: 1280,
      cols: 2,
      color: 'darkgreen',
      name: 'andrew-marshall-squad'
    }),
    build(Image, {
      src: 'assets/h/6.jpg',
      height: 215,
      width: 350,
      cols: 2,
      color: '#000',
      name: 'street-hoops'
    }),
    build(Image, {
      src: 'assets/v/2.jpg',
      height: 1344,
      width: 1200,
      cols: 2,
      name: 'powder'
    }),

    build(Image, { src: 'assets/h/4.jpg', height: 317, width: 432, cols: 2 }),
    build(Image, { src: 'assets/h/5.jpg', height: 801, width: 1200, cols: 2 }),
    build(Image, { src: 'assets/h/7.jpg', height: 453, width: 604, cols: 2 }),
    build(Image, { src: 'assets/h/8.jpg', height: 448, width: 599, cols: 2 }),
    build(Image, { src: 'assets/h/9.jpg', height: 888, width: 1200, cols: 2 }),
    build(Image, { src: 'assets/h/10.jpg', height: 373, width: 620, cols: 2 }),
    build(Image, { src: 'assets/h/11.jpg', height: 411, width: 620, cols: 2 }),
    build(Image, { src: 'assets/h/13.jpg', height: 533, width: 800, cols: 2 }),
    build(Image, { src: 'assets/h/14.jpg', height: 720, width: 960, cols: 2 }),
    build(Image, { src: 'assets/h/15.jpg', height: 407, width: 604, cols: 2 }),
    build(Image, {
      src: 'assets/h/16.jpg',
      height: 701,
      width: 1024,
      cols: 2,
      name: 'dickinson'
    }),
    build(Image, { src: 'assets/h/17.png', height: 262, width: 350, cols: 2 }),
    build(Image, { src: 'assets/h/18.jpg', height: 262, width: 350, cols: 2 }),
    build(Image, { src: 'assets/h/19.jpg', height: 260, width: 448, cols: 2 }),
    build(Image, { src: 'assets/v/3.jpg', height: 328, width: 300, cols: 1 }),
    build(Image, { src: 'assets/v/4.jpg', height: 350, width: 337, cols: 1 }),
    build(Image, { src: 'assets/v/6.jpg', height: 960, width: 960, cols: 1 }),
    build(Image, { src: 'assets/v/8.jpg', height: 960, width: 960, cols: 1 }),
    build(Image, { src: 'assets/v/9.jpg', height: 450, width: 300, cols: 1 }),
    build(Image, { src: 'assets/v/11.jpg', height: 960, width: 644, cols: 1 })
  ];

  constructor(public store: Store<any>) {
    super(store);
    this.isMobile$ = isMobileSelector(store);
  }

  get offsetLeft(): number {
    return this.isMobile ? 0 : 120;
  }

  get offsetTop(): number {
    return 60;
  }

  get sidenavHeight(): number {
    return this.windowHeight + 50;
  }

  get windowHeight(): number {
    return parseInt(localStorage.getItem('WINDOW_HEIGHT'), 10);
  }

  set windowHeight(value: number) {
    localStorage.setItem('WINDOW_HEIGHT', value.toString());
  }

  get windowWidth(): number {
    return parseInt(localStorage.getItem('WINDOW_WIDTH'), 10);
  }

  set windowWidth(value: number) {
    localStorage.setItem('WINDOW_WIDTH', value.toString());
  }

  ngOnInit() {
    this.sync(['isMobile']);
  }

  @HostListener('window:load', ['$event'])
  onLoad(e: any) {
    this.windowHeight =
      e && e.currentTarget && e.currentTarget.innerHeight
        ? e.currentTarget.innerHeight
        : 0;
    this.windowWidth =
      e && e.currentTarget && e.currentTarget.innerWidth
        ? e.currentTarget.innerWidth
        : 0;
    // console.log('\n\nwindow:load', this.windowWidth, this.windowHeight);
  }

  @HostListener('window:resize', ['$event'])
  onResize(e: any) {
    this.windowHeight =
      e && e.currentTarget && e.currentTarget.innerHeight
        ? e.currentTarget.innerHeight
        : 0;
    this.windowWidth =
      e && e.currentTarget && e.currentTarget.innerWidth
        ? e.currentTarget.innerWidth
        : 0;
    // console.log('\n\nwindow:resize', this.windowWidth, this.windowHeight);
  }
}
