import { Injectable } from '@angular/core';
import { Action, RouterActions } from '@caiu/library';
import { Effect, Actions, ofType } from '@ngrx/effects';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { PlayersActions, PlayerActions } from '../shared/actions';

@Injectable()
export class SummerLeagueEffects {

  /**
   * Redirect to summer league home after signing up.
   */
  @Effect() onSignup: Observable<Action> = this.actions$.pipe(
    ofType(PlayersActions.POST, PlayerActions.PUT),
    map((action: Action) => RouterActions.navigate(`/summer-league/players/${action.payload.id}/signup-confirmation`))
  );

  constructor(private actions$: Actions) {
  }
}
