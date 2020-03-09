import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SummerLeagueSignupConfirmationComponent } from './summer-league-signup-confirmation.component';

describe('SummerLeagueSignupConfirmationComponent', () => {
  let component: SummerLeagueSignupConfirmationComponent;
  let fixture: ComponentFixture<SummerLeagueSignupConfirmationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SummerLeagueSignupConfirmationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SummerLeagueSignupConfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
