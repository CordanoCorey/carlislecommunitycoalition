import { build, LookupValue } from '@caiu/library';

export const LOCATION_TYPES = [];

export const GAME_RESULT_TYPES = [
  build(LookupValue, { id: 1, name: 'WIN' }),
  build(LookupValue, { id: 2, name: 'LOSS' }),
  build(LookupValue, { id: 3, name: 'TIE' })
];

export const GAME_TEAM_TYPES = [];
