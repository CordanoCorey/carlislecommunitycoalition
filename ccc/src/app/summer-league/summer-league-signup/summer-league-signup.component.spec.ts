import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SummerLeagueSignupComponent } from './summer-league-signup.component';

describe('SummerLeagueSignupComponent', () => {
  let component: SummerLeagueSignupComponent;
  let fixture: ComponentFixture<SummerLeagueSignupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SummerLeagueSignupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SummerLeagueSignupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
