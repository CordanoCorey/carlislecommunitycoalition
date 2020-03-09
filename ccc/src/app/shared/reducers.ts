import { Action, build } from '@caiu/library';

import {
  Players,
  Teams,
  Leagues,
  Games,
  GameTeams,
  GamePlayers,
  Locations,
  Stats,
  StatCategories,
  TeamStats
} from './models';
import {
  PLAYERS,
  TEAMS,
  LEAGUES,
  GAMES,
  GAME_TEAMS,
  GAME_PLAYERS,
  LOCATIONS,
  STATS,
  TEAM_STATS,
  STAT_CATEGORIES
} from './seed';
import { PlayersActions } from './actions';

export function playersReducer(
  state: Players = build(Players, { items: PLAYERS }),
  action: Action
): Players {
  switch (action.type) {
    case PlayersActions.GET:
      console.dir(action.payload);
      return state.update(action.payload);

    default:
      return state;
  }
}

export function teamsReducer(
  state: Teams = build(Teams, { items: TEAMS }),
  action: Action
): Teams {
  switch (action.type) {
    default:
      return state;
  }
}

export function leaguesReducer(
  state: Leagues = build(Leagues, { items: LEAGUES }),
  action: Action
): Leagues {
  switch (action.type) {
    default:
      return state;
  }
}

export function gamesReducer(
  state: Games = build(Games, { items: GAMES }),
  action: Action
): Games {
  switch (action.type) {
    default:
      return state;
  }
}

export function gameTeamsReducer(
  state: GameTeams = build(GameTeams, { items: GAME_TEAMS }),
  action: Action
): GameTeams {
  switch (action.type) {
    default:
      return state;
  }
}

export function gamePlayersReducer(
  state: GamePlayers = build(GamePlayers, { items: GAME_PLAYERS }),
  action: Action
): GamePlayers {
  switch (action.type) {
    default:
      return state;
  }
}

export function locationsReducer(
  state: Locations = build(Locations, { items: LOCATIONS }),
  action: Action
): Locations {
  switch (action.type) {
    default:
      return state;
  }
}

export function statsReducer(
  state: Stats = build(Stats, { items: STATS }),
  action: Action
): Stats {
  switch (action.type) {
    default:
      return state;
  }
}

export function teamStatsReducer(
  state: TeamStats = build(TeamStats, { items: TEAM_STATS }),
  action: Action
): TeamStats {
  switch (action.type) {
    default:
      return state;
  }
}

export function statCategoriesReducer(
  state: StatCategories = build(StatCategories, { items: STAT_CATEGORIES }),
  action: Action
): StatCategories {
  switch (action.type) {
    default:
      return state;
  }
}
