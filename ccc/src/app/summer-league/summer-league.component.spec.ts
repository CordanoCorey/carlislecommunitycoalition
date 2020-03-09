import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SummerLeagueComponent } from './summer-league.component';

describe('SummerLeagueComponent', () => {
  let component: SummerLeagueComponent;
  let fixture: ComponentFixture<SummerLeagueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SummerLeagueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SummerLeagueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
