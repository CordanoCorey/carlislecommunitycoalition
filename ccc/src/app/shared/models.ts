import { LookupValue, Collection, Metadata, Validators } from '@caiu/library';
import { build } from './utils';

export class Player {
  id = 0;
  birthDate: Date = new Date();
  contactId = 0;
  email = '';
  firstName = '';
  jerseyNumberChoice1 = '';
  jerseyNumberChoice2 = '';
  jerseyNumberChoice3 = '';
  jerseySizeId = 0;
  jerseySize: 'S' | 'M' | 'L' | 'XL';
  lastName = '';
  nickname = '';
  phoneNumber = '';
  seasons: PlayerLeagueSeason[] = [];
  isActive = true;

  get metadata(): Metadata {
    return build(Metadata, {
      ignore: [
        'createdById',
        'createdDate',
        'lastModifiedById',
        'lastModifiedDate',
        'contactId',
        'fullName',
        'isActive',
        'jerseySize',
        'nickname',
        'seasons'
      ],
      birthDate: {
        validators: [Validators.required]
      },
      email: {
        validators: [Validators.required, Validators.maxLength(150), Validators.email]
      },
      firstName: {
        validators: [Validators.required, Validators.maxLength(50)]
      },
      lastName: {
        validators: [Validators.required, Validators.maxLength(50)]
      }
    });
  }

  get abbreviatedName(): string {
    return `${(this.nickname || this.firstName).charAt(0)}. ${this.lastName}`;
  }

  get fullName(): string {
    return `${this.nickname || this.firstName} ${this.lastName}`;
  }
}

export class PlayerLeagueSeason {
  id = 0;
  leagueSeasonId = 0;
  playerId = 0;
  jerseyNumberChoice1 = '';
  jerseyNumberChoice2 = '';
  jerseyNumberChoice3 = '';
  jerseySizeId = 0;
}

export class Players extends Collection<Player> {
  constructor() {
    super(Player);
  }

  update(data: Player | Player[]): Players {
    return build(Players, super.update(data));
  }
}

export class Team {
  id = 0;
  color = '';
  name = '';
  initials = '';
  leagueId = 0;
  headCoachId = 0;
  headCoachName = '';
  players: Player[] = [];
}

export class Teams extends Collection<Team> {
  constructor() {
    super(Team);
  }
}

export class League {
  id = 0;
  name = '';
  teams: Team[] = [];
}

export class Leagues extends Collection<League> {
  constructor() {
    super(League);
  }
}

export class Location {
  id = 0;
  name = '';
  locationTypeId = 0;
}

export class Locations extends Collection<Location> {
  constructor() {
    super(Location);
  }
}

export class StatCategory extends LookupValue {
  sportId = 0;
}

export class StatCategories extends Collection<StatCategory> {
  constructor() {
    super(StatCategory);
  }
}

export class Stat {
  id = 0;
  gameId = 0;
  gamePlayerId = 0;
  gameTeamId = 0;
  playerId = 0;
  playerName = '';
  statCategoryId = 0;
  statCategoryName = '';
  teamColor = '';
  teamId = 0;
  total = 0;
}

export class Stats extends Collection<Stat> {
  constructor() {
    super(Stat);
  }
}

export class TeamStat {
  id = 0;
  gameTeamId = 0;
  statCategoryId = 0;
  total = 0;
}

export class TeamStats extends Collection<TeamStat> {
  constructor() {
    super(TeamStat);
  }
}

export class Game {
  id = 0;
  startTime: Date = new Date();
  leagueId = 0;
  locationId = 0;
  locationName = '';
  gameTeams: GameTeam[] = [];
}

export class Games extends Collection<Game> {
  constructor() {
    super(Game);
  }
}

export class GameTeam {
  id = 0;
  gameId = 0;
  teamId = 0;
  teamColor = '';
  teamName = '';
  gameTeamTypeId = 0;
  gameResultTypeId = 0;
  pointDiff = 0;
  players: GamePlayer[] = [];
  teamStats: TeamStat[] = [];

  get score(): number {
    return build(TeamStat, this.teamStats.find(x => x.statCategoryId === 1)).total;
  }

  get statlines(): any[] {
    return this.players.map(x => x.statline);
  }
}

export class GameTeams extends Collection<GameTeam> {
  constructor() {
    super(GameTeam);
  }
}

export class GamePlayer {
  id = 0;
  gameTeamId = 0;
  playerId = 0;
  playerName = '';
  jerseyNumber = '';
  stats: Stat[] = [];

  get statline(): any {
    return this.stats.reduce(
      (acc, stat) => {
        return Object.assign({}, acc, {
          [stat.statCategoryName.toLowerCase()]: stat.total
        });
      },
      { number: this.jerseyNumber, playerName: this.playerName }
    );
  }
}

export class GamePlayers extends Collection<GamePlayer> {
  constructor() {
    super(GamePlayer);
  }
}

export class LeagueTeam {
  games: GameTeam[] = [];
  team: Team = new Team();

  get pointDiff(): number {
    return this.games.reduce((acc, x) => {
      return acc + x.pointDiff;
    }, 0);
  }

  get wins(): number {
    return this.games.filter(x => x.gameResultTypeId === 1).length;
  }

  get winPct(): number {
    return this.wins / (this.wins + this.losses);
  }

  get losses(): number {
    return this.games.filter(x => x.gameResultTypeId === 2).length;
  }

  get ties(): number {
    return this.games.filter(x => x.gameResultTypeId === 3).length;
  }

  get teamColor(): string {
    return this.team.color;
  }
}

export class BoxScore {
  teams: GameTeam[] = [];

  get statlines(): any[][] {
    return this.teams.map(x => x.statlines);
  }
}

export class MenuItem {
  externalLink = '';
  label = '';
  routerLink = '';
  matIcon: string;
}

export class Coordinates {
  row = 0;
  column = 0;
}

export class Dimensions {
  height = 0;
  width = 0;
  rows = 0;
  columns = 0;

  get approxRatio(): number {
    return this.rows / this.columns;
  }

  get ratio(): number {
    return this.height / this.width;
  }
}

export class Image {
  src = '';
  orientation: 'h' | 'v';
  height = 0;
  width = 0;

  get horizontal(): boolean {
    return this.orientation === 'h';
  }

  get vertical(): boolean {
    return this.orientation === 'v';
  }

  get colspan() {
    return this.vertical ? 1 : 1;
  }

  get rowspan() {
    return this.vertical ? 2 : 1;
  }
}

export type TypeConstructor<T> = new () => T;
