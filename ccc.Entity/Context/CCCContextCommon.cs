using Microsoft.EntityFrameworkCore;
using ccc.Entity.DataClasses;
using System;

namespace ccc.Entity.Context
{
    public partial class CCCContext
    {
        public virtual DbSet<Draft> Drafts { get; set; }
        public virtual DbSet<DraftPick> DraftPicks { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GamePlayerXref> GamePlayers { get; set; }
        public virtual DbSet<GameTeamXref> GameTeams { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<LeagueSeasonXref> LeagueSeasons { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerLeagueSeasonXref> PlayerSeasons { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<SponsorSeasonXref> SponsorSeasons { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamLeagueSeasonXref> TeamLeagueSeasons { get; set; }
        public virtual DbSet<TeamStat> TeamStats { get; set; }
        public void OnModelCreating_Common(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Draft>(entity =>
            {
                entity.ToTable("Draft", "Common");
            });

            modelBuilder.Entity<DraftPick>(entity =>
            {
                entity.ToTable("DraftPick", "Common");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Game", "Common");

                entity.Property(e => e.StartTime).HasColumnType("date");

                entity.HasOne(d => d.LeagueSeason)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.LeagueSeasonId)
                    .HasConstraintName("FK_Game_LeagueSeason");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Game_Location");

                entity.HasData(
                    new DataClasses.Game
                    {
                        Id = 1,
                        StartTime = new DateTime(2019, 6, 25, 17, 30, 0),
                        LeagueSeasonId = 1,
                        LocationId = 2
                    },
                     new DataClasses.Game
                     {
                         Id = 2,
                         StartTime = new DateTime(2019, 6, 25, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 3,
                         StartTime = new DateTime(2019, 6, 25, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 4,
                         StartTime = new DateTime(2019, 6, 25, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 5,
                         StartTime = new DateTime(2019, 6, 25, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 6,
                         StartTime = new DateTime(2019, 6, 25, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 7,
                         StartTime = new DateTime(2019, 6, 27, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 8,
                         StartTime = new DateTime(2019, 6, 27, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 9,
                         StartTime = new DateTime(2019, 6, 27, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 10,
                         StartTime = new DateTime(2019, 6, 27, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 11,
                         StartTime = new DateTime(2019, 6, 27, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 12,
                         StartTime = new DateTime(2019, 6, 27, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 13,
                         StartTime = new DateTime(2019, 7, 3, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 14,
                         StartTime = new DateTime(2019, 7, 3, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 15,
                         StartTime = new DateTime(2019, 7, 3, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 16,
                         StartTime = new DateTime(2019, 7, 3, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 17,
                         StartTime = new DateTime(2019, 7, 3, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 18,
                         StartTime = new DateTime(2019, 7, 3, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 19,
                         StartTime = new DateTime(2019, 7, 9, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 20,
                         StartTime = new DateTime(2019, 7, 9, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 21,
                         StartTime = new DateTime(2019, 7, 9, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 22,
                         StartTime = new DateTime(2019, 7, 9, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 23,
                         StartTime = new DateTime(2019, 7, 9, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 24,
                         StartTime = new DateTime(2019, 7, 9, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 25,
                         StartTime = new DateTime(2019, 7, 9, 20, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 26,
                         StartTime = new DateTime(2019, 7, 9, 20, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 27,
                         StartTime = new DateTime(2019, 7, 11, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 28,
                         StartTime = new DateTime(2019, 7, 11, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 29,
                         StartTime = new DateTime(2019, 7, 11, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 30,
                         StartTime = new DateTime(2019, 7, 11, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 31,
                         StartTime = new DateTime(2019, 7, 18, 18, 0, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 32,
                         StartTime = new DateTime(2019, 7, 18, 18, 0, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 33,
                         StartTime = new DateTime(2019, 7, 18, 19, 0, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 34,
                         StartTime = new DateTime(2019, 7, 18, 19, 0, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 35,
                         StartTime = new DateTime(2019, 7, 18, 20, 0, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 36,
                         StartTime = new DateTime(2019, 7, 18, 20, 0, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 37,
                         StartTime = new DateTime(2019, 7, 23, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 38,
                         StartTime = new DateTime(2019, 7, 23, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 39,
                         StartTime = new DateTime(2019, 7, 23, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 40,
                         StartTime = new DateTime(2019, 7, 23, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 41,
                         StartTime = new DateTime(2019, 7, 23, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 42,
                         StartTime = new DateTime(2019, 7, 23, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 43,
                         StartTime = new DateTime(2019, 7, 23, 20, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 44,
                         StartTime = new DateTime(2019, 7, 23, 20, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 45,
                         StartTime = new DateTime(2019, 7, 24, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 46,
                         StartTime = new DateTime(2019, 7, 24, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 47,
                         StartTime = new DateTime(2019, 7, 24, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 48,
                         StartTime = new DateTime(2019, 7, 24, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 49,
                         StartTime = new DateTime(2019, 7, 24, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 50,
                         StartTime = new DateTime(2019, 7, 24, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 51,
                         StartTime = new DateTime(2019, 7, 24, 20, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 52,
                         StartTime = new DateTime(2019, 7, 24, 20, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 53,
                         StartTime = new DateTime(2019, 7, 25, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 54,
                         StartTime = new DateTime(2019, 7, 25, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 55,
                         StartTime = new DateTime(2019, 7, 25, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 56,
                         StartTime = new DateTime(2019, 7, 25, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 57,
                         StartTime = new DateTime(2019, 7, 25, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 58,
                         StartTime = new DateTime(2019, 7, 25, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 59,
                         StartTime = new DateTime(2019, 7, 25, 20, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 60,
                         StartTime = new DateTime(2019, 7, 25, 20, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 61,
                         StartTime = new DateTime(2019, 7, 30, 18, 0, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 62,
                         StartTime = new DateTime(2019, 7, 30, 18, 0, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 63,
                         StartTime = new DateTime(2019, 7, 30, 19, 0, 0),
                         LeagueSeasonId = 3,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 64,
                         StartTime = new DateTime(2019, 7, 30, 19, 0, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 65,
                         StartTime = new DateTime(2019, 8, 1, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 66,
                         StartTime = new DateTime(2019, 8, 1, 17, 30, 0),
                         LeagueSeasonId = 1,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 67,
                         StartTime = new DateTime(2019, 8, 1, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 68,
                         StartTime = new DateTime(2019, 8, 1, 18, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 69,
                         StartTime = new DateTime(2019, 8, 1, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 70,
                         StartTime = new DateTime(2019, 8, 1, 19, 30, 0),
                         LeagueSeasonId = 3,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 71,
                         StartTime = new DateTime(2019, 8, 1, 20, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 2
                     },
                     new DataClasses.Game
                     {
                         Id = 72,
                         StartTime = new DateTime(2019, 8, 1, 20, 30, 0),
                         LeagueSeasonId = 2,
                         LocationId = 3
                     },
                     new DataClasses.Game
                     {
                         Id = 73,
                         StartTime = new DateTime(2019, 8, 3, 17, 0, 0),
                         LeagueSeasonId = 1,
                         LocationId = 4
                     },
                     new DataClasses.Game
                     {
                         Id = 74,
                         StartTime = new DateTime(2019, 8, 3, 18, 0, 0),
                         LeagueSeasonId = 2,
                         LocationId = 4
                     },
                     new DataClasses.Game
                     {
                         Id = 75,
                         StartTime = new DateTime(2019, 8, 3, 19, 0, 0),
                         LeagueSeasonId = 3,
                         LocationId = 4
                     }
                );
            });

            modelBuilder.Entity<GamePlayerXref>(entity =>
            {
                entity.ToTable("GamePlayer_xref", "Common");

                entity.Property(e => e.JerseyNumber).HasMaxLength(50);

                entity.HasOne(d => d.GameTeam)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.GameTeamId)
                    .HasConstraintName("FK_GamePlayer_xref_GameTeam");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_GamePlayer_xref_Player");

                entity.HasData(
                  new DataClasses.GamePlayerXref { Id = 1, GameTeamId = 1, PlayerId = 7, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 2, GameTeamId = 1, PlayerId = 6, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 3, GameTeamId = 1, PlayerId = 1, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 4, GameTeamId = 1, PlayerId = 3, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 5, GameTeamId = 1, PlayerId = 2, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 6, GameTeamId = 1, PlayerId = 8, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 7, GameTeamId = 1, PlayerId = 10, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 8, GameTeamId = 1, PlayerId = 4, JerseyNumber = "10" },
                  //new DataClasses.GamePlayerXref { Id = 9, GameTeamId = 2, PlayerId = 0, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 10, GameTeamId = 2, PlayerId = 17, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 11, GameTeamId = 2, PlayerId = 12, JerseyNumber = "3" },
                  //new DataClasses.GamePlayerXref { Id = 12, GameTeamId = 2, PlayerId = 0, JerseyNumber = "5" },
                  //new DataClasses.GamePlayerXref { Id = 13, GameTeamId = 2, PlayerId = 0, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 14, GameTeamId = 2, PlayerId = 15, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 15, GameTeamId = 2, PlayerId = 16, JerseyNumber = "10" },
                  //new DataClasses.GamePlayerXref { Id = 16, GameTeamId = 2, PlayerId = 0, JerseyNumber = "11" },
                  new DataClasses.GamePlayerXref { Id = 17, GameTeamId = 3, PlayerId = 22, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 18, GameTeamId = 3, PlayerId = 20, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 19, GameTeamId = 3, PlayerId = 28, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 20, GameTeamId = 3, PlayerId = 27, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 21, GameTeamId = 3, PlayerId = 25, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 22, GameTeamId = 3, PlayerId = 26, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 23, GameTeamId = 3, PlayerId = 24, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 24,
                      GameTeamId = 3,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref { Id = 25, GameTeamId = 4, PlayerId = 37, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 26, GameTeamId = 4, PlayerId = 29, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 27, GameTeamId = 4, PlayerId = 30, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 28,
                      GameTeamId = 4,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref { Id = 29, GameTeamId = 5, PlayerId = 72, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 30, GameTeamId = 5, PlayerId = 67, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 31, GameTeamId = 5, PlayerId = 66, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 32, GameTeamId = 5, PlayerId = 71, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 33, GameTeamId = 5, PlayerId = 65, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 34, GameTeamId = 5, PlayerId = 68, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 35, GameTeamId = 5, PlayerId = 70, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 36, GameTeamId = 5, PlayerId = 74, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 37, GameTeamId = 6, PlayerId = 83, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 38, GameTeamId = 6, PlayerId = 79, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 39, GameTeamId = 6, PlayerId = 77, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 40, GameTeamId = 6, PlayerId = 76, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 41,
                      GameTeamId = 6,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref { Id = 42, GameTeamId = 6, PlayerId = 75, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 43, GameTeamId = 6, PlayerId = 82, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 44,
                      GameTeamId = 7,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 45,
                      GameTeamId = 7,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 46,
                      GameTeamId = 7,
                      PlayerId = 101,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 47,
                      GameTeamId = 7,
                      PlayerId = 102,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref { Id = 48, GameTeamId = 7, PlayerId = 96, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 49,
                      GameTeamId = 7,
                      PlayerId = 162,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref { Id = 50, GameTeamId = 7, PlayerId = 94, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 51, GameTeamId = 7, PlayerId = 98, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 52, GameTeamId = 7, PlayerId = 97, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 53, GameTeamId = 8, PlayerId = 88, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 54, GameTeamId = 8, PlayerId = 90, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 55, GameTeamId = 8, PlayerId = 93, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 56, GameTeamId = 8, PlayerId = 84, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 57,
                      GameTeamId = 9,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 58,
                      GameTeamId = 9,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 59,
                      GameTeamId = 9,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 60,
                      GameTeamId = 9,
                      PlayerId = 159,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 61,
                      GameTeamId = 9,
                      PlayerId = 129,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 62,
                      GameTeamId = 9,
                      PlayerId = 123,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 63,
                      GameTeamId = 9,
                      PlayerId = 126,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 64,
                      GameTeamId = 9,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 65,
                      GameTeamId = 9,
                      PlayerId = 124,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 66,
                      GameTeamId = 10,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 67,
                      GameTeamId = 10,
                      PlayerId = 147,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 68,
                      GameTeamId = 10,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 69,
                      GameTeamId = 10,
                      PlayerId = 139,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 70,
                      GameTeamId = 10,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 71,
                      GameTeamId = 10,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 72,
                      GameTeamId = 10,
                      PlayerId = 141,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 73,
                      GameTeamId = 11,
                      PlayerId = 116,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 74,
                      GameTeamId = 11,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 75,
                      GameTeamId = 11,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 76,
                      GameTeamId = 11,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 77,
                      GameTeamId = 11,
                      PlayerId = 115,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 78,
                      GameTeamId = 11,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 79,
                      GameTeamId = 11,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 80,
                      GameTeamId = 11,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 81,
                      GameTeamId = 12,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 82,
                      GameTeamId = 12,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 83,
                      GameTeamId = 12,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 84,
                      GameTeamId = 12,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 85,
                      GameTeamId = 12,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 86,
                      GameTeamId = 12,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 87,
                      GameTeamId = 12,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 88,
                      GameTeamId = 13,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 89,
                      GameTeamId = 13,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref { Id = 90, GameTeamId = 13, PlayerId = 165, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 91,
                      GameTeamId = 13,
                      PlayerId = 45,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 92,
                      GameTeamId = 14,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 93,
                      GameTeamId = 14,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref { Id = 94, GameTeamId = 14, PlayerId = 9, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 95,
                      GameTeamId = 14,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 96,
                      GameTeamId = 14,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 97,
                      GameTeamId = 14,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 98,
                      GameTeamId = 14,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref { Id = 99, GameTeamId = 15, PlayerId = 7, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 100,
                      GameTeamId = 15,
                      PlayerId = 6,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 101,
                      GameTeamId = 15,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 102,
                      GameTeamId = 15,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 103,
                      GameTeamId = 15,
                      PlayerId = 2,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 104,
                      GameTeamId = 15,
                      PlayerId = 8,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 105,
                      GameTeamId = 15,
                      PlayerId = 10,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 106,
                      GameTeamId = 16,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 107,
                      GameTeamId = 16,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 108,
                      GameTeamId = 16,
                      PlayerId = 28,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 109,
                      GameTeamId = 16,
                      PlayerId = 27,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 110,
                      GameTeamId = 16,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 111,
                      GameTeamId = 16,
                      PlayerId = 26,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 112,
                      GameTeamId = 16,
                      PlayerId = 24,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 113,
                      GameTeamId = 16,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 114,
                      GameTeamId = 17,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 115,
                      GameTeamId = 17,
                      PlayerId = 56,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 116,
                      GameTeamId = 17,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 117,
                      GameTeamId = 17,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 118,
                      GameTeamId = 17,
                      PlayerId = 61,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 119,
                      GameTeamId = 18,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 120,
                      GameTeamId = 18,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 121,
                      GameTeamId = 18,
                      PlayerId = 102,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 122,
                      GameTeamId = 18,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 123,
                      GameTeamId = 18,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 124,
                      GameTeamId = 18,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 125,
                      GameTeamId = 19,
                      PlayerId = 72,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 126,
                      GameTeamId = 19,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 127,
                      GameTeamId = 19,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 128,
                      GameTeamId = 19,
                      PlayerId = 73,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 129,
                      GameTeamId = 19,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 130,
                      GameTeamId = 19,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 131,
                      GameTeamId = 19,
                      PlayerId = 70,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 132,
                      GameTeamId = 19,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 133,
                      GameTeamId = 20,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 134,
                      GameTeamId = 20,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 135,
                      GameTeamId = 20,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 136,
                      GameTeamId = 20,
                      PlayerId = 86,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 137,
                      GameTeamId = 20,
                      PlayerId = 93,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 138,
                      GameTeamId = 20,
                      PlayerId = 84,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 139,
                      GameTeamId = 20,
                      PlayerId = 91,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 140,
                      GameTeamId = 20,
                      PlayerId = 156,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 141,
                      GameTeamId = 21,
                      PlayerId = 116,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 142,
                      GameTeamId = 21,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 143,
                      GameTeamId = 21,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 144,
                      GameTeamId = 21,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 145,
                      GameTeamId = 21,
                      PlayerId = 115,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 146,
                      GameTeamId = 21,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 147,
                      GameTeamId = 21,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 148,
                      GameTeamId = 21,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 149,
                      GameTeamId = 22,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 150,
                      GameTeamId = 22,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 151,
                      GameTeamId = 22,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 152,
                      GameTeamId = 22,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 153,
                      GameTeamId = 22,
                      PlayerId = 159,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 154,
                      GameTeamId = 22,
                      PlayerId = 129,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 155,
                      GameTeamId = 22,
                      PlayerId = 123,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 156,
                      GameTeamId = 22,
                      PlayerId = 126,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 157,
                      GameTeamId = 22,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 158,
                      GameTeamId = 22,
                      PlayerId = 124,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 159,
                      GameTeamId = 23,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 160,
                      GameTeamId = 23,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 161,
                      GameTeamId = 23,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 162,
                      GameTeamId = 23,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 163,
                      GameTeamId = 23,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 164,
                      GameTeamId = 23,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 165,
                      GameTeamId = 23,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 166,
                      GameTeamId = 24,
                      PlayerId = 135,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 167,
                      GameTeamId = 24,
                      PlayerId = 130,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 168,
                      GameTeamId = 24,
                      PlayerId = 161,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 169,
                      GameTeamId = 24,
                      PlayerId = 136,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 170,
                      GameTeamId = 24,
                      PlayerId = 131,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 171,
                      GameTeamId = 24,
                      PlayerId = 132,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 172,
                      GameTeamId = 25,
                      PlayerId = 7,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 173,
                      GameTeamId = 25,
                      PlayerId = 6,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 174,
                      GameTeamId = 25,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 175,
                      GameTeamId = 25,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 176,
                      GameTeamId = 25,
                      PlayerId = 2,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 177,
                      GameTeamId = 25,
                      PlayerId = 8,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 178,
                      GameTeamId = 25,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 179,
                      GameTeamId = 25,
                      PlayerId = 10,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 180,
                      GameTeamId = 25,
                      PlayerId = 4,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 181,
                      GameTeamId = 26,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 182,
                      GameTeamId = 26,
                      PlayerId = 166,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 183,
                      GameTeamId = 26,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 184,
                      GameTeamId = 26,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 185,
                      GameTeamId = 26,
                      PlayerId = 165,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 186,
                      GameTeamId = 26,
                      PlayerId = 168,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 187,
                      GameTeamId = 26,
                      PlayerId = 45,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 188,
                      GameTeamId = 27,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 189,
                      GameTeamId = 27,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 190,
                      GameTeamId = 27,
                      PlayerId = 28,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 191,
                      GameTeamId = 27,
                      PlayerId = 27,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 192,
                      GameTeamId = 27,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 193,
                      GameTeamId = 27,
                      PlayerId = 26,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 194,
                      GameTeamId = 27,
                      PlayerId = 24,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 195,
                      GameTeamId = 27,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 196,
                      GameTeamId = 28,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 197,
                      GameTeamId = 28,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 198,
                      GameTeamId = 28,
                      PlayerId = 9,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 199,
                      GameTeamId = 28,
                      PlayerId = 53,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 200,
                      GameTeamId = 28,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 201,
                      GameTeamId = 28,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 202,
                      GameTeamId = 28,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 203,
                      GameTeamId = 28,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 204,
                      GameTeamId = 29,
                      PlayerId = 83,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 205,
                      GameTeamId = 29,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 206,
                      GameTeamId = 29,
                      PlayerId = 77,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 207,
                      GameTeamId = 29,
                      PlayerId = 76,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 208,
                      GameTeamId = 29,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 209,
                      GameTeamId = 30,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 210,
                      GameTeamId = 30,
                      PlayerId = 56,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 211,
                      GameTeamId = 30,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 212,
                      GameTeamId = 30,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 213,
                      GameTeamId = 30,
                      PlayerId = 60,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 214,
                      GameTeamId = 30,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 215,
                      GameTeamId = 30,
                      PlayerId = 61,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 216,
                      GameTeamId = 30,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 217,
                      GameTeamId = 31,
                      PlayerId = 72,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 218,
                      GameTeamId = 31,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 219,
                      GameTeamId = 31,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 220,
                      GameTeamId = 31,
                      PlayerId = 73,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 221,
                      GameTeamId = 31,
                      PlayerId = 71,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 222,
                      GameTeamId = 31,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 223,
                      GameTeamId = 31,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 224,
                      GameTeamId = 31,
                      PlayerId = 70,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 225,
                      GameTeamId = 31,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 226,
                      GameTeamId = 32,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 227,
                      GameTeamId = 32,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 228,
                      GameTeamId = 32,
                      PlayerId = 101,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 229,
                      GameTeamId = 32,
                      PlayerId = 102,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 230,
                      GameTeamId = 32,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 231,
                      GameTeamId = 32,
                      PlayerId = 162,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 232,
                      GameTeamId = 32,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 233,
                      GameTeamId = 32,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 234,
                      GameTeamId = 32,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 235,
                      GameTeamId = 33,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 236,
                      GameTeamId = 33,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 237,
                      GameTeamId = 33,
                      PlayerId = 169,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 238,
                      GameTeamId = 33,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 239,
                      GameTeamId = 33,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 240,
                      GameTeamId = 33,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 241,
                      GameTeamId = 33,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 242,
                      GameTeamId = 33,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 243,
                      GameTeamId = 34,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 244,
                      GameTeamId = 34,
                      PlayerId = 147,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 245,
                      GameTeamId = 34,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 246,
                      GameTeamId = 34,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 247,
                      GameTeamId = 34,
                      PlayerId = 139,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 248,
                      GameTeamId = 34,
                      PlayerId = 144,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 249,
                      GameTeamId = 34,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 250,
                      GameTeamId = 34,
                      PlayerId = 141,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 251,
                      GameTeamId = 35,
                      PlayerId = 116,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 252,
                      GameTeamId = 35,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 253,
                      GameTeamId = 35,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 254,
                      GameTeamId = 35,
                      PlayerId = 115,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 255,
                      GameTeamId = 35,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 256,
                      GameTeamId = 35,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 257,
                      GameTeamId = 35,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 258,
                      GameTeamId = 36,
                      PlayerId = 135,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 259,
                      GameTeamId = 36,
                      PlayerId = 130,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 260,
                      GameTeamId = 36,
                      PlayerId = 136,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 261,
                      GameTeamId = 36,
                      PlayerId = 160,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 262,
                      GameTeamId = 36,
                      PlayerId = 170,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 263,
                      GameTeamId = 36,
                      PlayerId = 134,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 264,
                      GameTeamId = 36,
                      PlayerId = 131,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 265,
                      GameTeamId = 37,
                      PlayerId = 37,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 266,
                      GameTeamId = 37,
                      PlayerId = 29,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 267,
                      GameTeamId = 37,
                      PlayerId = 30,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 268,
                      GameTeamId = 37,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 269,
                      GameTeamId = 38,
                      PlayerId = 149,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 270,
                      GameTeamId = 38,
                      PlayerId = 14,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 271,
                      GameTeamId = 38,
                      PlayerId = 12,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 272,
                      GameTeamId = 38,
                      PlayerId = 18,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 273,
                      GameTeamId = 38,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 274,
                      GameTeamId = 38,
                      PlayerId = 16,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 275,
                      GameTeamId = 38,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 276,
                      GameTeamId = 39,
                      PlayerId = 7,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 277,
                      GameTeamId = 39,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 278,
                      GameTeamId = 39,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 279,
                      GameTeamId = 39,
                      PlayerId = 5,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 280,
                      GameTeamId = 39,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 281,
                      GameTeamId = 39,
                      PlayerId = 4,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 282,
                      GameTeamId = 40,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 283,
                      GameTeamId = 40,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 284,
                      GameTeamId = 40,
                      PlayerId = 28,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 285,
                      GameTeamId = 40,
                      PlayerId = 27,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 286,
                      GameTeamId = 40,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 287,
                      GameTeamId = 40,
                      PlayerId = 26,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 288,
                      GameTeamId = 40,
                      PlayerId = 24,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 289,
                      GameTeamId = 40,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 290,
                      GameTeamId = 41,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 291,
                      GameTeamId = 41,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 292,
                      GameTeamId = 41,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 293,
                      GameTeamId = 41,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 294,
                      GameTeamId = 41,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 295,
                      GameTeamId = 42,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 296,
                      GameTeamId = 42,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 297,
                      GameTeamId = 42,
                      PlayerId = 87,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 298,
                      GameTeamId = 42,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 299,
                      GameTeamId = 42,
                      PlayerId = 86,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 300,
                      GameTeamId = 42,
                      PlayerId = 156,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 301,
                      GameTeamId = 42,
                      PlayerId = 93,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 302,
                      GameTeamId = 42,
                      PlayerId = 84,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 303,
                      GameTeamId = 42,
                      PlayerId = 91,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 304,
                      GameTeamId = 43,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 305,
                      GameTeamId = 43,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 306,
                      GameTeamId = 43,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 307,
                      GameTeamId = 43,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 308,
                      GameTeamId = 43,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 309,
                      GameTeamId = 43,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 310,
                      GameTeamId = 44,
                      PlayerId = 83,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 311,
                      GameTeamId = 44,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 312,
                      GameTeamId = 44,
                      PlayerId = 78,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 313,
                      GameTeamId = 44,
                      PlayerId = 77,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 314,
                      GameTeamId = 44,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 315,
                      GameTeamId = 44,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 316,
                      GameTeamId = 45,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 317,
                      GameTeamId = 45,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 318,
                      GameTeamId = 45,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 319,
                      GameTeamId = 45,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 320,
                      GameTeamId = 45,
                      PlayerId = 129,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 321,
                      GameTeamId = 45,
                      PlayerId = 123,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 322,
                      GameTeamId = 45,
                      PlayerId = 126,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 323,
                      GameTeamId = 45,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 324,
                      GameTeamId = 46,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 325,
                      GameTeamId = 46,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 326,
                      GameTeamId = 46,
                      PlayerId = 169,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 327,
                      GameTeamId = 46,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 328,
                      GameTeamId = 46,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 329,
                      GameTeamId = 46,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 330,
                      GameTeamId = 46,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 331,
                      GameTeamId = 46,
                      PlayerId = 171,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 332,
                      GameTeamId = 46,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 333,
                      GameTeamId = 47,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 334,
                      GameTeamId = 47,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 335,
                      GameTeamId = 47,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 336,
                      GameTeamId = 47,
                      PlayerId = 144,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 337,
                      GameTeamId = 47,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 338,
                      GameTeamId = 48,
                      PlayerId = 130,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 339,
                      GameTeamId = 48,
                      PlayerId = 161,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 340,
                      GameTeamId = 48,
                      PlayerId = 160,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 341,
                      GameTeamId = 48,
                      PlayerId = 170,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 342,
                      GameTeamId = 48,
                      PlayerId = 134,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 343,
                      GameTeamId = 48,
                      PlayerId = 131,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 344,
                      GameTeamId = 48,
                      PlayerId = 132,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 345,
                      GameTeamId = 49,
                      PlayerId = 149,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 346,
                      GameTeamId = 49,
                      PlayerId = 14,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 347,
                      GameTeamId = 49,
                      PlayerId = 17,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 348,
                      GameTeamId = 49,
                      PlayerId = 12,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 349,
                      GameTeamId = 49,
                      PlayerId = 18,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 350,
                      GameTeamId = 49,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 351,
                      GameTeamId = 49,
                      PlayerId = 16,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 352,
                      GameTeamId = 49,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 353,
                      GameTeamId = 50,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 354,
                      GameTeamId = 50,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 355,
                      GameTeamId = 50,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 356,
                      GameTeamId = 50,
                      PlayerId = 45,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 357,
                      GameTeamId = 53,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 358,
                      GameTeamId = 53,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 359,
                      GameTeamId = 53,
                      PlayerId = 87,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 360,
                      GameTeamId = 53,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 361,
                      GameTeamId = 53,
                      PlayerId = 86,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 362,
                      GameTeamId = 53,
                      PlayerId = 156,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 363,
                      GameTeamId = 53,
                      PlayerId = 93,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 364,
                      GameTeamId = 53,
                      PlayerId = 84,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 365,
                      GameTeamId = 53,
                      PlayerId = 91,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 366,
                      GameTeamId = 54,
                      PlayerId = 83,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 367,
                      GameTeamId = 54,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 368,
                      GameTeamId = 54,
                      PlayerId = 86,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 369,
                      GameTeamId = 54,
                      PlayerId = 76,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 370,
                      GameTeamId = 54,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 371,
                      GameTeamId = 54,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 372,
                      GameTeamId = 55,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 373,
                      GameTeamId = 55,
                      PlayerId = 73,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 374,
                      GameTeamId = 55,
                      PlayerId = 71,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 375,
                      GameTeamId = 55,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 376,
                      GameTeamId = 55,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 377,
                      GameTeamId = 55,
                      PlayerId = 70,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 378,
                      GameTeamId = 55,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 379,
                      GameTeamId = 56,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 380,
                      GameTeamId = 56,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 381,
                      GameTeamId = 56,
                      PlayerId = 102,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 382,
                      GameTeamId = 56,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 383,
                      GameTeamId = 56,
                      PlayerId = 162,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 384,
                      GameTeamId = 56,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 385,
                      GameTeamId = 56,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 386,
                      GameTeamId = 56,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 387,
                      GameTeamId = 56,
                      PlayerId = 95,
                      JerseyNumber = "12"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 388,
                      GameTeamId = 57,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 389,
                      GameTeamId = 57,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 390,
                      GameTeamId = 57,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 391,
                      GameTeamId = 57,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 392,
                      GameTeamId = 57,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 393,
                      GameTeamId = 57,
                      PlayerId = 171,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 394,
                      GameTeamId = 57,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 395,
                      GameTeamId = 58,
                      PlayerId = 116,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 396,
                      GameTeamId = 58,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 397,
                      GameTeamId = 58,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 398,
                      GameTeamId = 58,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 399,
                      GameTeamId = 58,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 400,
                      GameTeamId = 58,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 401,
                      GameTeamId = 58,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 402,
                      GameTeamId = 59,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 403,
                      GameTeamId = 59,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 404,
                      GameTeamId = 59,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 405,
                      GameTeamId = 59,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 406,
                      GameTeamId = 59,
                      PlayerId = 129,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 407,
                      GameTeamId = 59,
                      PlayerId = 123,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 408,
                      GameTeamId = 59,
                      PlayerId = 126,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 409,
                      GameTeamId = 59,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 410,
                      GameTeamId = 60,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 411,
                      GameTeamId = 60,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 412,
                      GameTeamId = 60,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 413,
                      GameTeamId = 60,
                      PlayerId = 139,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 414,
                      GameTeamId = 60,
                      PlayerId = 144,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 415,
                      GameTeamId = 60,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 416,
                      GameTeamId = 61,
                      PlayerId = 31,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 417,
                      GameTeamId = 61,
                      PlayerId = 32,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 418,
                      GameTeamId = 61,
                      PlayerId = 35,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 419,
                      GameTeamId = 61,
                      PlayerId = 29,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 420,
                      GameTeamId = 61,
                      PlayerId = 30,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 421,
                      GameTeamId = 61,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 422,
                      GameTeamId = 62,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 423,
                      GameTeamId = 62,
                      PlayerId = 166,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 424,
                      GameTeamId = 62,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 425,
                      GameTeamId = 62,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 426,
                      GameTeamId = 62,
                      PlayerId = 165,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 427,
                      GameTeamId = 63,
                      PlayerId = 7,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 428,
                      GameTeamId = 63,
                      PlayerId = 6,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 429,
                      GameTeamId = 63,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 430,
                      GameTeamId = 63,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 431,
                      GameTeamId = 63,
                      PlayerId = 5,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 432,
                      GameTeamId = 63,
                      PlayerId = 8,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 433,
                      GameTeamId = 63,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 434,
                      GameTeamId = 64,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 435,
                      GameTeamId = 64,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 436,
                      GameTeamId = 64,
                      PlayerId = 4,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 437,
                      GameTeamId = 64,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 438,
                      GameTeamId = 67,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 439,
                      GameTeamId = 67,
                      PlayerId = 73,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 440,
                      GameTeamId = 67,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 441,
                      GameTeamId = 67,
                      PlayerId = 69,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 442,
                      GameTeamId = 67,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 443,
                      GameTeamId = 68,
                      PlayerId = 83,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 444,
                      GameTeamId = 68,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 445,
                      GameTeamId = 68,
                      PlayerId = 77,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 446,
                      GameTeamId = 68,
                      PlayerId = 76,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 447,
                      GameTeamId = 68,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 448,
                      GameTeamId = 68,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 449,
                      GameTeamId = 71,
                      PlayerId = 136,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 450,
                      GameTeamId = 71,
                      PlayerId = 161,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 451,
                      GameTeamId = 71,
                      PlayerId = 160,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 452,
                      GameTeamId = 71,
                      PlayerId = 170,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 453,
                      GameTeamId = 71,
                      PlayerId = 134,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 454,
                      GameTeamId = 71,
                      PlayerId = 131,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 455,
                      GameTeamId = 71,
                      PlayerId = 132,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 456,
                      GameTeamId = 72,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 457,
                      GameTeamId = 72,
                      PlayerId = 147,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 458,
                      GameTeamId = 72,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 459,
                      GameTeamId = 72,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 460,
                      GameTeamId = 72,
                      PlayerId = 139,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 461,
                      GameTeamId = 72,
                      PlayerId = 141,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 462,
                      GameTeamId = 73,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 463,
                      GameTeamId = 73,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 464,
                      GameTeamId = 73,
                      PlayerId = 28,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 465,
                      GameTeamId = 73,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 466,
                      GameTeamId = 73,
                      PlayerId = 26,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 467,
                      GameTeamId = 74,
                      PlayerId = 7,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 468,
                      GameTeamId = 74,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 469,
                      GameTeamId = 74,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 470,
                      GameTeamId = 74,
                      PlayerId = 2,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 471,
                      GameTeamId = 74,
                      PlayerId = 5,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 472,
                      GameTeamId = 74,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 473,
                      GameTeamId = 74,
                      PlayerId = 52,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 474,
                      GameTeamId = 75,
                      PlayerId = 149,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 475,
                      GameTeamId = 75,
                      PlayerId = 14,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 476,
                      GameTeamId = 75,
                      PlayerId = 17,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 477,
                      GameTeamId = 75,
                      PlayerId = 12,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 478,
                      GameTeamId = 75,
                      PlayerId = 18,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 479,
                      GameTeamId = 75,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 480,
                      GameTeamId = 75,
                      PlayerId = 16,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 481,
                      GameTeamId = 75,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 482,
                      GameTeamId = 76,
                      PlayerId = 31,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 483,
                      GameTeamId = 76,
                      PlayerId = 32,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 484,
                      GameTeamId = 76,
                      PlayerId = 35,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 485,
                      GameTeamId = 76,
                      PlayerId = 37,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 486,
                      GameTeamId = 76,
                      PlayerId = 30,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 487,
                      GameTeamId = 76,
                      PlayerId = 33,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 488,
                      GameTeamId = 76,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 489,
                      GameTeamId = 77,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 490,
                      GameTeamId = 77,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 491,
                      GameTeamId = 77,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 492,
                      GameTeamId = 77,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 493,
                      GameTeamId = 77,
                      PlayerId = 61,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 494,
                      GameTeamId = 77,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 495,
                      GameTeamId = 78,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 496,
                      GameTeamId = 78,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 497,
                      GameTeamId = 78,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 498,
                      GameTeamId = 78,
                      PlayerId = 69,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 499,
                      GameTeamId = 78,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 500,
                      GameTeamId = 78,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 501,
                      GameTeamId = 79,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 502,
                      GameTeamId = 79,
                      PlayerId = 78,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 503,
                      GameTeamId = 79,
                      PlayerId = 77,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 504,
                      GameTeamId = 79,
                      PlayerId = 76,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 505,
                      GameTeamId = 79,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 506,
                      GameTeamId = 79,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 507,
                      GameTeamId = 80,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 508,
                      GameTeamId = 80,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 509,
                      GameTeamId = 80,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 510,
                      GameTeamId = 80,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 511,
                      GameTeamId = 80,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 512,
                      GameTeamId = 80,
                      PlayerId = 95,
                      JerseyNumber = "12"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 513,
                      GameTeamId = 85,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 514,
                      GameTeamId = 85,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 515,
                      GameTeamId = 85,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 516,
                      GameTeamId = 85,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 517,
                      GameTeamId = 85,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 518,
                      GameTeamId = 86,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 519,
                      GameTeamId = 86,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 520,
                      GameTeamId = 86,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 521,
                      GameTeamId = 86,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 522,
                      GameTeamId = 86,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 523,
                      GameTeamId = 87,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 524,
                      GameTeamId = 87,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 525,
                      GameTeamId = 87,
                      PlayerId = 78,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 526,
                      GameTeamId = 87,
                      PlayerId = 156,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 527,
                      GameTeamId = 87,
                      PlayerId = 93,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 528,
                      GameTeamId = 88,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 529,
                      GameTeamId = 88,
                      PlayerId = 87,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 530,
                      GameTeamId = 88,
                      PlayerId = 86,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 531,
                      GameTeamId = 88,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 532,
                      GameTeamId = 88,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 533,
                      GameTeamId = 89,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 534,
                      GameTeamId = 89,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 535,
                      GameTeamId = 89,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 536,
                      GameTeamId = 89,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 537,
                      GameTeamId = 89,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 538,
                      GameTeamId = 90,
                      PlayerId = 149,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 539,
                      GameTeamId = 90,
                      PlayerId = 17,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 540,
                      GameTeamId = 90,
                      PlayerId = 14,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 541,
                      GameTeamId = 90,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 542,
                      GameTeamId = 90,
                      PlayerId = 16,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 543,
                      GameTeamId = 90,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 544,
                      GameTeamId = 91,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 545,
                      GameTeamId = 91,
                      PlayerId = 166,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 546,
                      GameTeamId = 91,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 547,
                      GameTeamId = 91,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 548,
                      GameTeamId = 91,
                      PlayerId = 165,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 549,
                      GameTeamId = 91,
                      PlayerId = 150,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 550,
                      GameTeamId = 92,
                      PlayerId = 31,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 551,
                      GameTeamId = 92,
                      PlayerId = 32,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 552,
                      GameTeamId = 92,
                      PlayerId = 30,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 553,
                      GameTeamId = 92,
                      PlayerId = 33,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 554,
                      GameTeamId = 92,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 555,
                      GameTeamId = 93,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 556,
                      GameTeamId = 93,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 557,
                      GameTeamId = 93,
                      PlayerId = 58,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 558,
                      GameTeamId = 93,
                      PlayerId = 62,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 559,
                      GameTeamId = 93,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 560,
                      GameTeamId = 94,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 561,
                      GameTeamId = 94,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 562,
                      GameTeamId = 94,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 563,
                      GameTeamId = 94,
                      PlayerId = 162,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 564,
                      GameTeamId = 94,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 565,
                      GameTeamId = 94,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 566,
                      GameTeamId = 94,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 567,
                      GameTeamId = 95,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 568,
                      GameTeamId = 95,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 569,
                      GameTeamId = 95,
                      PlayerId = 87,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 570,
                      GameTeamId = 95,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 571,
                      GameTeamId = 95,
                      PlayerId = 78,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 572,
                      GameTeamId = 95,
                      PlayerId = 156,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 573,
                      GameTeamId = 95,
                      PlayerId = 84,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 574,
                      GameTeamId = 96,
                      PlayerId = 67,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 575,
                      GameTeamId = 96,
                      PlayerId = 66,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 576,
                      GameTeamId = 96,
                      PlayerId = 65,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 577,
                      GameTeamId = 96,
                      PlayerId = 68,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 578,
                      GameTeamId = 96,
                      PlayerId = 74,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 579,
                      GameTeamId = 99,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 580,
                      GameTeamId = 99,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 581,
                      GameTeamId = 99,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 582,
                      GameTeamId = 99,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 583,
                      GameTeamId = 99,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 584,
                      GameTeamId = 99,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 585,
                      GameTeamId = 100,
                      PlayerId = 116,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 586,
                      GameTeamId = 100,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 587,
                      GameTeamId = 100,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 588,
                      GameTeamId = 100,
                      PlayerId = 144,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 589,
                      GameTeamId = 100,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 590,
                      GameTeamId = 101,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 591,
                      GameTeamId = 101,
                      PlayerId = 105,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 592,
                      GameTeamId = 101,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 593,
                      GameTeamId = 101,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 594,
                      GameTeamId = 101,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 595,
                      GameTeamId = 101,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 596,
                      GameTeamId = 102,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 597,
                      GameTeamId = 102,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 598,
                      GameTeamId = 102,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 599,
                      GameTeamId = 102,
                      PlayerId = 126,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 600,
                      GameTeamId = 102,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 601,
                      GameTeamId = 105,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 602,
                      GameTeamId = 105,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 603,
                      GameTeamId = 105,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 604,
                      GameTeamId = 105,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 605,
                      GameTeamId = 105,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 606,
                      GameTeamId = 105,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 607,
                      GameTeamId = 106,
                      PlayerId = 149,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 608,
                      GameTeamId = 106,
                      PlayerId = 14,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 609,
                      GameTeamId = 106,
                      PlayerId = 12,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 610,
                      GameTeamId = 106,
                      PlayerId = 18,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 611,
                      GameTeamId = 106,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 612,
                      GameTeamId = 106,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 613,
                      GameTeamId = 107,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 614,
                      GameTeamId = 107,
                      PlayerId = 166,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 615,
                      GameTeamId = 107,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 616,
                      GameTeamId = 107,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 617,
                      GameTeamId = 107,
                      PlayerId = 165,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 618,
                      GameTeamId = 107,
                      PlayerId = 168,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 619,
                      GameTeamId = 107,
                      PlayerId = 150,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 620,
                      GameTeamId = 108,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 621,
                      GameTeamId = 108,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 622,
                      GameTeamId = 108,
                      PlayerId = 28,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 623,
                      GameTeamId = 108,
                      PlayerId = 21,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 624,
                      GameTeamId = 108,
                      PlayerId = 27,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 625,
                      GameTeamId = 108,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 626,
                      GameTeamId = 108,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 627,
                      GameTeamId = 109,
                      PlayerId = 100,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 628,
                      GameTeamId = 109,
                      PlayerId = 99,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 629,
                      GameTeamId = 109,
                      PlayerId = 102,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 630,
                      GameTeamId = 109,
                      PlayerId = 96,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 631,
                      GameTeamId = 109,
                      PlayerId = 94,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 632,
                      GameTeamId = 109,
                      PlayerId = 98,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 633,
                      GameTeamId = 109,
                      PlayerId = 97,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 634,
                      GameTeamId = 109,
                      PlayerId = 95,
                      JerseyNumber = "12"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 635,
                      GameTeamId = 110,
                      PlayerId = 88,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 636,
                      GameTeamId = 110,
                      PlayerId = 85,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 637,
                      GameTeamId = 110,
                      PlayerId = 87,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 638,
                      GameTeamId = 110,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 639,
                      GameTeamId = 110,
                      PlayerId = 86,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 640,
                      GameTeamId = 110,
                      PlayerId = 156,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 641,
                      GameTeamId = 110,
                      PlayerId = 84,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 642,
                      GameTeamId = 110,
                      PlayerId = 91,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 643,
                      GameTeamId = 111,
                      PlayerId = 83,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 644,
                      GameTeamId = 111,
                      PlayerId = 79,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 645,
                      GameTeamId = 111,
                      PlayerId = 78,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 646,
                      GameTeamId = 111,
                      PlayerId = 77,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 647,
                      GameTeamId = 111,
                      PlayerId = 76,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 648,
                      GameTeamId = 111,
                      PlayerId = 155,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 649,
                      GameTeamId = 111,
                      PlayerId = 75,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 650,
                      GameTeamId = 111,
                      PlayerId = 154,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 651,
                      GameTeamId = 112,
                      PlayerId = 59,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 652,
                      GameTeamId = 112,
                      PlayerId = 57,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 653,
                      GameTeamId = 112,
                      PlayerId = 61,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 654,
                      GameTeamId = 112,
                      PlayerId = 64,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 655,
                      GameTeamId = 113,
                      PlayerId = 143,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 656,
                      GameTeamId = 113,
                      PlayerId = 147,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 657,
                      GameTeamId = 113,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 658,
                      GameTeamId = 113,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 659,
                      GameTeamId = 113,
                      PlayerId = 144,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 660,
                      GameTeamId = 113,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 661,
                      GameTeamId = 113,
                      PlayerId = 141,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 662,
                      GameTeamId = 114,
                      PlayerId = 107,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 663,
                      GameTeamId = 114,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 664,
                      GameTeamId = 114,
                      PlayerId = 111,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 665,
                      GameTeamId = 114,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 666,
                      GameTeamId = 114,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 667,
                      GameTeamId = 114,
                      PlayerId = 171,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 668,
                      GameTeamId = 114,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 669,
                      GameTeamId = 114,
                      PlayerId = 105,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 670,
                      GameTeamId = 114,
                      PlayerId = 131,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 671,
                      GameTeamId = 115,
                      PlayerId = 116,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 672,
                      GameTeamId = 115,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 673,
                      GameTeamId = 115,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 674,
                      GameTeamId = 115,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 675,
                      GameTeamId = 115,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 676,
                      GameTeamId = 115,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 677,
                      GameTeamId = 115,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 678,
                      GameTeamId = 115,
                      PlayerId = 130,
                      JerseyNumber = "14"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 679,
                      GameTeamId = 116,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 680,
                      GameTeamId = 116,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 681,
                      GameTeamId = 116,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 682,
                      GameTeamId = 116,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 683,
                      GameTeamId = 116,
                      PlayerId = 159,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 684,
                      GameTeamId = 116,
                      PlayerId = 122,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 685,
                      GameTeamId = 117,
                      PlayerId = 22,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 686,
                      GameTeamId = 117,
                      PlayerId = 20,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 687,
                      GameTeamId = 117,
                      PlayerId = 27,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 688,
                      GameTeamId = 117,
                      PlayerId = 25,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 689,
                      GameTeamId = 117,
                      PlayerId = 23,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 690,
                      GameTeamId = 118,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 691,
                      GameTeamId = 118,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 692,
                      GameTeamId = 118,
                      PlayerId = 9,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 693,
                      GameTeamId = 118,
                      PlayerId = 153,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 694,
                      GameTeamId = 118,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 695,
                      GameTeamId = 118,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 696,
                      GameTeamId = 118,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 697,
                      GameTeamId = 119,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 698,
                      GameTeamId = 119,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 699,
                      GameTeamId = 119,
                      PlayerId = 2,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 700,
                      GameTeamId = 119,
                      PlayerId = 5,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 701,
                      GameTeamId = 119,
                      PlayerId = 8,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 702,
                      GameTeamId = 119,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 703,
                      GameTeamId = 119,
                      PlayerId = 4,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 704,
                      GameTeamId = 120,
                      PlayerId = 136,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 705,
                      GameTeamId = 120,
                      PlayerId = 14,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 706,
                      GameTeamId = 120,
                      PlayerId = 12,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 707,
                      GameTeamId = 120,
                      PlayerId = 18,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 708,
                      GameTeamId = 120,
                      PlayerId = 15,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 709,
                      GameTeamId = 120,
                      PlayerId = 16,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 710,
                      GameTeamId = 120,
                      PlayerId = 19,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 711,
                      GameTeamId = 87,
                      PlayerId = 90,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 712,
                      GameTeamId = 121,
                      PlayerId = 46,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 713,
                      GameTeamId = 121,
                      PlayerId = 166,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 714,
                      GameTeamId = 121,
                      PlayerId = 167,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 715,
                      GameTeamId = 121,
                      PlayerId = 40,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 716,
                      GameTeamId = 121,
                      PlayerId = 165,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 717,
                      GameTeamId = 121,
                      PlayerId = 168,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 718,
                      GameTeamId = 122,
                      PlayerId = 48,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 719,
                      GameTeamId = 122,
                      PlayerId = 49,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 720,
                      GameTeamId = 122,
                      PlayerId = 47,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 721,
                      GameTeamId = 122,
                      PlayerId = 52,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 722,
                      GameTeamId = 122,
                      PlayerId = 151,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 723,
                      GameTeamId = 123,
                      PlayerId = 7,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 724,
                      GameTeamId = 123,
                      PlayerId = 1,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 725,
                      GameTeamId = 123,
                      PlayerId = 3,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 726,
                      GameTeamId = 123,
                      PlayerId = 2,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 727,
                      GameTeamId = 123,
                      PlayerId = 5,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 728,
                      GameTeamId = 123,
                      PlayerId = 8,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 729,
                      GameTeamId = 123,
                      PlayerId = 164,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 730,
                      GameTeamId = 123,
                      PlayerId = 10,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 731,
                      GameTeamId = 124,
                      PlayerId = 31,
                      JerseyNumber = "00"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 732,
                      GameTeamId = 124,
                      PlayerId = 32,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 733,
                      GameTeamId = 124,
                      PlayerId = 37,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 734,
                      GameTeamId = 124,
                      PlayerId = 29,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 735,
                      GameTeamId = 124,
                      PlayerId = 30,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 736,
                      GameTeamId = 124,
                      PlayerId = 33,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 737,
                      GameTeamId = 124,
                      PlayerId = 36,
                      JerseyNumber = "10"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 738,
                      GameTeamId = 125,
                      PlayerId = 147,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 739,
                      GameTeamId = 125,
                      PlayerId = 140,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 740,
                      GameTeamId = 125,
                      PlayerId = 146,
                      JerseyNumber = "4"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 741,
                      GameTeamId = 125,
                      PlayerId = 139,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 742,
                      GameTeamId = 125,
                      PlayerId = 142,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 743,
                      GameTeamId = 125,
                      PlayerId = 141,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 744,
                      GameTeamId = 125,
                      PlayerId = 170,
                      JerseyNumber = "14"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 745,
                      GameTeamId = 125,
                      PlayerId = 135,
                      JerseyNumber = "15"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 746,
                      GameTeamId = 126,
                      PlayerId = 121,
                      JerseyNumber = "0"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 747,
                      GameTeamId = 126,
                      PlayerId = 127,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 748,
                      GameTeamId = 126,
                      PlayerId = 125,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 749,
                      GameTeamId = 126,
                      PlayerId = 158,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 750,
                      GameTeamId = 126,
                      PlayerId = 161,
                      JerseyNumber = "16"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 751,
                      GameTeamId = 126,
                      PlayerId = 136,
                      JerseyNumber = "18"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 752,
                      GameTeamId = 127,
                      PlayerId = 157,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 753,
                      GameTeamId = 127,
                      PlayerId = 113,
                      JerseyNumber = "3"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 754,
                      GameTeamId = 127,
                      PlayerId = 120,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 755,
                      GameTeamId = 127,
                      PlayerId = 112,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 756,
                      GameTeamId = 127,
                      PlayerId = 114,
                      JerseyNumber = "9"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 757,
                      GameTeamId = 127,
                      PlayerId = 130,
                      JerseyNumber = "14"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 758,
                      GameTeamId = 128,
                      PlayerId = 109,
                      JerseyNumber = "1"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 759,
                      GameTeamId = 128,
                      PlayerId = 104,
                      JerseyNumber = "5"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 760,
                      GameTeamId = 128,
                      PlayerId = 80,
                      JerseyNumber = "6"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 761,
                      GameTeamId = 128,
                      PlayerId = 171,
                      JerseyNumber = "7"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 762,
                      GameTeamId = 128,
                      PlayerId = 106,
                      JerseyNumber = "8"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 763,
                      GameTeamId = 128,
                      PlayerId = 105,
                      JerseyNumber = "11"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 764,
                      GameTeamId = 128,
                      PlayerId = 131,
                      JerseyNumber = "14"
                  },
                  new DataClasses.GamePlayerXref
                  {
                      Id = 765,
                      GameTeamId = 127,
                      PlayerId = 117,
                      JerseyNumber = "2"
                  },
                  new DataClasses.GamePlayerXref { Id = 766, GameTeamId = 129, PlayerId = 46, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 767, GameTeamId = 129, PlayerId = 166, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 768, GameTeamId = 129, PlayerId = 167, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 769, GameTeamId = 129, PlayerId = 40, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 770, GameTeamId = 129, PlayerId = 165, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 771, GameTeamId = 129, PlayerId = 168, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 772, GameTeamId = 129, PlayerId = 150, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 773, GameTeamId = 130, PlayerId = 149, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 774, GameTeamId = 130, PlayerId = 14, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 775, GameTeamId = 130, PlayerId = 12, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 776, GameTeamId = 130, PlayerId = 18, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 777, GameTeamId = 130, PlayerId = 15, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 778, GameTeamId = 130, PlayerId = 16, JerseyNumber = "10" },
                  new DataClasses.GamePlayerXref { Id = 779, GameTeamId = 130, PlayerId = 19, JerseyNumber = "11" },
                  new DataClasses.GamePlayerXref { Id = 780, GameTeamId = 131, PlayerId = 22, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 781, GameTeamId = 131, PlayerId = 25, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 782, GameTeamId = 131, PlayerId = 26, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 783, GameTeamId = 131, PlayerId = 24, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 784, GameTeamId = 132, PlayerId = 31, JerseyNumber = "00" },
                  new DataClasses.GamePlayerXref { Id = 785, GameTeamId = 132, PlayerId = 32, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 786, GameTeamId = 132, PlayerId = 35, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 787, GameTeamId = 132, PlayerId = 37, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 788, GameTeamId = 132, PlayerId = 29, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 789, GameTeamId = 132, PlayerId = 30, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 790, GameTeamId = 132, PlayerId = 36, JerseyNumber = "10" },
                  new DataClasses.GamePlayerXref { Id = 791, GameTeamId = 133, PlayerId = 100, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 792, GameTeamId = 133, PlayerId = 99, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 793, GameTeamId = 133, PlayerId = 102, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 794, GameTeamId = 133, PlayerId = 162, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 795, GameTeamId = 133, PlayerId = 98, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 796, GameTeamId = 133, PlayerId = 95, JerseyNumber = "12" },
                  new DataClasses.GamePlayerXref { Id = 798, GameTeamId = 134, PlayerId = 59, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 799, GameTeamId = 134, PlayerId = 56, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 800, GameTeamId = 134, PlayerId = 58, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 801, GameTeamId = 134, PlayerId = 60, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 802, GameTeamId = 134, PlayerId = 64, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 803, GameTeamId = 135, PlayerId = 67, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 804, GameTeamId = 135, PlayerId = 66, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 805, GameTeamId = 135, PlayerId = 73, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 806, GameTeamId = 135, PlayerId = 65, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 807, GameTeamId = 135, PlayerId = 68, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 808, GameTeamId = 135, PlayerId = 70, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 809, GameTeamId = 135, PlayerId = 74, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 810, GameTeamId = 136, PlayerId = 88, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 811, GameTeamId = 136, PlayerId = 85, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 812, GameTeamId = 136, PlayerId = 90, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 813, GameTeamId = 136, PlayerId = 86, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 814, GameTeamId = 136, PlayerId = 93, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 815, GameTeamId = 136, PlayerId = 84, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 816, GameTeamId = 137, PlayerId = 116, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 817, GameTeamId = 137, PlayerId = 157, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 818, GameTeamId = 137, PlayerId = 113, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 819, GameTeamId = 137, PlayerId = 115, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 820, GameTeamId = 137, PlayerId = 120, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 821, GameTeamId = 137, PlayerId = 112, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 822, GameTeamId = 137, PlayerId = 114, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 823, GameTeamId = 137, PlayerId = 130, JerseyNumber = "14" },
                  new DataClasses.GamePlayerXref { Id = 824, GameTeamId = 138, PlayerId = 121, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 825, GameTeamId = 138, PlayerId = 127, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 826, GameTeamId = 138, PlayerId = 125, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 827, GameTeamId = 138, PlayerId = 158, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 828, GameTeamId = 138, PlayerId = 122, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 829, GameTeamId = 138, PlayerId = 161, JerseyNumber = "16" },
                  new DataClasses.GamePlayerXref { Id = 830, GameTeamId = 138, PlayerId = 136, JerseyNumber = "18" },
                  new DataClasses.GamePlayerXref { Id = 831, GameTeamId = 139, PlayerId = 109, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 832, GameTeamId = 139, PlayerId = 105, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 833, GameTeamId = 139, PlayerId = 111, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 834, GameTeamId = 139, PlayerId = 104, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 835, GameTeamId = 139, PlayerId = 80, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 836, GameTeamId = 139, PlayerId = 106, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 837, GameTeamId = 139, PlayerId = 131, JerseyNumber = "14" },
                  new DataClasses.GamePlayerXref { Id = 838, GameTeamId = 140, PlayerId = 143, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 839, GameTeamId = 140, PlayerId = 140, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 840, GameTeamId = 140, PlayerId = 146, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 841, GameTeamId = 140, PlayerId = 139, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 842, GameTeamId = 140, PlayerId = 141, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 843, GameTeamId = 140, PlayerId = 135, JerseyNumber = "15" },
                  new DataClasses.GamePlayerXref { Id = 844, GameTeamId = 141, PlayerId = 83, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 845, GameTeamId = 141, PlayerId = 79, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 846, GameTeamId = 141, PlayerId = 78, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 847, GameTeamId = 141, PlayerId = 77, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 848, GameTeamId = 141, PlayerId = 76, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 849, GameTeamId = 141, PlayerId = 155, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 850, GameTeamId = 141, PlayerId = 75, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 851, GameTeamId = 142, PlayerId = 88, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 852, GameTeamId = 142, PlayerId = 85, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 853, GameTeamId = 142, PlayerId = 87, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 854, GameTeamId = 142, PlayerId = 90, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 855, GameTeamId = 142, PlayerId = 86, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 856, GameTeamId = 142, PlayerId = 156, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 857, GameTeamId = 142, PlayerId = 84, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 858, GameTeamId = 143, PlayerId = 100, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 859, GameTeamId = 143, PlayerId = 99, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 860, GameTeamId = 143, PlayerId = 102, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 861, GameTeamId = 143, PlayerId = 162, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 862, GameTeamId = 143, PlayerId = 94, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 863, GameTeamId = 143, PlayerId = 98, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 864, GameTeamId = 143, PlayerId = 95, JerseyNumber = "12" },
                  new DataClasses.GamePlayerXref { Id = 865, GameTeamId = 144, PlayerId = 67, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 866, GameTeamId = 144, PlayerId = 66, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 867, GameTeamId = 144, PlayerId = 73, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 868, GameTeamId = 144, PlayerId = 65, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 869, GameTeamId = 144, PlayerId = 69, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 870, GameTeamId = 144, PlayerId = 68, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 871, GameTeamId = 144, PlayerId = 70, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 872, GameTeamId = 144, PlayerId = 74, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 873, GameTeamId = 145, PlayerId = 49, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 874, GameTeamId = 145, PlayerId = 53, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 875, GameTeamId = 145, PlayerId = 153, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 876, GameTeamId = 145, PlayerId = 47, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 877, GameTeamId = 145, PlayerId = 52, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 878, GameTeamId = 145, PlayerId = 151, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 879, GameTeamId = 146, PlayerId = 46, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 880, GameTeamId = 146, PlayerId = 166, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 881, GameTeamId = 146, PlayerId = 167, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 882, GameTeamId = 146, PlayerId = 40, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 883, GameTeamId = 146, PlayerId = 165, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 884, GameTeamId = 146, PlayerId = 150, JerseyNumber = "7" },
                  new DataClasses.GamePlayerXref { Id = 885, GameTeamId = 147, PlayerId = 83, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 886, GameTeamId = 147, PlayerId = 79, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 887, GameTeamId = 147, PlayerId = 78, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 888, GameTeamId = 147, PlayerId = 77, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 889, GameTeamId = 147, PlayerId = 76, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 890, GameTeamId = 147, PlayerId = 155, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 891, GameTeamId = 147, PlayerId = 75, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 892, GameTeamId = 148, PlayerId = 100, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 893, GameTeamId = 148, PlayerId = 99, JerseyNumber = "1" },
                  // new DataClasses.GamePlayerXref { Id = , GameTeamId = 148, PlayerId = 102, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 894, GameTeamId = 148, PlayerId = 96, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 895, GameTeamId = 148, PlayerId = 162, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 896, GameTeamId = 148, PlayerId = 94, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 897, GameTeamId = 148, PlayerId = 98, JerseyNumber = "7" },
                  // new DataClasses.GamePlayerXref { Id = , GameTeamId = 148, PlayerId = 97, JerseyNumber = "8" },
                  // new DataClasses.GamePlayerXref { Id = , GameTeamId = 148, PlayerId = 95, JerseyNumber = "12" },
                  new DataClasses.GamePlayerXref { Id = 898, GameTeamId = 149, PlayerId = 116, JerseyNumber = "0" },
                  new DataClasses.GamePlayerXref { Id = 899, GameTeamId = 149, PlayerId = 157, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 900, GameTeamId = 149, PlayerId = 117, JerseyNumber = "2" },
                  new DataClasses.GamePlayerXref { Id = 901, GameTeamId = 149, PlayerId = 113, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 902, GameTeamId = 149, PlayerId = 115, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 903, GameTeamId = 149, PlayerId = 120, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 904, GameTeamId = 149, PlayerId = 112, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 905, GameTeamId = 149, PlayerId = 114, JerseyNumber = "9" },
                  new DataClasses.GamePlayerXref { Id = 906, GameTeamId = 149, PlayerId = 130, JerseyNumber = "14" },
                  new DataClasses.GamePlayerXref { Id = 907, GameTeamId = 150, PlayerId = 109, JerseyNumber = "1" },
                  new DataClasses.GamePlayerXref { Id = 908, GameTeamId = 150, PlayerId = 105, JerseyNumber = "3" },
                  new DataClasses.GamePlayerXref { Id = 909, GameTeamId = 150, PlayerId = 111, JerseyNumber = "4" },
                  new DataClasses.GamePlayerXref { Id = 910, GameTeamId = 150, PlayerId = 104, JerseyNumber = "5" },
                  new DataClasses.GamePlayerXref { Id = 911, GameTeamId = 150, PlayerId = 80, JerseyNumber = "6" },
                  new DataClasses.GamePlayerXref { Id = 912, GameTeamId = 150, PlayerId = 106, JerseyNumber = "8" },
                  new DataClasses.GamePlayerXref { Id = 913, GameTeamId = 150, PlayerId = 131, JerseyNumber = "14" }
                );
            });

            modelBuilder.Entity<GameTeamXref>(entity =>
            {
                entity.ToTable("GameTeam_xref", "Common");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_GameTeam_xref_Game");

                entity.HasOne(d => d.GameResultType)
                    .WithMany(p => p.GameTeams)
                    .HasForeignKey(d => d.GameResultTypeId)
                    .HasConstraintName("FK_GameTeam_xref_GameResultType");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_GameTeam_xref_Team");

                entity.HasData(
                 new DataClasses.GameTeamXref { Id = 1, GameId = 1, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 2, GameId = 1, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 3, GameId = 2, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 4, GameId = 2, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 5, GameId = 3, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 6, GameId = 3, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 7, GameId = 4, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 8, GameId = 4, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 9, GameId = 5, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 10, GameId = 5, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 11, GameId = 6, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 12, GameId = 6, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 13, GameId = 7, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 14, GameId = 7, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 15, GameId = 8, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 16, GameId = 8, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 17, GameId = 9, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 18, GameId = 9, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 19, GameId = 10, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 20, GameId = 10, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 21, GameId = 11, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 22, GameId = 11, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 23, GameId = 12, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 24, GameId = 12, TeamId = 15 },
                 new DataClasses.GameTeamXref { Id = 25, GameId = 13, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 26, GameId = 13, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 27, GameId = 14, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 28, GameId = 14, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 29, GameId = 15, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 30, GameId = 15, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 31, GameId = 16, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 32, GameId = 16, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 33, GameId = 17, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 34, GameId = 17, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 35, GameId = 18, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 36, GameId = 18, TeamId = 15 },
                 new DataClasses.GameTeamXref { Id = 37, GameId = 19, TeamId = 4 }, // CVR
                 new DataClasses.GameTeamXref { Id = 38, GameId = 19, TeamId = 2 }, // GBS
                 new DataClasses.GameTeamXref { Id = 39, GameId = 20, TeamId = 1 }, // C-Luv
                 new DataClasses.GameTeamXref { Id = 40, GameId = 20, TeamId = 3 }, // CHA
                 new DataClasses.GameTeamXref { Id = 41, GameId = 21, TeamId = 7 }, // C-Luv
                 new DataClasses.GameTeamXref { Id = 42, GameId = 21, TeamId = 8 }, // GBS
                 new DataClasses.GameTeamXref { Id = 43, GameId = 22, TeamId = 9 }, // CHA
                 new DataClasses.GameTeamXref { Id = 44, GameId = 22, TeamId = 10 }, // CVR
                 new DataClasses.GameTeamXref { Id = 45, GameId = 23, TeamId = 12 }, // C-Luv
                 new DataClasses.GameTeamXref { Id = 46, GameId = 23, TeamId = 13 }, // GBS
                 new DataClasses.GameTeamXref { Id = 47, GameId = 24, TeamId = 14 }, // CHA
                 new DataClasses.GameTeamXref { Id = 48, GameId = 24, TeamId = 15 }, // CVR
                 new DataClasses.GameTeamXref { Id = 49, GameId = 25, TeamId = 2 }, // GBS
                 new DataClasses.GameTeamXref { Id = 50, GameId = 25, TeamId = 5 }, // PBH
                 new DataClasses.GameTeamXref { Id = 51, GameId = 26, TeamId = 4, GameResultTypeId = 2 }, // CVR
                 new DataClasses.GameTeamXref { Id = 52, GameId = 26, TeamId = 6, GameResultTypeId = 1 }, // CCC
                 new DataClasses.GameTeamXref { Id = 53, GameId = 27, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 54, GameId = 27, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 55, GameId = 28, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 56, GameId = 28, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 57, GameId = 29, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 58, GameId = 29, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 59, GameId = 30, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 60, GameId = 30, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 61, GameId = 31, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 62, GameId = 31, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 63, GameId = 32, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 64, GameId = 32, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 65, GameId = 33, TeamId = 7, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 66, GameId = 33, TeamId = 8, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 67, GameId = 34, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 68, GameId = 34, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 69, GameId = 35, TeamId = 12, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 70, GameId = 35, TeamId = 16, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 71, GameId = 36, TeamId = 15 },
                 new DataClasses.GameTeamXref { Id = 72, GameId = 36, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 73, GameId = 37, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 74, GameId = 37, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 75, GameId = 38, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 76, GameId = 38, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 77, GameId = 39, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 78, GameId = 39, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 79, GameId = 40, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 80, GameId = 40, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 81, GameId = 41, TeamId = 13, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 82, GameId = 41, TeamId = 15, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 83, GameId = 42, TeamId = 16, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 84, GameId = 42, TeamId = 14, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 85, GameId = 43, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 86, GameId = 43, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 87, GameId = 44, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 88, GameId = 44, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 89, GameId = 45, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 90, GameId = 45, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 91, GameId = 46, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 92, GameId = 46, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 93, GameId = 47, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 94, GameId = 47, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 95, GameId = 48, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 96, GameId = 48, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 97, GameId = 49, TeamId = 15, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 98, GameId = 49, TeamId = 12, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 99, GameId = 50, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 100, GameId = 50, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 101, GameId = 51, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 102, GameId = 51, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 103, GameId = 52, TeamId = 16, GameResultTypeId = 1 },
                 new DataClasses.GameTeamXref { Id = 104, GameId = 52, TeamId = 15, GameResultTypeId = 2 },
                 new DataClasses.GameTeamXref { Id = 105, GameId = 53, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 106, GameId = 53, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 107, GameId = 54, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 108, GameId = 54, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 109, GameId = 55, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 110, GameId = 55, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 111, GameId = 56, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 112, GameId = 56, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 113, GameId = 57, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 114, GameId = 57, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 115, GameId = 58, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 116, GameId = 58, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 117, GameId = 59, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 118, GameId = 59, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 119, GameId = 60, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 120, GameId = 60, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 121, GameId = 61, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 122, GameId = 61, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 123, GameId = 62, TeamId = 1 },
                 new DataClasses.GameTeamXref { Id = 124, GameId = 62, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 125, GameId = 63, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 126, GameId = 63, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 127, GameId = 64, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 128, GameId = 64, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 129, GameId = 65, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 130, GameId = 65, TeamId = 2 },
                 new DataClasses.GameTeamXref { Id = 131, GameId = 66, TeamId = 3 },
                 new DataClasses.GameTeamXref { Id = 132, GameId = 66, TeamId = 4 },
                 new DataClasses.GameTeamXref { Id = 133, GameId = 67, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 134, GameId = 67, TeamId = 7 },
                 new DataClasses.GameTeamXref { Id = 135, GameId = 68, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 136, GameId = 68, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 137, GameId = 69, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 138, GameId = 69, TeamId = 12 },
                 new DataClasses.GameTeamXref { Id = 139, GameId = 70, TeamId = 13 },
                 new DataClasses.GameTeamXref { Id = 140, GameId = 70, TeamId = 14 },
                 new DataClasses.GameTeamXref { Id = 141, GameId = 71, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 142, GameId = 71, TeamId = 8 },
                 new DataClasses.GameTeamXref { Id = 143, GameId = 72, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 144, GameId = 72, TeamId = 11 },
                 new DataClasses.GameTeamXref { Id = 145, GameId = 73, TeamId = 6 },
                 new DataClasses.GameTeamXref { Id = 146, GameId = 73, TeamId = 5 },
                 new DataClasses.GameTeamXref { Id = 147, GameId = 74, TeamId = 10 },
                 new DataClasses.GameTeamXref { Id = 148, GameId = 74, TeamId = 9 },
                 new DataClasses.GameTeamXref { Id = 149, GameId = 75, TeamId = 16 },
                 new DataClasses.GameTeamXref { Id = 150, GameId = 75, TeamId = 13 }
                );
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.ToTable("League", "Common");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasData(
                  new DataClasses.League { Id = 1, Name = "10U" },
                  new DataClasses.League { Id = 2, Name = "12U" },
                  new DataClasses.League { Id = 3, Name = "14U" }
                );
            });

            modelBuilder.Entity<LeagueSeasonXref>(entity =>
            {
                entity.ToTable("LeagueSeason_xref", "Common");

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.LeagueId)
                    .HasConstraintName("FK_LeagueSeason_League");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Leagues)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_LeagueSeason_Season");

                entity.HasData(
                  new DataClasses.LeagueSeasonXref { Id = 1, LeagueId = 1, SeasonId = 1 },
                  new DataClasses.LeagueSeasonXref { Id = 2, LeagueId = 2, SeasonId = 1 },
                  new DataClasses.LeagueSeasonXref { Id = 3, LeagueId = 3, SeasonId = 1 },
                  new DataClasses.LeagueSeasonXref { Id = 4, LeagueId = 1, SeasonId = 2 },
                  new DataClasses.LeagueSeasonXref { Id = 5, LeagueId = 2, SeasonId = 2 },
                  new DataClasses.LeagueSeasonXref { Id = 6, LeagueId = 3, SeasonId = 2 }
                );
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location", "Common");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.LocationTypeId)
                    .HasConstraintName("FK_Location_LocationType");

                entity.HasData(
                  new DataClasses.Location { Id = 1, Name = "Memorial Park", LocationTypeId = 1 },
                  new DataClasses.Location { Id = 2, Name = "Partnership for Better Health", LocationTypeId = 2 },
                  new DataClasses.Location { Id = 3, Name = "GB Stuart Foundation", LocationTypeId = 2 },
                  new DataClasses.Location { Id = 4, Name = "CHAMPIONSHIP COURT", LocationTypeId = 2 }
                );
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player", "Common");

                entity.Property(e => e.BirthDate).HasColumnType("date");
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.Nickname).HasMaxLength(100);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Player_Contact");

                entity.HasData(
                  new DataClasses.Player { Id = 1, FirstName = "Damauri", LastName = "Thomas", ContactId = 59, BirthDate = new DateTime(2011, 11, 6) },
                  new DataClasses.Player { Id = 2, FirstName = "Drake", LastName = "Kelley", ContactId = 100, BirthDate = new DateTime(2010, 12, 15) },
                  new DataClasses.Player { Id = 3, FirstName = "Javoni", LastName = "Porter", ContactId = 80, BirthDate = new DateTime(2010, 3, 17) },
                  new DataClasses.Player { Id = 4, FirstName = "Isaiah", LastName = "Robinson", ContactId = 31, BirthDate = new DateTime(2010, 3, 12) },
                  new DataClasses.Player { Id = 5, FirstName = "Kaleb", LastName = "Mjuholland", ContactId = 116, BirthDate = null },
                  new DataClasses.Player { Id = 6, FirstName = "Jadon", LastName = "Kipp", ContactId = 112, BirthDate = new DateTime(2008, 12, 2) },
                  new DataClasses.Player { Id = 7, FirstName = "Damion", LastName = "Roth", Nickname = "Jace", ContactId = 120, BirthDate = new DateTime(2009, 11, 14) },
                  new DataClasses.Player { Id = 8, FirstName = "Tayah", LastName = "Felton", ContactId = 109, BirthDate = new DateTime(2009, 10, 12) },
                  new DataClasses.Player { Id = 9, FirstName = "T\'oure", LastName = "Evans", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 10, FirstName = "Wesley", LastName = "Heckman", ContactId = 86, BirthDate = new DateTime(2011, 6, 10) },
                  new DataClasses.Player { Id = 11, FirstName = "Khadr", LastName = "Vasser", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 12, FirstName = "Austin", LastName = "Marshall", ContactId = 34, BirthDate = new DateTime(2009, 7, 24) },
                  new DataClasses.Player { Id = 13, FirstName = "Amari", LastName = "Ibrahim", IsActive = false, ContactId = 131, BirthDate = new DateTime(2013, 12, 21) },
                  new DataClasses.Player { Id = 14, FirstName = "Summer", LastName = "Kunza", ContactId = 113, BirthDate = new DateTime(2009, 1, 26) },
                  new DataClasses.Player { Id = 15, FirstName = "Carter", LastName = "Wilson", ContactId = 98, BirthDate = new DateTime(2008, 10, 31) },
                  new DataClasses.Player { Id = 16, FirstName = "Jayde", LastName = "Wilson", ContactId = 98, BirthDate = new DateTime(2009, 11, 2) },
                  new DataClasses.Player { Id = 17, FirstName = "Chester", LastName = "Wilson", Nickname = "CJ", ContactId = 56, BirthDate = new DateTime(2009, 12, 29) },
                  new DataClasses.Player { Id = 18, FirstName = "Shaun", LastName = "Smith", ContactId = 78, BirthDate = new DateTime(2010, 12, 19) },
                  new DataClasses.Player { Id = 19, FirstName = "Azmina", LastName = "Palmer", ContactId = 135, BirthDate = new DateTime(2009, 8, 27) },
                  new DataClasses.Player { Id = 20, FirstName = "Trevon", LastName = "Harris", Nickname = "Trey", ContactId = 54, BirthDate = new DateTime(2009, 12, 29) },
                  new DataClasses.Player { Id = 21, FirstName = "Xzavier", LastName = "Tatum", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 22, FirstName = "Eisley", LastName = "Seretti", ContactId = 30, BirthDate = new DateTime(2009, 8, 20) },
                  new DataClasses.Player { Id = 23, FirstName = "Jack", LastName = "Becket", ContactId = 136, BirthDate = new DateTime(2009, 1, 10) },
                  new DataClasses.Player { Id = 24, FirstName = "Jace", LastName = "Dagaetano", ContactId = 106, BirthDate = new DateTime(2010, 7, 13) },
                  new DataClasses.Player { Id = 25, FirstName = "Bishop", LastName = "Campbell", ContactId = 48, BirthDate = new DateTime(2010, 1, 1) },
                  new DataClasses.Player { Id = 26, FirstName = "Gus", LastName = "Yarnell", ContactId = 96, BirthDate = new DateTime(2009, 11, 28) },
                  new DataClasses.Player { Id = 27, FirstName = "Sadie", LastName = "McMeekin", ContactId = 108, BirthDate = new DateTime(2010, 1, 2) },
                  new DataClasses.Player { Id = 28, FirstName = "Isla", LastName = "Heckman", ContactId = 86, BirthDate = new DateTime(2009, 3, 10) },
                  new DataClasses.Player { Id = 29, FirstName = "Connor", LastName = "Rutz", ContactId = 122, BirthDate = new DateTime(2009, 7, 27) },
                  new DataClasses.Player { Id = 30, FirstName = "Khalil", LastName = "Jackson", ContactId = 81, BirthDate = new DateTime(2009, 8, 12) },
                  new DataClasses.Player { Id = 31, FirstName = "Channing", LastName = "Coon", ContactId = 41, BirthDate = new DateTime(2010, 4, 12) },
                  new DataClasses.Player { Id = 32, FirstName = "Sincere", LastName = "Ewell", ContactId = 127, BirthDate = new DateTime(2010, 2, 5) },
                  new DataClasses.Player { Id = 33, FirstName = "Grant", LastName = "Vitek", ContactId = 101, BirthDate = new DateTime(2010, 3, 16) },
                  new DataClasses.Player { Id = 34, FirstName = "Adelyn", LastName = "Pagze", IsActive = false, ContactId = 44, BirthDate = new DateTime(2012, 3, 22) },
                  new DataClasses.Player { Id = 35, FirstName = "Sinclair", LastName = "Ewell", ContactId = 127, BirthDate = new DateTime(2009, 2, 4) },
                  new DataClasses.Player { Id = 36, FirstName = "Nasir", LastName = "Saric", ContactId = 35, BirthDate = new DateTime(2010, 4, 10) },
                  new DataClasses.Player { Id = 37, FirstName = "Lukas", LastName = "Wright", ContactId = 93, BirthDate = new DateTime(2010, 12, 15) },
                  new DataClasses.Player { Id = 38, FirstName = "Roma", LastName = "Dizon", ContactId = 121, BirthDate = new DateTime(2008, 10, 4) },
                  new DataClasses.Player { Id = 39, FirstName = "Jasper", LastName = "Brinkley", ContactId = 102, BirthDate = new DateTime(2009, 3, 5) },
                  new DataClasses.Player { Id = 40, FirstName = "Isaac", LastName = "Kimmel", ContactId = 52, BirthDate = null },
                  new DataClasses.Player { Id = 41, FirstName = "Rylee", LastName = "Blair", IsActive = false, ContactId = 29, BirthDate = new DateTime(2010, 10, 14) },
                  new DataClasses.Player { Id = 42, FirstName = "Caleb", LastName = "Pagze", IsActive = false, ContactId = 44, BirthDate = new DateTime(2010, 12, 18) },
                  new DataClasses.Player { Id = 43, FirstName = "Kenyon", LastName = "Wideny", ContactId = 94, BirthDate = new DateTime(2011, 5, 12) },
                  new DataClasses.Player { Id = 44, FirstName = "JJ", LastName = "Fenner", ContactId = 72, BirthDate = null },
                  new DataClasses.Player { Id = 45, FirstName = "Kenzo", LastName = "Veron", ContactId = 121, BirthDate = new DateTime(2008, 10, 4) },
                  new DataClasses.Player { Id = 46, FirstName = "Millio", LastName = "Millz", ContactId = 111, BirthDate = new DateTime(2008, 10, 20) },
                  new DataClasses.Player { Id = 47, FirstName = "Preston", LastName = "Stackfield", ContactId = 117, BirthDate = null },
                  new DataClasses.Player { Id = 48, FirstName = "Quentin", LastName = "Stackfield", ContactId = 117, BirthDate = new DateTime(2009, 6, 30) },
                  new DataClasses.Player { Id = 49, FirstName = "Zion", LastName = "Thomas", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 50, FirstName = "Jenavive", LastName = "Thomas", IsActive = false, ContactId = 84, BirthDate = new DateTime(2009, 6, 11) },
                  new DataClasses.Player { Id = 51, FirstName = "Taliyah", LastName = "Robinson", IsActive = false, ContactId = 31, BirthDate = new DateTime(2008, 10, 16) },
                  new DataClasses.Player { Id = 52, FirstName = "Isaiah", LastName = "Robinson", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 53, FirstName = "Avah", LastName = "Thorson", ContactId = 131, BirthDate = new DateTime(2011, 1, 16) },
                  new DataClasses.Player { Id = 54, FirstName = "Jacob", LastName = "Weidner", IsActive = false, ContactId = 114, BirthDate = new DateTime(2009, 12, 18) },
                  new DataClasses.Player { Id = 55, FirstName = "Malachai", LastName = "Weidner", IsActive = false, ContactId = 114, BirthDate = new DateTime(2009, 12, 18) },
                  new DataClasses.Player { Id = 56, FirstName = "Luke", LastName = "Fischer", ContactId = 75, BirthDate = new DateTime(2006, 7, 17) },
                  new DataClasses.Player { Id = 57, FirstName = "Xavier", LastName = "Campbell", ContactId = 48, BirthDate = new DateTime(2006, 10, 23) },
                  new DataClasses.Player { Id = 58, FirstName = "Kolbin", LastName = "Heberling", ContactId = 70, BirthDate = new DateTime(2007, 9, 16) },
                  new DataClasses.Player { Id = 59, FirstName = "Tayshaun", LastName = "Dave", ContactId = 87, BirthDate = new DateTime(2008, 11, 7) },
                  new DataClasses.Player { Id = 60, FirstName = "Connor", LastName = "Baldwin", ContactId = 60, BirthDate = new DateTime(2007, 11, 19) },
                  new DataClasses.Player { Id = 61, FirstName = "Sidney", LastName = "Ewell", ContactId = 127, BirthDate = new DateTime(2008, 2, 21) },
                  new DataClasses.Player { Id = 62, FirstName = "Aiden", LastName = "Dobyns", ContactId = 68, BirthDate = new DateTime(2007, 10, 9) },
                  new DataClasses.Player { Id = 63, FirstName = "Gennaro", LastName = "Pensa", ContactId = 103, BirthDate = new DateTime(2006, 8, 7) },
                  new DataClasses.Player { Id = 64, FirstName = "Dominic", LastName = "Johnson", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 65, FirstName = "Austin", LastName = "Reichard", ContactId = 107, BirthDate = new DateTime(2007, 6, 30) },
                  new DataClasses.Player { Id = 66, FirstName = "Z\'varione", LastName = "Clarke", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 67, FirstName = "Ashton", LastName = "Coon", ContactId = 41, BirthDate = new DateTime(2008, 4, 18) },
                  new DataClasses.Player { Id = 68, FirstName = "Jadon", LastName = "Harris", ContactId = 45, BirthDate = new DateTime(2008, 1, 11) },
                  new DataClasses.Player { Id = 69, FirstName = "Trent", LastName = "Keeler", ContactId = 64, BirthDate = new DateTime(2007, 5, 19) },
                  new DataClasses.Player { Id = 70, FirstName = "Josh", LastName = "Kendall", ContactId = 28, BirthDate = new DateTime(2006, 10, 20) },
                  new DataClasses.Player { Id = 71, FirstName = "Jahmiel", LastName = "Harrel", ContactId = 97, BirthDate = new DateTime(2007, 11, 16) },
                  new DataClasses.Player { Id = 72, FirstName = "Kazmeer", LastName = "Jaquez", ContactId = 50, BirthDate = new DateTime(2007, 8, 12) },
                  new DataClasses.Player { Id = 73, FirstName = "Danielle", LastName = "Klinger", ContactId = 95, BirthDate = new DateTime(2006, 11, 26) },
                  new DataClasses.Player { Id = 74, FirstName = "Jasmine", LastName = "Rouvre", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 75, FirstName = "Jaquez", LastName = "Knight", Nickname = "JD", ContactId = 104, BirthDate = new DateTime(2007, 10, 29) },
                  new DataClasses.Player { Id = 76, FirstName = "Cayson", LastName = "Johnson", ContactId = 61, BirthDate = new DateTime(2008, 10, 1) },
                  new DataClasses.Player { Id = 77, FirstName = "Julian", LastName = "Miller", ContactId = 59, BirthDate = new DateTime(2008, 2, 9) },
                  new DataClasses.Player { Id = 78, FirstName = "Angelo", LastName = "Bartoli", ContactId = 82, BirthDate = new DateTime(2007, 7, 10) },
                  new DataClasses.Player { Id = 79, FirstName = "Malachai", LastName = "Thomas", ContactId = 118, BirthDate = new DateTime(2008, 5, 10) },
                  new DataClasses.Player { Id = 80, FirstName = "DJ", LastName = "Thomas", ContactId = 85, BirthDate = new DateTime(2007, 5, 20) },
                  new DataClasses.Player { Id = 81, FirstName = "Alaina", LastName = "Sweet", IsActive = false, ContactId = 37, BirthDate = new DateTime(2007, 12, 27) },
                  new DataClasses.Player { Id = 82, FirstName = "C\'myirh", LastName = "Thomas-Hodge", ContactId = 57, BirthDate = new DateTime(2008, 1, 16) },
                  new DataClasses.Player { Id = 83, FirstName = "Alex", LastName = "Pida", ContactId = 32, BirthDate = new DateTime(2006, 10, 17) },
                  new DataClasses.Player { Id = 84, FirstName = "Erik", LastName = "Samuelson", ContactId = 134, BirthDate = new DateTime(2007, 7, 14) },
                  new DataClasses.Player { Id = 85, FirstName = "Tavien", LastName = "Pham", ContactId = 125, BirthDate = new DateTime(2007, 1, 31) },
                  new DataClasses.Player { Id = 86, FirstName = "Andrew", LastName = "Bartoli", ContactId = 82, BirthDate = new DateTime(2007, 7, 10) },
                  new DataClasses.Player { Id = 87, FirstName = "Vincent", LastName = "Kunza", ContactId = 113, BirthDate = new DateTime(2007, 11, 21) },
                  new DataClasses.Player { Id = 88, FirstName = "Braylon", LastName = "Shugart", ContactId = 43, BirthDate = new DateTime(2008, 4, 8) },
                  new DataClasses.Player { Id = 89, FirstName = "Tahjmere", LastName = "Williams", IsActive = false, ContactId = 77, BirthDate = null },
                  new DataClasses.Player { Id = 90, FirstName = "Henry", LastName = "Boegel", ContactId = 46, BirthDate = new DateTime(2008, 3, 25) },
                  new DataClasses.Player { Id = 91, FirstName = "Jordan", LastName = "McGowan", ContactId = 27, BirthDate = null },
                  new DataClasses.Player { Id = 92, FirstName = "Kamora", LastName = "Johnson", ContactId = 88, BirthDate = new DateTime(2008, 1, 2) },
                  new DataClasses.Player { Id = 93, FirstName = "Nolan", LastName = "Snyder", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 94, FirstName = "Masyn", LastName = "McMeekin", ContactId = 108, BirthDate = new DateTime(2008, 1, 1) },
                  new DataClasses.Player { Id = 95, FirstName = "Spencer", LastName = "Griffie", ContactId = 110, BirthDate = new DateTime(2006, 10, 20) },
                  new DataClasses.Player { Id = 96, FirstName = "Conway", LastName = "Brown II", ContactId = 55, BirthDate = new DateTime(2007, 8, 23) },
                  new DataClasses.Player { Id = 97, FirstName = "Lucas", LastName = "Ream", ContactId = 130, BirthDate = new DateTime(2007, 3, 13) },
                  new DataClasses.Player { Id = 98, FirstName = "Branden", LastName = "Felton", ContactId = 83, BirthDate = new DateTime(2007, 12, 10) },
                  new DataClasses.Player { Id = 99, FirstName = "Damion", LastName = "Jones", Nickname = "Jace", ContactId = 99, BirthDate = new DateTime(2009, 2, 23) },
                  new DataClasses.Player { Id = 100, FirstName = "Skyla", LastName = "Hancock", ContactId = 47, BirthDate = new DateTime(2006, 12, 14) },
                  new DataClasses.Player { Id = 101, FirstName = "Jacob", LastName = "Goldsborough", ContactId = 119, BirthDate = new DateTime(2007, 7, 7) },
                  new DataClasses.Player { Id = 102, FirstName = "Ethan", LastName = "Yentzer", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 103, FirstName = "Geo", LastName = "Villanueva", ContactId = 66, BirthDate = new DateTime(2006, 4, 26) },
                  new DataClasses.Player { Id = 104, FirstName = "Joeseph", LastName = "Rosado", Nickname = "JoJo", ContactId = 89, BirthDate = new DateTime(2005, 1, 12) },
                  new DataClasses.Player { Id = 105, FirstName = "Tyreke", LastName = "Flowers", ContactId = 36, BirthDate = new DateTime(2004, 10, 30) },
                  new DataClasses.Player { Id = 106, FirstName = "Jaden", LastName = "Pham", ContactId = 125, BirthDate = new DateTime(2004, 9, 4) },
                  new DataClasses.Player { Id = 107, FirstName = "Avery", LastName = "Stanback", ContactId = 124, BirthDate = new DateTime(2006, 5, 17) },
                  new DataClasses.Player { Id = 108, FirstName = "Damon", LastName = "Thomas", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 109, FirstName = "Nasir", LastName = "Palmer", ContactId = 135, BirthDate = new DateTime(2006, 3, 24) },
                  new DataClasses.Player { Id = 110, FirstName = "Brayden", LastName = "Lindsey", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 111, FirstName = "Julian", LastName = "Christopher", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 112, FirstName = "Devon", LastName = "Montgomery", ContactId = 58, BirthDate = new DateTime(2005, 10, 26) },
                  new DataClasses.Player { Id = 113, FirstName = "Jeremiah", LastName = "Snyder", ContactId = null, BirthDate = new DateTime(2004, 9, 7) },
                  new DataClasses.Player { Id = 114, FirstName = "Jaqueece", LastName = "Morrell", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 115, FirstName = "Bryson", LastName = "Williams", ContactId = 38, BirthDate = null },
                  new DataClasses.Player { Id = 116, FirstName = "Jaiden", LastName = "Bass", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 117, FirstName = "Javoni", LastName = "Mosesly", ContactId = 39, BirthDate = new DateTime(2005, 11, 18) },
                  new DataClasses.Player { Id = 118, FirstName = "Dewitt", LastName = "Smith", IsActive = false, ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 119, FirstName = "Jeremih", LastName = "Sothers", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 120, FirstName = "Kareem", LastName = "Lawson", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 121, FirstName = "Quamari", LastName = "Vasser", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 122, FirstName = "Jaydon", LastName = "Smith", ContactId = 100, BirthDate = new DateTime(2006, 4, 14) },
                  new DataClasses.Player { Id = 123, FirstName = "Tionne", LastName = "Johnson", ContactId = 88, BirthDate = new DateTime(2005, 7, 24) },
                  new DataClasses.Player { Id = 124, FirstName = "Marquise", LastName = "Miller", ContactId = 128, BirthDate = new DateTime(2004, 12, 21) },
                  new DataClasses.Player { Id = 125, FirstName = "Anthony", LastName = "Bartoli", ContactId = 82, BirthDate = new DateTime(2005, 4, 8) },
                  new DataClasses.Player { Id = 126, FirstName = "Maxwell", LastName = "Spraglin", ContactId = null, BirthDate = new DateTime(2006, 1, 26) },
                  new DataClasses.Player { Id = 127, FirstName = "Khaleed", LastName = "Washington", ContactId = 111, BirthDate = new DateTime(2006, 5, 18) },
                  new DataClasses.Player { Id = 128, FirstName = "Jayden", LastName = "Wright", ContactId = 66, BirthDate = new DateTime(2006, 4, 11) },
                  new DataClasses.Player { Id = 129, FirstName = "Jess", LastName = "Rourve", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 130, FirstName = "Damion", LastName = "Scott", ContactId = 115, BirthDate = new DateTime(2004, 11, 5) },
                  new DataClasses.Player { Id = 131, FirstName = "Eli", LastName = "Kimmel", ContactId = 52, BirthDate = new DateTime(2006, 6, 14) },
                  new DataClasses.Player { Id = 132, FirstName = "Jacob", LastName = "Heckman", ContactId = 86, BirthDate = new DateTime(2005, 12, 27) },
                  new DataClasses.Player { Id = 133, FirstName = "Silah", LastName = "Niertako", IsActive = false, ContactId = 79, BirthDate = new DateTime(2006, 2, 15) },
                  new DataClasses.Player { Id = 134, FirstName = "Mekhar", LastName = "McBride", Nickname = "Miki", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 135, FirstName = "Ian", LastName = "Messano", ContactId = 105, BirthDate = new DateTime(2005, 3, 10) },
                  new DataClasses.Player { Id = 136, FirstName = "Dominic", LastName = "Roman", ContactId = 74, BirthDate = new DateTime(2006, 6, 2) },
                  new DataClasses.Player { Id = 137, FirstName = "Parker", LastName = "Smith", IsActive = false, ContactId = 73, BirthDate = new DateTime(2003, 7, 25) },
                  new DataClasses.Player { Id = 138, FirstName = "Jeremiah", LastName = "Seller", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 139, FirstName = "Ezeekai", LastName = "Thomas", Nickname = "EZ", ContactId = 69, BirthDate = new DateTime(2005, 3, 23) },
                  new DataClasses.Player { Id = 140, FirstName = "Luke", LastName = "August", ContactId = 40, BirthDate = new DateTime(2005, 1, 15) },
                  new DataClasses.Player { Id = 141, FirstName = "Louie", LastName = "Shank", ContactId = 126, BirthDate = new DateTime(2005, 5, 17) },
                  new DataClasses.Player { Id = 142, FirstName = "Eli", LastName = "Hargrove", ContactId = 51, BirthDate = null },
                  new DataClasses.Player { Id = 143, FirstName = "Hunter", LastName = "Finkenbinder", ContactId = 90, BirthDate = new DateTime(2005, 3, 18) },
                  new DataClasses.Player { Id = 144, FirstName = "Jeremiah", LastName = "Hargrove", ContactId = 51, BirthDate = new DateTime(2006, 2, 16) },
                  new DataClasses.Player { Id = 145, FirstName = "Jose", LastName = "Oaks", ContactId = 123, BirthDate = new DateTime(2005, 2, 22) },
                  new DataClasses.Player { Id = 146, FirstName = "Justus", LastName = "Johnson", ContactId = 49, BirthDate = new DateTime(2005, 8, 2) },
                  new DataClasses.Player { Id = 147, FirstName = "Jake", LastName = "Panko", ContactId = 91, BirthDate = new DateTime(2004, 12, 21) },
                  new DataClasses.Player { Id = 148, FirstName = "Jasier", LastName = "Brinkley", ContactId = null, BirthDate = null }, // C-Luv
                  new DataClasses.Player { Id = 149, FirstName = "Dominic", LastName = "Bowman", ContactId = 53, BirthDate = new DateTime(2010, 6, 17) }, // GBS
                  new DataClasses.Player { Id = 150, FirstName = "Lesean", LastName = "Scott", ContactId = 33, BirthDate = new DateTime(2010, 11, 8) }, // PBH
                  new DataClasses.Player { Id = 151, FirstName = "Khamdyn", LastName = "Drew", ContactId = null, BirthDate = null }, // CCC
                  new DataClasses.Player { Id = 152, FirstName = "Zach", LastName = "Goldsborough", ContactId = 119, BirthDate = null }, // CCC
                  new DataClasses.Player { Id = 153, FirstName = "Brayon", LastName = "Hunter", ContactId = null, BirthDate = null }, // CCC
                  new DataClasses.Player { Id = 154, FirstName = "Angelique", LastName = "Noia", ContactId = null, BirthDate = null }, // CVR
                  new DataClasses.Player { Id = 155, FirstName = "Dennis", LastName = "Jones", ContactId = 67, BirthDate = new DateTime(2006, 8, 27) }, // CVR
                  new DataClasses.Player { Id = 156, FirstName = "Lucas", LastName = "Smith", ContactId = null, BirthDate = null }, // GBS
                  new DataClasses.Player { Id = 157, FirstName = "Joaquin", LastName = "Ortiz", ContactId = null, BirthDate = null }, // PBH
                  new DataClasses.Player { Id = 158, FirstName = "Landon", LastName = "Lackemeyer", ContactId = null, BirthDate = null }, // C-Luv
                  new DataClasses.Player { Id = 159, FirstName = "Anthony", LastName = "Smith", ContactId = null, BirthDate = null }, // C-Luv
                  new DataClasses.Player { Id = 160, FirstName = "Adrian", LastName = "Bennett", Nickname = "Khi", IsActive = false, ContactId = null, BirthDate = null }, // CVR
                  new DataClasses.Player { Id = 161, FirstName = "Brian", LastName = "Szeles", ContactId = 74, BirthDate = new DateTime(2004, 8, 26) }, // CVR
                  new DataClasses.Player { Id = 162, FirstName = "Nadia", LastName = "Hunter", ContactId = null, BirthDate = null }, // 12U - CVR
                  new DataClasses.Player { Id = 163, FirstName = "Jace", LastName = "Jones", IsActive = false, ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 164, FirstName = "Mason", LastName = "Shaw", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 165, FirstName = "Savion", LastName = "Brown", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 166, FirstName = "Davione", LastName = "Alejandro", ContactId = 42, BirthDate = null },
                  new DataClasses.Player { Id = 167, FirstName = "Javione", LastName = "Alejandro", ContactId = 42, BirthDate = null },
                  new DataClasses.Player { Id = 168, FirstName = "Rashard", LastName = "Scott", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 169, FirstName = "Tyrone", LastName = "Moore", IsActive = false, ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 170, FirstName = "Zar\'Manei", LastName = "Coble", ContactId = null, BirthDate = null },
                  new DataClasses.Player { Id = 171, FirstName = "Four", LastName = "Petre", ContactId = null, BirthDate = null }
                );
            });

            modelBuilder.Entity<PlayerLeagueSeasonXref>(entity =>
            {
                entity.ToTable("PlayerLeagueSeason_xref", "Common");

                entity.Property(e => e.JerseyNumberChoice1).HasMaxLength(10);
                entity.Property(e => e.JerseyNumberChoice2).HasMaxLength(10);
                entity.Property(e => e.JerseyNumberChoice3).HasMaxLength(10);

                entity.HasOne(d => d.JerseySize)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.JerseySizeId)
                    .HasConstraintName("FK_PlayerLeagueSeason_JerseySize");

                entity.HasOne(d => d.LeagueSeason)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.LeagueSeasonId)
                    .HasConstraintName("FK_PlayerLeagueSeason_LeagueSeason");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_PlayerLeagueSeason_Player");

                entity.HasData(
                    new DataClasses.PlayerLeagueSeasonXref { Id = 1, PlayerId = 1, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 2, PlayerId = 2, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 3, PlayerId = 3, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 4, PlayerId = 4, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 5, PlayerId = 5, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 6, PlayerId = 6, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 7, PlayerId = 7, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 8, PlayerId = 8, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 9, PlayerId = 9, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 10, PlayerId = 10, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 11, PlayerId = 11, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 12, PlayerId = 12, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 13, PlayerId = 13, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 14, PlayerId = 14, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 15, PlayerId = 15, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 16, PlayerId = 16, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 17, PlayerId = 17, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 18, PlayerId = 18, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 19, PlayerId = 19, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 20, PlayerId = 20, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 21, PlayerId = 21, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 22, PlayerId = 22, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 23, PlayerId = 23, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 24, PlayerId = 24, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 25, PlayerId = 25, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 26, PlayerId = 26, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 27, PlayerId = 27, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 28, PlayerId = 28, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 29, PlayerId = 29, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 30, PlayerId = 30, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 31, PlayerId = 31, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 32, PlayerId = 32, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 33, PlayerId = 33, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 34, PlayerId = 34, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 35, PlayerId = 35, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 36, PlayerId = 36, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 37, PlayerId = 37, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 38, PlayerId = 38, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 39, PlayerId = 39, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 40, PlayerId = 40, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 41, PlayerId = 41, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 42, PlayerId = 42, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 43, PlayerId = 43, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 44, PlayerId = 44, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 45, PlayerId = 45, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 46, PlayerId = 46, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 47, PlayerId = 47, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 48, PlayerId = 48, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 49, PlayerId = 49, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 50, PlayerId = 50, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 51, PlayerId = 51, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 52, PlayerId = 52, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 53, PlayerId = 53, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 54, PlayerId = 54, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 55, PlayerId = 55, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 56, PlayerId = 56, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 57, PlayerId = 57, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 58, PlayerId = 58, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 59, PlayerId = 59, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 60, PlayerId = 60, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 61, PlayerId = 61, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 62, PlayerId = 62, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 63, PlayerId = 63, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 64, PlayerId = 64, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 65, PlayerId = 65, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 66, PlayerId = 66, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 67, PlayerId = 67, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 68, PlayerId = 68, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 69, PlayerId = 69, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 70, PlayerId = 70, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 71, PlayerId = 71, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 72, PlayerId = 72, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 73, PlayerId = 73, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 74, PlayerId = 74, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 75, PlayerId = 75, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 76, PlayerId = 76, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 77, PlayerId = 77, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 78, PlayerId = 78, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 79, PlayerId = 79, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 80, PlayerId = 80, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 81, PlayerId = 81, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 82, PlayerId = 82, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 83, PlayerId = 83, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 84, PlayerId = 84, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 85, PlayerId = 85, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 86, PlayerId = 86, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 87, PlayerId = 87, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 88, PlayerId = 88, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 89, PlayerId = 89, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 90, PlayerId = 90, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 91, PlayerId = 91, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 92, PlayerId = 92, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 93, PlayerId = 93, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 94, PlayerId = 94, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 95, PlayerId = 95, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 96, PlayerId = 96, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 97, PlayerId = 97, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 98, PlayerId = 98, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 99, PlayerId = 99, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 100, PlayerId = 100, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 101, PlayerId = 101, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 102, PlayerId = 102, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 103, PlayerId = 103, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 104, PlayerId = 104, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 105, PlayerId = 105, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 106, PlayerId = 106, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 107, PlayerId = 107, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 108, PlayerId = 108, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 109, PlayerId = 109, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 110, PlayerId = 110, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 111, PlayerId = 111, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 112, PlayerId = 112, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 113, PlayerId = 113, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 114, PlayerId = 114, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 115, PlayerId = 115, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 116, PlayerId = 116, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 117, PlayerId = 117, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 118, PlayerId = 118, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 119, PlayerId = 119, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 120, PlayerId = 120, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 121, PlayerId = 121, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 122, PlayerId = 122, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 123, PlayerId = 123, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 124, PlayerId = 124, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 125, PlayerId = 125, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 126, PlayerId = 126, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 127, PlayerId = 127, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 128, PlayerId = 128, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 129, PlayerId = 129, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 130, PlayerId = 130, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 131, PlayerId = 131, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 132, PlayerId = 132, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 133, PlayerId = 133, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 134, PlayerId = 134, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 135, PlayerId = 135, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 136, PlayerId = 136, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 137, PlayerId = 137, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 138, PlayerId = 138, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 139, PlayerId = 139, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 140, PlayerId = 140, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 141, PlayerId = 141, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 142, PlayerId = 142, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 143, PlayerId = 143, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 144, PlayerId = 144, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 145, PlayerId = 145, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 146, PlayerId = 146, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 147, PlayerId = 147, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 148, PlayerId = 148, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 149, PlayerId = 149, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 150, PlayerId = 150, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 151, PlayerId = 151, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 152, PlayerId = 152, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 153, PlayerId = 153, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 154, PlayerId = 154, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 155, PlayerId = 155, LeagueSeasonId = 2 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 156, PlayerId = 156, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 157, PlayerId = 157, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 158, PlayerId = 158, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 159, PlayerId = 159, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 160, PlayerId = 160, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 161, PlayerId = 161, LeagueSeasonId = 3 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 162, PlayerId = 162, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 163, PlayerId = 163, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 164, PlayerId = 164, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 165, PlayerId = 165, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 166, PlayerId = 166, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 167, PlayerId = 167, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 168, PlayerId = 168, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 169, PlayerId = 169, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 170, PlayerId = 170, LeagueSeasonId = 1 },
                    new DataClasses.PlayerLeagueSeasonXref { Id = 171, PlayerId = 171, LeagueSeasonId = 3 }
                );
            });

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.ToTable("Sponsor", "Common");

                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.HasData(
                  new DataClasses.Sponsor
                  {
                      Id = 1,
                      Name = "Carlisle Community Coalition",
                      Initials = "CCC"
                  },
                  new DataClasses.Sponsor
                  {
                      Id = 2,
                      Name = "C-Luv Thrift",
                      Initials = "C-Luv"
                  },
                  new DataClasses.Sponsor
                  {
                      Id = 3,
                      Name = "GB Stuart",
                      Initials = "GBS"
                  },
                  new DataClasses.Sponsor
                  {
                      Id = 4,
                      Name = "Carlisle Home Association",
                      Initials = "CHA"
                  },
                  new DataClasses.Sponsor
                  {
                      Id = 5,
                      Name = "Cumberland Valley Rising",
                      Initials = "CVR"
                  },
                  new DataClasses.Sponsor
                  {
                      Id = 6,
                      Name = "Partnership for Better Health",
                      Initials = "PBH"
                  }
                );
            });

            modelBuilder.Entity<SponsorSeasonXref>(entity =>
            {
                entity.ToTable("SponsorSeason_xref", "Common");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Sponsors)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_SponsorSeason_Season");

                entity.HasOne(d => d.Sponsor)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.SponsorId)
                    .HasConstraintName("FK_SponsorSeason_Sponsor");

                entity.HasOne(d => d.SponsorshipLevel)
                    .WithMany(p => p.SponsorSeasons)
                    .HasForeignKey(d => d.SponsorshipLevelId)
                    .HasConstraintName("FK_SponsorSeason_SponsorshipLevel");

                entity.HasData(
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 1,
                      SponsorId = 1,
                      SeasonId = 1
                  },
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 2,
                      SponsorId = 2,
                      SeasonId = 1
                  },
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 3,
                      SponsorId = 3,
                      SeasonId = 1
                  },
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 4,
                      SponsorId = 4,
                      SeasonId = 1
                  },
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 5,
                      SponsorId = 5,
                      SeasonId = 1
                  },
                  new DataClasses.SponsorSeasonXref
                  {
                      Id = 6,
                      SponsorId = 6,
                      SeasonId = 1
                  }
                );
            });

            modelBuilder.Entity<Stat>(entity =>
            {
                entity.ToTable("Stat", "Common");

                entity.HasOne(d => d.GamePlayer)
                    .WithMany(p => p.Stats)
                    .HasForeignKey(d => d.GamePlayerId)
                    .HasConstraintName("FK_Stat_xref_GamePlayer");

                entity.HasOne(d => d.StatCategory)
                    .WithMany(p => p.Stats)
                    .HasForeignKey(d => d.StatCategoryId)
                    .HasConstraintName("FK_Stat_xref_StatCategory");


            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team", "Common");

                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.HasData(
                    new DataClasses.Team
                    {
                        Id = 1,
                        Name = "C-Luv Thrift",
                        Initials = "C-Luv"
                    },
                  new DataClasses.Team
                  {
                      Id = 2,
                      Name = "GB Stuart",
                      Initials = "GBS"
                  },
                  new DataClasses.Team
                  {
                      Id = 3,
                      Name = "Carlisle Home Association",
                      Initials = "CHA"
                  },
                  new DataClasses.Team
                  {
                      Id = 4,
                      Name = "Cumberland Valley Rising",
                      Initials = "CVR"
                  },
                  new DataClasses.Team
                  {
                      Id = 5,
                      Name = "Partnership for Better Health",
                      Initials = "PBH"
                  },
                  new DataClasses.Team
                  {
                      Id = 6,
                      Name = "Carlisle Community Coalition",
                      Initials = "CCC"
                  },
                  new DataClasses.Team
                  {
                      Id = 7,
                      Name = "C-Luv Thrift",
                      Initials = "C-Luv"
                  },
                  new DataClasses.Team
                  {
                      Id = 8,
                      Name = "GB Stuart Foundation",
                      Initials = "GBS"
                  },
                  new DataClasses.Team
                  {
                      Id = 9,
                      Name = "Carlisle Home Association",
                      Initials = "CHA"
                  },
                  new DataClasses.Team
                  {
                      Id = 10,
                      Name = "Cumberland Valley Rising",
                      Initials = "CVR"
                  },
                  new DataClasses.Team
                  {
                      Id = 11,
                      Name = "Partnership for Better Health",
                      Initials = "PBH"
                  },
                  new DataClasses.Team
                  {
                      Id = 12,
                      Name = "C-Luv Thrift",
                      Initials = "C-Luv"
                  },
                  new DataClasses.Team
                  {
                      Id = 13,
                      Name = "GB Stuart Foundation",
                      Initials = "GBS"
                  },
                  new DataClasses.Team
                  {
                      Id = 14,
                      Name = "Carlisle Home Association",
                      Initials = "CHA"
                  },
                  new DataClasses.Team
                  {
                      Id = 15,
                      Name = "Cumberland Valley Rising",
                      Initials = "CVR"
                  },
                  new DataClasses.Team
                  {
                      Id = 16,
                      Name = "Partnership for Better Health",
                      Initials = "PBH"
                  }
                );
            });

            modelBuilder.Entity<TeamLeagueSeasonXref>(entity =>
            {
                entity.ToTable("TeamLeagueSeason_xref", "Common");

                entity.HasOne(d => d.Coach)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.CoachId)
                    .HasConstraintName("FK_TeamLeagueSeason_Coach");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_TeamLeagueSeason_Color");

                entity.HasOne(d => d.LeagueSeason)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeagueSeasonId)
                    .HasConstraintName("FK_TeamLeagueSeason_LeagueSeason");

                entity.HasOne(d => d.SponsorSeason)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.SponsorSeasonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TeamLeagueSeason_SponsorSeason");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_TeamLeagueSeason_Team");

                entity.HasData(
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 1,
                        TeamId = 1,
                        LeagueSeasonId = 1,
                        CoachId = 1,
                        ColorId = 1,
                        SponsorSeasonId = 2
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 2,
                        TeamId = 2,
                        LeagueSeasonId = 1,
                        CoachId = 2,
                        ColorId = 2,
                        SponsorSeasonId = 3
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 3,
                        TeamId = 3,
                        LeagueSeasonId = 1,
                        CoachId = 3,
                        ColorId = 3,
                        SponsorSeasonId = 4
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 4,
                        TeamId = 4,
                        LeagueSeasonId = 1,
                        CoachId = 4,
                        ColorId = 4,
                        SponsorSeasonId = 5
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 5,
                        TeamId = 5,
                        LeagueSeasonId = 1,
                        CoachId = 5,
                        ColorId = 5,
                        SponsorSeasonId = 6
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 6,
                        TeamId = 6,
                        LeagueSeasonId = 1,
                        CoachId = 6,
                        ColorId = 6,
                        SponsorSeasonId = 1
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 7,
                        TeamId = 7,
                        LeagueSeasonId = 2,
                        CoachId = 7,
                        ColorId = 1,
                        SponsorSeasonId = 2
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 8,
                        TeamId = 8,
                        LeagueSeasonId = 2,
                        CoachId = 8,
                        ColorId = 2,
                        SponsorSeasonId = 3
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 9,
                        TeamId = 9,
                        LeagueSeasonId = 2,
                        CoachId = 9,
                        ColorId = 3,
                        SponsorSeasonId = 4
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 10,
                        TeamId = 10,
                        LeagueSeasonId = 2,
                        CoachId = 10,
                        ColorId = 4,
                        SponsorSeasonId = 5
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 11,
                        TeamId = 11,
                        LeagueSeasonId = 2,
                        CoachId = 11,
                        ColorId = 5,
                        SponsorSeasonId = 6
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 12,
                        TeamId = 12,
                        LeagueSeasonId = 3,
                        CoachId = 12,
                        ColorId = 1,
                        SponsorSeasonId = 2
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 13,
                        TeamId = 13,
                        LeagueSeasonId = 3,
                        CoachId = 13,
                        ColorId = 2,
                        SponsorSeasonId = 3
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 14,
                        TeamId = 14,
                        LeagueSeasonId = 3,
                        CoachId = 14,
                        ColorId = 3,
                        SponsorSeasonId = 4
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 15,
                        TeamId = 15,
                        LeagueSeasonId = 3,
                        CoachId = 15,
                        ColorId = 4,
                        SponsorSeasonId = 5
                    },
                    new DataClasses.TeamLeagueSeasonXref
                    {
                        Id = 16,
                        TeamId = 16,
                        LeagueSeasonId = 3,
                        CoachId = 16,
                        ColorId = 5,
                        SponsorSeasonId = 6
                    }
                );
            });

            modelBuilder.Entity<TeamStat>(entity =>
            {
                entity.ToTable("TeamStat", "Common");

                entity.HasOne(d => d.GameTeam)
                    .WithMany(p => p.TeamStats)
                    .HasForeignKey(d => d.GameTeamId)
                    .HasConstraintName("FK_TeamStat_xref_GameTeam");

                entity.HasOne(d => d.StatCategory)
                    .WithMany(p => p.TeamStats)
                    .HasForeignKey(d => d.StatCategoryId)
                    .HasConstraintName("FK_TeamStat_xref_StatCategory");


            });
        }
    }
}
