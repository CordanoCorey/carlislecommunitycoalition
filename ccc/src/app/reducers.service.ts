import { Injectable } from '@angular/core';
import {
  configReducer,
  errorsReducer,
  eventsReducer,
  formReducer,
  lookupReducer,
  messagesReducer,
  redirectsReducer,
  routerReducer,
  sidenavReducer,
  viewSettingsReducer,
  windowReducer
} from '@caiu/library';
import { ActionReducerMap } from '@ngrx/store';

import {
  playersReducer,
  teamsReducer,
  leaguesReducer,
  locationsReducer,
  gamesReducer,
  gameTeamsReducer,
  gamePlayersReducer,
  statsReducer,
  teamStatsReducer,
  statCategoriesReducer
} from './shared/reducers';

@Injectable({
  providedIn: 'root'
})
export class ReducersService {
  constructor() {}

  getReducers(): ActionReducerMap<any> {
    return {
      config: configReducer,
      errors: errorsReducer,
      events: eventsReducer,
      form: formReducer,
      lookup: lookupReducer,
      messages: messagesReducer,
      redirects: redirectsReducer,
      route: routerReducer,
      sidenav: sidenavReducer,
      viewSettings: viewSettingsReducer,
      window: windowReducer,
      players: playersReducer,
      teams: teamsReducer,
      leagues: leaguesReducer,
      locations: locationsReducer,
      games: gamesReducer,
      gameTeams: gameTeamsReducer,
      gamePlayers: gamePlayersReducer,
      statCategories: statCategoriesReducer,
      stats: statsReducer,
      teamStats: teamStatsReducer
    };
  }
}
