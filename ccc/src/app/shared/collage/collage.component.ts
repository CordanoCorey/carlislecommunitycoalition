import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';

import { Collage } from './collage.model';
import { Image } from '../models';
import { Tile } from '../tile/tile.model';

@Component({
  selector: 'ccc-collage',
  templateUrl: './collage.component.html',
  styleUrls: ['./collage.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CollageComponent implements OnInit {

  @Input() images: Image[] = [];
  @Input() canvasHeight = 0;
  @Input() canvasWidth = 0;
  @Input() totalRows = 0;
  @Input() totalColumns = 0;
  @Input() maxRows = 0;
  @Input() maxColumns = 0;

  constructor() { }

  ngOnInit() {
  }

  get collage(): Collage {
    return this.canvasHeight > 0 && this.canvasWidth > 0 ?
      Collage.Build(this.images, this.canvasHeight, this.canvasWidth, this.totalRows, this.totalColumns, this.maxRows, this.maxColumns)
      : new Collage();
  }

  get tiles(): Tile[] {
    return this.collage.tiles;
  }

}
