import { Component, OnInit } from '@angular/core';
import { SmartComponent } from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import { LeagueTeam } from '../../../shared/models';
import { leagueTeamsSelector } from '../../../shared/selectors';

@Component({
  selector: 'ccc-standings',
  templateUrl: './standings.component.html',
  styleUrls: ['./standings.component.scss']
})
export class StandingsComponent extends SmartComponent implements OnInit {
  displayedColumns: string[] = [
    'position',
    'name',
    'pointDiff',
    'wins',
    'losses',
    'winPct'
  ];
  dataSource = [];
  leagueTeams$: Observable<LeagueTeam[]>;
  _leagueTeams: LeagueTeam[] = [];
  constructor(public store: Store<any>) {
    super(store);
    this.leagueTeams$ = leagueTeamsSelector(store);
  }

  set leagueTeams(value: LeagueTeam[]) {
    this._leagueTeams = value;
    this.dataSource = value.map((x, i) => {
      return {
        position: i + 1,
        name: x.team.name,
        pointDiff: x.pointDiff,
        wins: x.wins,
        losses: x.losses,
        winPct: x.winPct,
        teamColor: x.teamColor
      };
    });
  }

  get leagueTeams(): LeagueTeam[] {
    return this._leagueTeams;
  }

  ngOnInit() {
    this.sync(['leagueTeams']);
  }
}
