using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ccc.Entity.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    PasswordResetCode = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Draft",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DraftPick",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftPick", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Initials = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Initials = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameResultType",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameResultType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationType",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SeasonTypeId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SponsorshipLevel",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorshipLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatCategory",
                schema: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Label = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SportId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaim_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                schema: "Auth",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.ProviderKey, x.LoginProvider });
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "Auth",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                schema: "Auth",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.Value, x.LoginProvider });
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Nickname = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Contact",
                        column: x => x.ContactId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationType",
                        column: x => x.LocationTypeId,
                        principalSchema: "Lookup",
                        principalTable: "LocationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponsorSeason_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SponsorId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    SponsorshipLevelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorSeason_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SponsorSeason_Season",
                        column: x => x.SeasonId,
                        principalSchema: "Lookup",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorSeason_Sponsor",
                        column: x => x.SponsorId,
                        principalSchema: "Common",
                        principalTable: "Sponsor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponsorSeason_SponsorshipLevel",
                        column: x => x.SponsorshipLevelId,
                        principalSchema: "Lookup",
                        principalTable: "SponsorshipLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "League",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                    table.ForeignKey(
                        name: "FK_League_Sport_SportId",
                        column: x => x.SportId,
                        principalSchema: "Lookup",
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeagueSeason_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueSeason_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueSeason_League",
                        column: x => x.LeagueId,
                        principalSchema: "Common",
                        principalTable: "League",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeagueSeason_Season",
                        column: x => x.SeasonId,
                        principalSchema: "Lookup",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueSeasonId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_LeagueSeason",
                        column: x => x.LeagueSeasonId,
                        principalSchema: "Common",
                        principalTable: "LeagueSeason_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Location",
                        column: x => x.LocationId,
                        principalSchema: "Common",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerLeagueSeason_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(nullable: false),
                    LeagueSeasonId = table.Column<int>(nullable: false),
                    JerseySizeId = table.Column<int>(nullable: true),
                    JerseyNumberChoice1 = table.Column<string>(maxLength: 10, nullable: true),
                    JerseyNumberChoice2 = table.Column<string>(maxLength: 10, nullable: true),
                    JerseyNumberChoice3 = table.Column<string>(maxLength: 10, nullable: true),
                    SeasonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerLeagueSeason_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerLeagueSeason_JerseySize",
                        column: x => x.JerseySizeId,
                        principalSchema: "Lookup",
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerLeagueSeason_LeagueSeason",
                        column: x => x.LeagueSeasonId,
                        principalSchema: "Common",
                        principalTable: "LeagueSeason_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerLeagueSeason_Player",
                        column: x => x.PlayerId,
                        principalSchema: "Common",
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerLeagueSeason_xref_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "Lookup",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamLeagueSeason_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    LeagueSeasonId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    SponsorSeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamLeagueSeason_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamLeagueSeason_Coach",
                        column: x => x.CoachId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamLeagueSeason_Color",
                        column: x => x.ColorId,
                        principalSchema: "Lookup",
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamLeagueSeason_LeagueSeason",
                        column: x => x.LeagueSeasonId,
                        principalSchema: "Common",
                        principalTable: "LeagueSeason_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamLeagueSeason_SponsorSeason",
                        column: x => x.SponsorSeasonId,
                        principalSchema: "Common",
                        principalTable: "SponsorSeason_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamLeagueSeason_Team",
                        column: x => x.TeamId,
                        principalSchema: "Common",
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameTeam_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    GameResultTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTeam_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameTeam_xref_Game",
                        column: x => x.GameId,
                        principalSchema: "Common",
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameTeam_xref_GameResultType",
                        column: x => x.GameResultTypeId,
                        principalSchema: "Lookup",
                        principalTable: "GameResultType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameTeam_xref_Team",
                        column: x => x.TeamId,
                        principalSchema: "Common",
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayer_xref",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTeamId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    JerseyNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayer_xref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlayer_xref_GameTeam",
                        column: x => x.GameTeamId,
                        principalSchema: "Common",
                        principalTable: "GameTeam_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayer_xref_Player",
                        column: x => x.PlayerId,
                        principalSchema: "Common",
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamStat",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTeamId = table.Column<int>(nullable: false),
                    StatCategoryId = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamStat_xref_GameTeam",
                        column: x => x.GameTeamId,
                        principalSchema: "Common",
                        principalTable: "GameTeam_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamStat_xref_StatCategory",
                        column: x => x.StatCategoryId,
                        principalSchema: "Lookup",
                        principalTable: "StatCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamePlayerId = table.Column<int>(nullable: false),
                    StatCategoryId = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stat_xref_GamePlayer",
                        column: x => x.GamePlayerId,
                        principalSchema: "Common",
                        principalTable: "GamePlayer_xref",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stat_xref_StatCategory",
                        column: x => x.StatCategoryId,
                        principalSchema: "Lookup",
                        principalTable: "StatCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetCode", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "f605120f-716d-40c3-9dbd-8ff473410823", "gelbaughcm@gmail.com", false, "System", "Administrator", false, null, "gelbaughcm@gmail.com", "gelbaughcm@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "dfafd561-8cef-40ad-8c7a-339dc67529d0", false, "gelbaughcm@gmail.com" },
                    { 100, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "lee101686@hotmail.com", false, "", "", false, null, "lee101686@hotmail.com", "lee101686@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173864110", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "lee101686@hotmail.com" },
                    { 99, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "lbrown28511@yahoo.com", false, "", "", false, null, "lbrown28511@yahoo.com", "lbrown28511@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173860154", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "lbrown28511@yahoo.com" },
                    { 98, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "larc2411@gmail.com", false, "", "", false, null, "larc2411@gmail.com", "larc2411@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177064166", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "larc2411@gmail.com" },
                    { 97, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "krh5690@yahoo.com", false, "", "", false, null, "krh5690@yahoo.com", "krh5690@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176018134", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "krh5690@yahoo.com" },
                    { 96, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "koss@dickinson.edu", false, "", "", false, null, "koss@dickinson.edu", "koss@dickinson.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174976832", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "koss@dickinson.edu" },
                    { 95, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "klingkling2k3@hotmail.com", false, "", "", false, null, "klingkling2k3@hotmail.com", "klingkling2k3@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172756508", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "klingkling2k3@hotmail.com" },
                    { 94, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "klatrellc@gmail.com", false, "", "", false, null, "klatrellc@gmail.com", "klatrellc@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174226934", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "klatrellc@gmail.com" },
                    { 93, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "kerryannlane@yahoo.com", false, "", "", false, null, "kerryannlane@yahoo.com", "kerryannlane@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179799503", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "kerryannlane@yahoo.com" },
                    { 92, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "justus08jt@gmail.com", false, "", "", false, null, "justus08jt@gmail.com", "justus08jt@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "2232128188", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "justus08jt@gmail.com" },
                    { 91, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Juliepanko@gmail.com", false, "", "", false, null, "Juliepanko@gmail.com", "Juliepanko@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173855832", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Juliepanko@gmail.com" },
                    { 90, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jrae001@yahoo.com", false, "", "", false, null, "jrae001@yahoo.com", "jrae001@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172260115", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jrae001@yahoo.com" },
                    { 89, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "josephrosado2155@gmail.com", false, "", "", false, null, "josephrosado2155@gmail.com", "josephrosado2155@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "2675040429", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "josephrosado2155@gmail.com" },
                    { 88, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "johnsonkim5845@yahoo.com", false, "", "", false, null, "johnsonkim5845@yahoo.com", "johnsonkim5845@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174432868", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "johnsonkim5845@yahoo.com" },
                    { 87, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jkuntz2312@yahoo.com", false, "", "", false, null, "jkuntz2312@yahoo.com", "jkuntz2312@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179619214", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jkuntz2312@yahoo.com" },
                    { 101, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "leesavitek@hotmail.com", false, "", "", false, null, "leesavitek@hotmail.com", "leesavitek@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "4123989746", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "leesavitek@hotmail.com" },
                    { 86, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jkosco@aol.com", false, "", "", false, null, "jkosco@aol.com", "jkosco@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "4159391024", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jkosco@aol.com" },
                    { 84, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jaygirl515@yahoo.com", false, "", "", false, null, "jaygirl515@yahoo.com", "jaygirl515@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "2547024961", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jaygirl515@yahoo.com" },
                    { 83, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jamifelton83@gmail.com", false, "", "", false, null, "jamifelton83@gmail.com", "jamifelton83@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174628290", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jamifelton83@gmail.com" },
                    { 82, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jamiebartoli@comcast.net", false, "", "", false, null, "jamiebartoli@comcast.net", "jamiebartoli@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174330619", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jamiebartoli@comcast.net" },
                    { 81, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jacksonwalter32@gmail.com", false, "", "", false, null, "jacksonwalter32@gmail.com", "jacksonwalter32@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173866524", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jacksonwalter32@gmail.com" },
                    { 80, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "inmanjaleesa@gmail.com", false, "", "", false, null, "inmanjaleesa@gmail.com", "inmanjaleesa@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174629397", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "inmanjaleesa@gmail.com" },
                    { 79, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "hulaulani@gmail.com", false, "", "", false, null, "hulaulani@gmail.com", "hulaulani@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173867057", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "hulaulani@gmail.com" },
                    { 78, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Hshararz@gmail.com", false, "", "", false, null, "Hshararz@gmail.com", "Hshararz@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174221129", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Hshararz@gmail.com" },
                    { 77, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "handyc316@gmail.com", false, "", "", false, null, "handyc316@gmail.com", "handyc316@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "handyc316@gmail.com" },
                    { 76, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "getamysmith@gmail.com", false, "", "", false, null, "getamysmith@gmail.com", "getamysmith@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7175769400", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "getamysmith@gmail.com" },
                    { 75, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "fischert@dickinson.edu", false, "", "", false, null, "fischert@dickinson.edu", "fischert@dickinson.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176097801", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "fischert@dickinson.edu" },
                    { 74, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "erical10028@aol.com", false, "", "", false, null, "erical10028@aol.com", "erical10028@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7175035080", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "erical10028@aol.com" },
                    { 73, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "emilyduke2000@yahoo.com", false, "", "", false, null, "emilyduke2000@yahoo.com", "emilyduke2000@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174483126", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "emilyduke2000@yahoo.com" },
                    { 72, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "emilycfenner@gmail.com", false, "", "", false, null, "emilycfenner@gmail.com", "emilycfenner@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "4434722746", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "emilycfenner@gmail.com" },
                    { 71, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "eiland454@gmail.com", false, "", "", false, null, "eiland454@gmail.com", "eiland454@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173854494", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "eiland454@gmail.com" },
                    { 85, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jennifer69637@yahoo.com", false, "", "", false, null, "jennifer69637@yahoo.com", "jennifer69637@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179625119", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jennifer69637@yahoo.com" },
                    { 102, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "lizawon1234@icloud.com", false, "", "", false, null, "lizawon1234@icloud.com", "lizawon1234@icloud.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "lizawon1234@icloud.com" },
                    { 103, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "lizpensa@yahoo.com", false, "", "", false, null, "lizpensa@yahoo.com", "lizpensa@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172564595", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "lizpensa@yahoo.com" },
                    { 104, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "LKnight2350@yahoo.com", false, "", "", false, null, "LKnight2350@yahoo.com", "LKnight2350@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173861991", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "LKnight2350@yahoo.com" },
                    { 136, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "xander.becket@gmail.com", false, "", "", false, null, "xander.becket@gmail.com", "xander.becket@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174875404", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "xander.becket@gmail.com" },
                    { 135, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "wpalmer24@gmail.com", false, "", "", false, null, "wpalmer24@gmail.com", "wpalmer24@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176024695", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "wpalmer24@gmail.com" },
                    { 134, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "wpalacade@gmail.com", false, "", "", false, null, "wpalacade@gmail.com", "wpalacade@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173854373", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "wpalacade@gmail.com" },
                    { 133, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "underdog1964@yahoo.com", false, "", "", false, null, "underdog1964@yahoo.com", "underdog1964@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "9143741784", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "underdog1964@yahoo.com" },
                    { 132, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "tperkins@ccpa.net", false, "", "", false, null, "tperkins@ccpa.net", "tperkins@ccpa.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173858529", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "tperkins@ccpa.net" },
                    { 131, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "toshathorson@comcast.net", false, "", "", false, null, "toshathorson@comcast.net", "toshathorson@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173866107", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "toshathorson@comcast.net" },
                    { 130, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "tjheizman@hotmail.com", false, "", "", false, null, "tjheizman@hotmail.com", "tjheizman@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172151752", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "tjheizman@hotmail.com" },
                    { 129, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "smaxwell68@gmail.com", false, "", "", false, null, "smaxwell68@gmail.com", "smaxwell68@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "8137895943", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "smaxwell68@gmail.com" },
                    { 128, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "slusser.kyle@gmail.com", false, "", "", false, null, "slusser.kyle@gmail.com", "slusser.kyle@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174485808", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "slusser.kyle@gmail.com" },
                    { 127, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "shumbergerjamie@yahoo.com", false, "", "", false, null, "shumbergerjamie@yahoo.com", "shumbergerjamie@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "shumbergerjamie@yahoo.com" },
                    { 126, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "shankw@comcast.net", false, "", "", false, null, "shankw@comcast.net", "shankw@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174488830", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "shankw@comcast.net" },
                    { 125, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "shabasil@comcast.net", false, "", "", false, null, "shabasil@comcast.net", "shabasil@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172412797", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "shabasil@comcast.net" },
                    { 124, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "sarahstan27@hotmail.com", false, "", "", false, null, "sarahstan27@hotmail.com", "sarahstan27@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177137514", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "sarahstan27@hotmail.com" },
                    { 123, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "sanielleoaks@centurylink.net", false, "", "", false, null, "sanielleoaks@centurylink.net", "sanielleoaks@centurylink.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7175123328", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "sanielleoaks@centurylink.net" },
                    { 122, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "rutz31585@gmail.com", false, "", "", false, null, "rutz31585@gmail.com", "rutz31585@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177129390", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "rutz31585@gmail.com" },
                    { 121, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "romaveron@gmail.com", false, "", "", false, null, "romaveron@gmail.com", "romaveron@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176495707", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "romaveron@gmail.com" },
                    { 120, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "rogerthat898@comcast.net", false, "", "", false, null, "rogerthat898@comcast.net", "rogerthat898@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174227287", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "rogerthat898@comcast.net" },
                    { 105, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Loveroflife444@gmail.com", false, "", "", false, null, "Loveroflife444@gmail.com", "Loveroflife444@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176092617", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Loveroflife444@gmail.com" },
                    { 106, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "mariadeg14@gmail.com", false, "", "", false, null, "mariadeg14@gmail.com", "mariadeg14@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176361807", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "mariadeg14@gmail.com" },
                    { 107, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "matthew_reichard@yahoo.com", false, "", "", false, null, "matthew_reichard@yahoo.com", "matthew_reichard@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176095764", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "matthew_reichard@yahoo.com" },
                    { 108, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "mcmeekind@yahoo.com", false, "", "", false, null, "mcmeekind@yahoo.com", "mcmeekind@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "4124017530", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "mcmeekind@yahoo.com" },
                    { 109, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "meganfelton4@gmail.com", false, "", "", false, null, "meganfelton4@gmail.com", "meganfelton4@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177061154", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "meganfelton4@gmail.com" },
                    { 110, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "michael.griffie@ames.com", false, "", "", false, null, "michael.griffie@ames.com", "michael.griffie@ames.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "michael.griffie@ames.com" },
                    { 70, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dustinheberlig@yahoo.com", false, "", "", false, null, "dustinheberlig@yahoo.com", "dustinheberlig@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172265613", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dustinheberlig@yahoo.com" },
                    { 111, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "mikalmills78@gmail.com", false, "", "", false, null, "mikalmills78@gmail.com", "mikalmills78@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174403618", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "mikalmills78@gmail.com" },
                    { 113, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "motojim@gmail.com", false, "", "", false, null, "motojim@gmail.com", "motojim@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "9168387691", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "motojim@gmail.com" },
                    { 114, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "nancyjgw167@gmail.com", false, "", "", false, null, "nancyjgw167@gmail.com", "nancyjgw167@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174408315", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "nancyjgw167@gmail.com" },
                    { 115, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "nicole.dean111@gmail.com", false, "", "", false, null, "nicole.dean111@gmail.com", "nicole.dean111@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176099614", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "nicole.dean111@gmail.com" },
                    { 116, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "nicolemulholland172@yahoo.com", false, "", "", false, null, "nicolemulholland172@yahoo.com", "nicolemulholland172@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172263496", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "nicolemulholland172@yahoo.com" },
                    { 118, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "queenkinan80@gmail.com", false, "", "", false, null, "queenkinan80@gmail.com", "queenkinan80@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173869138", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "queenkinan80@gmail.com" },
                    { 119, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "ranigoldsborough@yahoo.com", false, "", "", false, null, "ranigoldsborough@yahoo.com", "ranigoldsborough@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174242543", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "ranigoldsborough@yahoo.com" },
                    { 112, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "monicakipp@yahoo.com", false, "", "", false, null, "monicakipp@yahoo.com", "monicakipp@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176453787", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "monicakipp@yahoo.com" },
                    { 69, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "drthomas94@gmail.com", false, "", "", false, null, "drthomas94@gmail.com", "drthomas94@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172264635", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "drthomas94@gmail.com" },
                    { 117, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "pstackfield@gmail.com", false, "", "", false, null, "pstackfield@gmail.com", "pstackfield@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174484446", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "pstackfield@gmail.com" },
                    { 67, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Dmjones1981@hotmail.com", false, "", "", false, null, "Dmjones1981@hotmail.com", "Dmjones1981@hotmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7178567917", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Dmjones1981@hotmail.com" },
                    { 32, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "alohaparigi@comcast.net", false, "", "", false, null, "alohaparigi@comcast.net", "alohaparigi@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7178052472", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "alohaparigi@comcast.net" },
                    { 31, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "alesyed20@yahoo.com", false, "", "", false, null, "alesyed20@yahoo.com", "alesyed20@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176095354", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "alesyed20@yahoo.com" },
                    { 30, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "alan.seretti@gmail.com", false, "", "", false, null, "alan.seretti@gmail.com", "alan.seretti@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "4128481996", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "alan.seretti@gmail.com" },
                    { 29, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "aktpete@aol.com", false, "", "", false, null, "aktpete@aol.com", "aktpete@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177585364", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "aktpete@aol.com" },
                    { 28, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "akendall2005@aol.com", false, "", "", false, null, "akendall2005@aol.com", "akendall2005@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179619884", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "akendall2005@aol.com" },
                    { 26, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "cgcostalas@gmail.com", false, "Gary", "", false, null, "cgcostalas@gmail.com", "cgcostalas@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "cgcostalas@gmail.com" },
                    { 25, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "taberangela@me.com", false, "Ray", "", false, null, "taberangela@me.com", "taberangela@me.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "taberangela@me.com" },
                    { 24, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "cnkford18@yahoo.com", false, "Doug", "", false, null, "cnkford18@yahoo.com", "cnkford18@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "cnkford18@yahoo.com" },
                    { 23, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "mxr8@pct.edu", false, "Zion", "", false, null, "mxr8@pct.edu", "mxr8@pct.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "mxr8@pct.edu" },
                    { 22, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "felecia.williamson@gmail.com", false, "Asamara", "", false, null, "felecia.williamson@gmail.com", "felecia.williamson@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "felecia.williamson@gmail.com" },
                    { 21, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "nkroof@yahoo.com", false, "Matt", "", false, null, "nkroof@yahoo.com", "nkroof@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "nkroof@yahoo.com" },
                    { 20, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "t_bear25@icloud.com", false, "Walt", "", false, null, "t_bear25@icloud.com", "t_bear25@icloud.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "t_bear25@icloud.com" },
                    { 19, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "rkbrent1111@gmail.com", false, "Dave", "", false, null, "rkbrent1111@gmail.com", "rkbrent1111@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "rkbrent1111@gmail.com" },
                    { 18, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "keirakapner03@gmail.com", false, "Andy", "", false, null, "keirakapner03@gmail.com", "keirakapner03@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "keirakapner03@gmail.com" },
                    { 33, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "alyshiaewell@yahoo.com", false, "", "", false, null, "alyshiaewell@yahoo.com", "alyshiaewell@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179617524", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "alyshiaewell@yahoo.com" },
                    { 17, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "kylie.mcmahan@gmail.com", false, "Kelsey", "", false, null, "kylie.mcmahan@gmail.com", "kylie.mcmahan@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "kylie.mcmahan@gmail.com" },
                    { 15, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "mw681275@sju.edu", false, "Dave", "H", false, null, "mw681275@sju.edu", "mw681275@sju.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "mw681275@sju.edu" },
                    { 14, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "er1293@messiah.edu", false, "Shawn", "", false, null, "er1293@messiah.edu", "er1293@messiah.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "er1293@messiah.edu" },
                    { 13, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "kabrent51@gmail.com", false, "Jamarius", "", false, null, "kabrent51@gmail.com", "kabrent51@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "kabrent51@gmail.com" },
                    { 12, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "kwoy1508@yahoo.com", false, "Andrew", "", false, null, "kwoy1508@yahoo.com", "kwoy1508@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "kwoy1508@yahoo.com" },
                    { 11, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "ceschenman19@gmail.com", false, "Latasha", "", false, null, "ceschenman19@gmail.com", "ceschenman19@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "ceschenman19@gmail.com" },
                    { 10, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "deschenmann@gmail.com", false, "Delonte", "", false, null, "deschenmann@gmail.com", "deschenmann@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "deschenmann@gmail.com" },
                    { 9, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jeffs99285@gmail.com", false, "Gumper", "Stackfield", false, null, "jeffs99285@gmail.com", "jeffs99285@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jeffs99285@gmail.com" },
                    { 8, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "janmcmahan@gmail.com", false, "Maggie", "", false, null, "janmcmahan@gmail.com", "janmcmahan@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "janmcmahan@gmail.com" },
                    { 7, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "skyelee91@icloud.com", false, "Ferg", "Thomas", false, null, "skyelee91@icloud.com", "skyelee91@icloud.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "skyelee91@icloud.com" },
                    { 6, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "andreamariko1k@yahoo.com", false, "Jordan", "Stasyszyn", false, null, "andreamariko1k@yahoo.com", "andreamariko1k@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "andreamariko1k@yahoo.com" },
                    { 5, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "maryzell4@gmail.com", false, "Timmy", "Atkinson", false, null, "maryzell4@gmail.com", "maryzell4@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "maryzell4@gmail.com" },
                    { 4, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "es2531@ymail.com", false, "Chad", "Searer", false, null, "es2531@ymail.com", "es2531@ymail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "es2531@ymail.com" },
                    { 3, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "jbrent21@gmail.com", false, "Preston", "Stackfield", false, null, "jbrent21@gmail.com", "jbrent21@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "jbrent21@gmail.com" },
                    { 2, 0, "f605120f-716d-40c3-9dbd-8ff473410823", "corey@cordanosports.com", false, "Corey", "Gelbaugh", false, null, "corey@cordanosports.com", "corey@cordanosports.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "dfafd561-8cef-40ad-8c7a-339dc67529d0", false, "corey@cordanosports.com" },
                    { 16, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "lydiaphelan1@gmail.com", false, "Renee", "", false, null, "lydiaphelan1@gmail.com", "lydiaphelan1@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, null, false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "lydiaphelan1@gmail.com" },
                    { 34, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Amarshall541to80@gmail.com", false, "", "", false, null, "Amarshall541to80@gmail.com", "Amarshall541to80@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177131299", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Amarshall541to80@gmail.com" },
                    { 27, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "A.McGowan88@yahoo.com", false, "", "", false, null, "A.McGowan88@yahoo.com", "A.McGowan88@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177047642", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "A.McGowan88@yahoo.com" },
                    { 36, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "anget33@gmail.com", false, "", "", false, null, "anget33@gmail.com", "anget33@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179622531", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "anget33@gmail.com" },
                    { 53, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "coreybowman21@gmail.com", false, "", "", false, null, "coreybowman21@gmail.com", "coreybowman21@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174214435", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "coreybowman21@gmail.com" },
                    { 54, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "corrineboyer4@gmail.com", false, "", "", false, null, "corrineboyer4@gmail.com", "corrineboyer4@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "corrineboyer4@gmail.com" },
                    { 55, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "cway2k@yahoo.com", false, "", "", false, null, "cway2k@yahoo.com", "cway2k@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174218654", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "cway2k@yahoo.com" },
                    { 56, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "cwilsoniii1974@gmail.com", false, "", "", false, null, "cwilsoniii1974@gmail.com", "cwilsoniii1974@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "9105547083", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "cwilsoniii1974@gmail.com" },
                    { 35, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "anelasaric78@yahoo.com", false, "", "", false, null, "anelasaric78@yahoo.com", "anelasaric78@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177136275", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "anelasaric78@yahoo.com" },
                    { 58, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Datdude242003@yahoo.com", false, "", "", false, null, "Datdude242003@yahoo.com", "Datdude242003@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177061444", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Datdude242003@yahoo.com" },
                    { 52, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "cmkimm@ship.edu", false, "", "", false, null, "cmkimm@ship.edu", "cmkimm@ship.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "cmkimm@ship.edu" },
                    { 59, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dathomas2130@gmail.com", false, "", "", false, null, "dathomas2130@gmail.com", "dathomas2130@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177609858", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dathomas2130@gmail.com" },
                    { 61, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "davis10108@yahoo.com", false, "", "", false, null, "davis10108@yahoo.com", "davis10108@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173857268", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "davis10108@yahoo.com" },
                    { 62, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dawngrimes13@yahoo.com", false, "", "", false, null, "dawngrimes13@yahoo.com", "dawngrimes13@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7175743266", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dawngrimes13@yahoo.com" },
                    { 63, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "deanenegley@gmail.com", false, "", "", false, null, "deanenegley@gmail.com", "deanenegley@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173851526", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "deanenegley@gmail.com" },
                    { 64, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "devink1973@icloud.com", false, "", "", false, null, "devink1973@icloud.com", "devink1973@icloud.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174488214", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "devink1973@icloud.com" }
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordResetCode", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 65, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dkeeler@ritnersteel.com", false, "", "", false, null, "dkeeler@ritnersteel.com", "dkeeler@ritnersteel.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174488214", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dkeeler@ritnersteel.com" },
                    { 66, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dkj717@gmail.com", false, "", "", false, null, "dkj717@gmail.com", "dkj717@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174222907", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dkj717@gmail.com" },
                    { 60, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "david.baldwin@comcast.net", false, "", "", false, null, "david.baldwin@comcast.net", "david.baldwin@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7179600470", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "david.baldwin@comcast.net" },
                    { 51, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "chrissy187230@gmail.com", false, "", "", false, null, "chrissy187230@gmail.com", "chrissy187230@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7176731183", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "chrissy187230@gmail.com" },
                    { 57, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "Daniellethomas442@yahoo.com", false, "", "", false, null, "Daniellethomas442@yahoo.com", "Daniellethomas442@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173864856", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "Daniellethomas442@yahoo.com" },
                    { 49, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "ccaajj83@yahoo.com", false, "", "", false, null, "ccaajj83@yahoo.com", "ccaajj83@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "2232128188", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "ccaajj83@yahoo.com" },
                    { 50, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "ccarlot1239@gmail.com", false, "", "", false, null, "ccarlot1239@gmail.com", "ccarlot1239@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "2016408647", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "ccarlot1239@gmail.com" },
                    { 38, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "ayeyonce@icloud.com", false, "", "", false, null, "ayeyonce@icloud.com", "ayeyonce@icloud.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173864887", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "ayeyonce@icloud.com" },
                    { 39, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "balleri20@aol.com", false, "", "", false, null, "balleri20@aol.com", "balleri20@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177016358", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "balleri20@aol.com" },
                    { 40, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "bcaugust@comcast.net", false, "", "", false, null, "bcaugust@comcast.net", "bcaugust@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172268276", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "bcaugust@comcast.net" },
                    { 41, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "bcoon723@aol.com", false, "", "", false, null, "bcoon723@aol.com", "bcoon723@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7175127425", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "bcoon723@aol.com" },
                    { 42, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "bete924@gmail.com", false, "", "", false, null, "bete924@gmail.com", "bete924@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173861398", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "bete924@gmail.com" },
                    { 37, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "awaans@yahoo.com", false, "", "", false, null, "awaans@yahoo.com", "awaans@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174977579", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "awaans@yahoo.com" },
                    { 44, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "bls2u2002@yahoo.com", false, "", "", false, null, "bls2u2002@yahoo.com", "bls2u2002@yahoo.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177980804", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "bls2u2002@yahoo.com" },
                    { 43, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "bevshug@gmail.com", false, "", "", false, null, "bevshug@gmail.com", "bevshug@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172260438", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "bevshug@gmail.com" },
                    { 48, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "campbellj@comcast.net", false, "", "", false, null, "campbellj@comcast.net", "campbellj@comcast.net", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7172588849", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "campbellj@comcast.net" },
                    { 47, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "calejandro84@aol.com", false, "", "", false, null, "calejandro84@aol.com", "calejandro84@aol.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7173864409", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "calejandro84@aol.com" },
                    { 68, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "dobynsh@gmail.com", false, "", "", false, null, "dobynsh@gmail.com", "dobynsh@gmail.com", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174621906", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "dobynsh@gmail.com" },
                    { 45, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "blue-dragonfly@hotmail.de", false, "", "", false, null, "blue-dragonfly@hotmail.de", "blue-dragonfly@hotmail.de", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7174624604", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "blue-dragonfly@hotmail.de" },
                    { 46, 0, "b39b7fd6-391c-4d74-ae0c-14a75b78866d", "boegelm@dickinson.edu", false, "", "", false, null, "boegelm@dickinson.edu", "boegelm@dickinson.edu", "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==", null, "7177130560", false, "YSMHWI6B5ZHJFY4JDYXCHTUO52NXZWXB", false, "boegelm@dickinson.edu" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "League",
                columns: new[] { "Id", "Description", "Name", "SportId" },
                values: new object[,]
                {
                    { 3, null, "14U", null },
                    { 2, null, "12U", null },
                    { 1, null, "10U", null }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Player",
                columns: new[] { "Id", "BirthDate", "ContactId", "Email", "FirstName", "IsActive", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 119, null, null, null, "Jeremih", null, "Sothers", null },
                    { 154, null, null, null, "Angelique", null, "Noia", null },
                    { 153, null, null, null, "Brayon", null, "Hunter", null },
                    { 151, null, null, null, "Khamdyn", null, "Drew", null },
                    { 148, null, null, null, "Jasier", null, "Brinkley", null },
                    { 134, null, null, null, "Mekhar", null, "McBride", "Miki" },
                    { 156, null, null, null, "Lucas", null, "Smith", null },
                    { 126, new DateTime(2006, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maxwell", null, "Spraglin", null },
                    { 121, null, null, null, "Quamari", null, "Vasser", null },
                    { 120, null, null, null, "Kareem", null, "Lawson", null },
                    { 138, null, null, null, "Jeremiah", null, "Seller", null },
                    { 129, null, null, null, "Jess", null, "Rourve", null },
                    { 171, null, null, null, "Four", null, "Petre", null },
                    { 158, null, null, null, "Landon", null, "Lackemeyer", null },
                    { 159, null, null, null, "Anthony", null, "Smith", null },
                    { 160, null, null, null, "Adrian", false, "Bennett", "Khi" },
                    { 162, null, null, null, "Nadia", null, "Hunter", null },
                    { 163, null, null, null, "Jace", false, "Jones", null },
                    { 164, null, null, null, "Mason", null, "Shaw", null },
                    { 165, null, null, null, "Savion", null, "Brown", null },
                    { 168, null, null, null, "Rashard", null, "Scott", null },
                    { 169, null, null, null, "Tyrone", false, "Moore", null },
                    { 170, null, null, null, "Zar'Manei", null, "Coble", null },
                    { 118, null, null, null, "Dewitt", false, "Smith", null },
                    { 157, null, null, null, "Joaquin", null, "Ortiz", null },
                    { 116, null, null, null, "Jaiden", null, "Bass", null },
                    { 9, null, null, null, "T'oure", null, "Evans", null },
                    { 113, new DateTime(2004, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jeremiah", null, "Snyder", null },
                    { 11, null, null, null, "Khadr", null, "Vasser", null },
                    { 21, null, null, null, "Xzavier", null, "Tatum", null },
                    { 49, null, null, null, "Zion", null, "Thomas", null },
                    { 52, null, null, null, "Isaiah", null, "Robinson", null },
                    { 64, null, null, null, "Dominic", null, "Johnson", null },
                    { 66, null, null, null, "Z'varione", null, "Clarke", null },
                    { 114, null, null, null, "Jaqueece", null, "Morrell", null },
                    { 93, null, null, null, "Nolan", null, "Snyder", null },
                    { 102, null, null, null, "Ethan", null, "Yentzer", null },
                    { 108, null, null, null, "Damon", null, "Thomas", null },
                    { 110, null, null, null, "Brayden", null, "Lindsey", null },
                    { 111, null, null, null, "Julian", null, "Christopher", null },
                    { 74, null, null, null, "Jasmine", null, "Rouvre", null }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Sponsor",
                columns: new[] { "Id", "Initials", "Name" },
                values: new object[,]
                {
                    { 2, "C-Luv", "C-Luv Thrift" },
                    { 3, "GBS", "GB Stuart" },
                    { 4, "CHA", "Carlisle Home Association" },
                    { 1, "CCC", "Carlisle Community Coalition" },
                    { 5, "CVR", "Cumberland Valley Rising" },
                    { 6, "PBH", "Partnership for Better Health" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Team",
                columns: new[] { "Id", "Initials", "Name" },
                values: new object[,]
                {
                    { 1, "C-Luv", "C-Luv Thrift" },
                    { 2, "GBS", "GB Stuart" },
                    { 3, "CHA", "Carlisle Home Association" },
                    { 7, "C-Luv", "C-Luv Thrift" },
                    { 5, "PBH", "Partnership for Better Health" },
                    { 6, "CCC", "Carlisle Community Coalition" },
                    { 8, "GBS", "GB Stuart Foundation" },
                    { 9, "CHA", "Carlisle Home Association" },
                    { 10, "CVR", "Cumberland Valley Rising" },
                    { 12, "C-Luv", "C-Luv Thrift" },
                    { 13, "GBS", "GB Stuart Foundation" },
                    { 14, "CHA", "Carlisle Home Association" },
                    { 4, "CVR", "Cumberland Valley Rising" },
                    { 11, "PBH", "Partnership for Better Health" },
                    { 16, "PBH", "Partnership for Better Health" },
                    { 15, "CVR", "Cumberland Valley Rising" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Color",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 6, false, "Deep Sky Blue" },
                    { 5, false, "Yellow" },
                    { 4, false, "Blue" },
                    { 3, false, "Red" },
                    { 2, false, "Black" },
                    { 1, false, "Green" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "GameResultType",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 3, false, "Tie" },
                    { 2, false, "Loss" },
                    { 1, false, "Win" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "LocationType",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 2, false, "Court" },
                    { 1, false, "Park" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Season",
                columns: new[] { "Id", "EndDate", "IsActive", "Name", "SeasonTypeId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2019", 0, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2020", 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Size",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 6, false, "Adult M" },
                    { 7, false, "Adult L" },
                    { 1, false, "Child S" },
                    { 2, false, "Child M" },
                    { 3, false, "Child L" },
                    { 4, false, "Child XL" },
                    { 5, false, "Adult S" },
                    { 8, false, "Adult XL" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SponsorshipLevel",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 3, false, "White Level" },
                    { 2, false, "Green Level" },
                    { 1, false, "Black Level" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Sport",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[] { 1, false, "Basketball" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "StatCategory",
                columns: new[] { "Id", "IsActive", "Label", "Name", "SportId" },
                values: new object[,]
                {
                    { 5, false, "Steals", "STL", 0 },
                    { 4, false, "Blocks", "BLK", 0 },
                    { 3, false, "Assists", "AST", 0 },
                    { 2, false, "Rebounds", "REB", 0 },
                    { 1, false, "Points", "PTS", 0 },
                    { 6, false, "Personal Fouls", "PF", 0 }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "LeagueSeason_xref",
                columns: new[] { "Id", "LeagueId", "SeasonId" },
                values: new object[,]
                {
                    { 6, 3, 2 },
                    { 5, 2, 2 },
                    { 4, 1, 2 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Location",
                columns: new[] { "Id", "Description", "LocationTypeId", "Name" },
                values: new object[,]
                {
                    { 4, null, 2, "CHAMPIONSHIP COURT" },
                    { 3, null, 2, "GB Stuart Foundation" },
                    { 2, null, 2, "Partnership for Better Health" },
                    { 1, null, 1, "Memorial Park" }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Player",
                columns: new[] { "Id", "BirthDate", "ContactId", "Email", "FirstName", "IsActive", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 91, null, 27, null, "Jordan", null, "McGowan", null },
                    { 75, new DateTime(2007, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, null, "Jaquez", null, "Knight", "JD" },
                    { 135, new DateTime(2005, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, null, "Ian", null, "Messano", null },
                    { 24, new DateTime(2010, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, null, "Jace", null, "Dagaetano", null },
                    { 65, new DateTime(2007, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, null, "Austin", null, "Reichard", null },
                    { 27, new DateTime(2010, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, null, "Sadie", null, "McMeekin", null },
                    { 6, new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 112, null, "Jadon", null, "Kipp", null },
                    { 8, new DateTime(2009, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, null, "Tayah", null, "Felton", null },
                    { 95, new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, null, "Spencer", null, "Griffie", null },
                    { 46, new DateTime(2008, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, null, "Millio", null, "Millz", null },
                    { 127, new DateTime(2006, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, null, "Khaleed", null, "Washington", null },
                    { 63, new DateTime(2006, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, null, "Gennaro", null, "Pensa", null },
                    { 94, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, null, "Masyn", null, "McMeekin", null },
                    { 39, new DateTime(2009, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, null, "Jasper", null, "Brinkley", null },
                    { 16, new DateTime(2009, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, null, "Jayde", null, "Wilson", null },
                    { 122, new DateTime(2006, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, null, "Jaydon", null, "Smith", null },
                    { 2, new DateTime(2010, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, null, "Drake", null, "Kelley", null },
                    { 99, new DateTime(2009, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, null, "Damion", null, "Jones", "Jace" },
                    { 14, new DateTime(2009, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, null, "Summer", null, "Kunza", null },
                    { 15, new DateTime(2008, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, null, "Carter", null, "Wilson", null },
                    { 71, new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, null, "Jahmiel", null, "Harrel", null },
                    { 26, new DateTime(2009, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, null, "Gus", null, "Yarnell", null },
                    { 73, new DateTime(2006, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, null, "Danielle", null, "Klinger", null },
                    { 43, new DateTime(2011, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, null, "Kenyon", null, "Wideny", null },
                    { 37, new DateTime(2010, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, null, "Lukas", null, "Wright", null },
                    { 147, new DateTime(2004, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, null, "Jake", null, "Panko", null },
                    { 143, new DateTime(2005, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, null, "Hunter", null, "Finkenbinder", null },
                    { 33, new DateTime(2010, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, null, "Grant", null, "Vitek", null },
                    { 87, new DateTime(2007, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, null, "Vincent", null, "Kunza", null },
                    { 48, new DateTime(2009, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 117, null, "Quentin", null, "Stackfield", null },
                    { 55, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, null, "Malachai", false, "Weidner", null },
                    { 23, new DateTime(2009, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, null, "Jack", null, "Becket", null },
                    { 109, new DateTime(2006, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, null, "Nasir", null, "Palmer", null },
                    { 19, new DateTime(2009, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, null, "Azmina", null, "Palmer", null },
                    { 84, new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, null, "Erik", null, "Samuelson", null },
                    { 53, new DateTime(2011, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, "Avah", null, "Thorson", null },
                    { 13, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, null, "Amari", false, "Ibrahim", null },
                    { 97, new DateTime(2007, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, null, "Lucas", null, "Ream", null },
                    { 124, new DateTime(2004, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, null, "Marquise", null, "Miller", null },
                    { 61, new DateTime(2008, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, null, "Sidney", null, "Ewell", null },
                    { 35, new DateTime(2009, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, null, "Sinclair", null, "Ewell", null },
                    { 32, new DateTime(2010, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, null, "Sincere", null, "Ewell", null },
                    { 141, new DateTime(2005, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 126, null, "Louie", null, "Shank", null },
                    { 106, new DateTime(2004, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, null, "Jaden", null, "Pham", null },
                    { 85, new DateTime(2007, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, null, "Tavien", null, "Pham", null },
                    { 107, new DateTime(2006, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, null, "Avery", null, "Stanback", null },
                    { 145, new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, null, "Jose", null, "Oaks", null },
                    { 29, new DateTime(2009, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, null, "Connor", null, "Rutz", null },
                    { 45, new DateTime(2008, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, null, "Kenzo", null, "Veron", null },
                    { 38, new DateTime(2008, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, null, "Roma", null, "Dizon", null },
                    { 7, new DateTime(2009, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, null, "Damion", null, "Roth", "Jace" },
                    { 152, null, 119, null, "Zach", null, "Goldsborough", null },
                    { 101, new DateTime(2007, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, null, "Jacob", null, "Goldsborough", null },
                    { 79, new DateTime(2008, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 118, null, "Malachai", null, "Thomas", null },
                    { 123, new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, null, "Tionne", null, "Johnson", null },
                    { 47, null, 117, null, "Preston", null, "Stackfield", null },
                    { 5, null, 116, null, "Kaleb", null, "Mjuholland", null },
                    { 130, new DateTime(2004, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, null, "Damion", null, "Scott", null },
                    { 54, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, null, "Jacob", false, "Weidner", null },
                    { 92, new DateTime(2008, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, null, "Kamora", null, "Johnson", null },
                    { 104, new DateTime(2005, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, null, "Joeseph", null, "Rosado", "JoJo" },
                    { 132, new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, null, "Jacob", null, "Heckman", null },
                    { 88, new DateTime(2008, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, null, "Braylon", null, "Shugart", null },
                    { 34, new DateTime(2012, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, null, "Adelyn", false, "Pagze", null },
                    { 42, new DateTime(2010, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, null, "Caleb", false, "Pagze", null },
                    { 68, new DateTime(2008, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, null, "Jadon", null, "Harris", null },
                    { 90, new DateTime(2008, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, null, "Henry", null, "Boegel", null },
                    { 100, new DateTime(2006, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, null, "Skyla", null, "Hancock", null },
                    { 167, null, 42, null, "Javione", null, "Alejandro", null },
                    { 25, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, null, "Bishop", null, "Campbell", null },
                    { 146, new DateTime(2005, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, null, "Justus", null, "Johnson", null },
                    { 72, new DateTime(2007, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, null, "Kazmeer", null, "Jaquez", null },
                    { 142, null, 51, null, "Eli", null, "Hargrove", null },
                    { 144, new DateTime(2006, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, null, "Jeremiah", null, "Hargrove", null },
                    { 40, null, 52, null, "Isaac", null, "Kimmel", null },
                    { 59, new DateTime(2008, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, null, "Tayshaun", null, "Dave", null },
                    { 57, new DateTime(2006, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, null, "Xavier", null, "Campbell", null },
                    { 149, new DateTime(2010, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, null, "Dominic", null, "Bowman", null },
                    { 166, null, 42, null, "Davione", null, "Alejandro", null },
                    { 31, new DateTime(2010, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, null, "Channing", null, "Coon", null },
                    { 70, new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null, "Josh", null, "Kendall", null },
                    { 41, new DateTime(2010, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null, "Rylee", false, "Blair", null },
                    { 22, new DateTime(2009, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null, "Eisley", null, "Seretti", null },
                    { 4, new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, null, "Isaiah", null, "Robinson", null },
                    { 51, new DateTime(2008, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, null, "Taliyah", false, "Robinson", null },
                    { 83, new DateTime(2006, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, null, "Alex", null, "Pida", null },
                    { 67, new DateTime(2008, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, null, "Ashton", null, "Coon", null },
                    { 150, new DateTime(2010, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, "Lesean", null, "Scott", null },
                    { 36, new DateTime(2010, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, null, "Nasir", null, "Saric", null },
                    { 105, new DateTime(2004, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, null, "Tyreke", null, "Flowers", null },
                    { 81, new DateTime(2007, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, null, "Alaina", false, "Sweet", null },
                    { 115, null, 38, null, "Bryson", null, "Williams", null },
                    { 117, new DateTime(2005, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, null, "Javoni", null, "Mosesly", null },
                    { 140, new DateTime(2005, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, null, "Luke", null, "August", null },
                    { 12, new DateTime(2009, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, null, "Austin", null, "Marshall", null },
                    { 20, new DateTime(2009, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, null, "Trevon", null, "Harris", "Trey" },
                    { 131, new DateTime(2006, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, null, "Eli", null, "Kimmel", null },
                    { 17, new DateTime(2009, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, null, "Chester", null, "Wilson", "CJ" },
                    { 28, new DateTime(2009, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, null, "Isla", null, "Heckman", null },
                    { 10, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, null, "Wesley", null, "Heckman", null },
                    { 80, new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, null, "DJ", null, "Thomas", null },
                    { 50, new DateTime(2009, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, null, "Jenavive", false, "Thomas", null },
                    { 98, new DateTime(2007, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, null, "Branden", null, "Felton", null },
                    { 125, new DateTime(2005, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, null, "Anthony", null, "Bartoli", null },
                    { 86, new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, null, "Andrew", null, "Bartoli", null },
                    { 78, new DateTime(2007, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, null, "Angelo", null, "Bartoli", null },
                    { 30, new DateTime(2009, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, null, "Khalil", null, "Jackson", null },
                    { 3, new DateTime(2010, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, null, "Javoni", null, "Porter", null },
                    { 133, new DateTime(2006, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, null, "Silah", false, "Niertako", null },
                    { 18, new DateTime(2010, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, null, "Shaun", null, "Smith", null },
                    { 96, new DateTime(2007, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, null, "Conway", null, "Brown II", null },
                    { 56, new DateTime(2006, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, null, "Luke", null, "Fischer", null },
                    { 161, new DateTime(2004, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, null, "Brian", null, "Szeles", null },
                    { 89, null, 77, null, "Tahjmere", false, "Williams", null },
                    { 137, new DateTime(2003, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, null, "Parker", false, "Smith", null },
                    { 82, new DateTime(2008, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, null, "C'myirh", null, "Thomas-Hodge", null },
                    { 112, new DateTime(2005, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, null, "Devon", null, "Montgomery", null },
                    { 1, new DateTime(2011, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, null, "Damauri", null, "Thomas", null },
                    { 77, new DateTime(2008, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, null, "Julian", null, "Miller", null },
                    { 136, new DateTime(2006, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, null, "Dominic", null, "Roman", null },
                    { 76, new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, null, "Cayson", null, "Johnson", null },
                    { 69, new DateTime(2007, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, null, "Trent", null, "Keeler", null },
                    { 60, new DateTime(2007, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, null, "Connor", null, "Baldwin", null },
                    { 128, new DateTime(2006, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, null, "Jayden", null, "Wright", null },
                    { 155, new DateTime(2006, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, null, "Dennis", null, "Jones", null },
                    { 62, new DateTime(2007, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, null, "Aiden", null, "Dobyns", null },
                    { 139, new DateTime(2005, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, null, "Ezeekai", null, "Thomas", "EZ" },
                    { 58, new DateTime(2007, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, null, "Kolbin", null, "Heberling", null },
                    { 44, null, 72, null, "JJ", null, "Fenner", null },
                    { 103, new DateTime(2006, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, null, "Geo", null, "Villanueva", null }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "SponsorSeason_xref",
                columns: new[] { "Id", "SeasonId", "SponsorId", "SponsorshipLevelId" },
                values: new object[,]
                {
                    { 5, 1, 5, null },
                    { 1, 1, 1, null },
                    { 2, 1, 2, null },
                    { 3, 1, 3, null },
                    { 4, 1, 4, null },
                    { 6, 1, 6, null }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Game",
                columns: new[] { "Id", "LeagueSeasonId", "LocationId", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2019, 6, 25, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, 3, new DateTime(2019, 6, 25, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 3, 2, new DateTime(2019, 6, 27, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 3, new DateTime(2019, 6, 27, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 3, 2, new DateTime(2019, 7, 3, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, 3, new DateTime(2019, 7, 3, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, 2, new DateTime(2019, 7, 9, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, 3, new DateTime(2019, 7, 9, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 3, 2, new DateTime(2019, 7, 11, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 3, 3, new DateTime(2019, 7, 11, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 3, 2, new DateTime(2019, 7, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 3, 3, new DateTime(2019, 7, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 3, 2, new DateTime(2019, 7, 23, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 3, 3, new DateTime(2019, 7, 23, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 3, 2, new DateTime(2019, 7, 24, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 3, 3, new DateTime(2019, 7, 24, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 3, 2, new DateTime(2019, 7, 24, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 3, 3, new DateTime(2019, 7, 24, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 3, 2, new DateTime(2019, 7, 25, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 3, 3, new DateTime(2019, 7, 25, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 3, 2, new DateTime(2019, 7, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 3, 3, new DateTime(2019, 7, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, 2, new DateTime(2019, 6, 25, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 2, new DateTime(2019, 6, 25, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 3, new DateTime(2019, 6, 25, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 2, new DateTime(2019, 6, 27, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 2, 4, new DateTime(2019, 8, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 2, 3, new DateTime(2019, 8, 1, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 2, 2, new DateTime(2019, 8, 1, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 2, 3, new DateTime(2019, 8, 1, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 2, 2, new DateTime(2019, 8, 1, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 2, 3, new DateTime(2019, 7, 25, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 2, 2, new DateTime(2019, 7, 25, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 2, 3, new DateTime(2019, 7, 24, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 2, 2, new DateTime(2019, 7, 24, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 2, 3, new DateTime(2019, 7, 23, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 3, 3, new DateTime(2019, 8, 1, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 2, 2, new DateTime(2019, 7, 23, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 2, 2, new DateTime(2019, 7, 23, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 2, 3, new DateTime(2019, 7, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 2, 2, new DateTime(2019, 7, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 2, 3, new DateTime(2019, 7, 11, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, 2, new DateTime(2019, 7, 11, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, 3, new DateTime(2019, 7, 9, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 2, 2, new DateTime(2019, 7, 9, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, 3, new DateTime(2019, 7, 3, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, 2, new DateTime(2019, 7, 3, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 3, new DateTime(2019, 6, 27, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 2, 3, new DateTime(2019, 7, 23, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 3, 3, new DateTime(2019, 8, 1, 19, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 3, 4, new DateTime(2019, 8, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 2, new DateTime(2019, 6, 27, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 2, new DateTime(2019, 7, 3, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 3, new DateTime(2019, 7, 3, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 2, new DateTime(2019, 7, 9, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 3, new DateTime(2019, 7, 9, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, 2, new DateTime(2019, 7, 9, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, 3, new DateTime(2019, 7, 9, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, 2, new DateTime(2019, 7, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, 3, new DateTime(2019, 7, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, 2, new DateTime(2019, 7, 23, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, 3, new DateTime(2019, 7, 23, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, 2, new DateTime(2019, 7, 24, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 1, 3, new DateTime(2019, 7, 24, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, 2, new DateTime(2019, 7, 25, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, 3, new DateTime(2019, 7, 25, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 1, 2, new DateTime(2019, 7, 25, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 1, 3, new DateTime(2019, 7, 25, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 1, 2, new DateTime(2019, 7, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, 3, new DateTime(2019, 7, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 1, 2, new DateTime(2019, 8, 1, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 1, 3, new DateTime(2019, 8, 1, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 1, 4, new DateTime(2019, 8, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 3, new DateTime(2019, 6, 25, 17, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 3, new DateTime(2019, 6, 27, 17, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "PlayerLeagueSeason_xref",
                columns: new[] { "Id", "JerseyNumberChoice1", "JerseyNumberChoice2", "JerseyNumberChoice3", "JerseySizeId", "LeagueSeasonId", "PlayerId", "SeasonId" },
                values: new object[,]
                {
                    { 124, null, null, null, null, 3, 124, null },
                    { 101, null, null, null, null, 2, 101, null },
                    { 81, null, null, null, null, 2, 81, null },
                    { 82, null, null, null, null, 2, 82, null },
                    { 83, null, null, null, null, 2, 83, null },
                    { 84, null, null, null, null, 2, 84, null },
                    { 85, null, null, null, null, 2, 85, null },
                    { 86, null, null, null, null, 2, 86, null },
                    { 87, null, null, null, null, 2, 87, null },
                    { 88, null, null, null, null, 2, 88, null },
                    { 89, null, null, null, null, 2, 89, null },
                    { 171, null, null, null, null, 3, 171, null },
                    { 90, null, null, null, null, 2, 90, null },
                    { 92, null, null, null, null, 2, 92, null },
                    { 93, null, null, null, null, 2, 93, null },
                    { 94, null, null, null, null, 2, 94, null },
                    { 95, null, null, null, null, 2, 95, null },
                    { 96, null, null, null, null, 2, 96, null },
                    { 97, null, null, null, null, 2, 97, null },
                    { 98, null, null, null, null, 2, 98, null },
                    { 99, null, null, null, null, 2, 99, null },
                    { 100, null, null, null, null, 2, 100, null },
                    { 91, null, null, null, null, 2, 91, null },
                    { 125, null, null, null, null, 3, 125, null },
                    { 102, null, null, null, null, 2, 102, null },
                    { 161, null, null, null, null, 3, 161, null },
                    { 104, null, null, null, null, 3, 104, null },
                    { 105, null, null, null, null, 3, 105, null },
                    { 106, null, null, null, null, 3, 106, null },
                    { 107, null, null, null, null, 3, 107, null },
                    { 108, null, null, null, null, 3, 108, null },
                    { 109, null, null, null, null, 3, 109, null },
                    { 110, null, null, null, null, 3, 110, null },
                    { 111, null, null, null, null, 3, 111, null },
                    { 112, null, null, null, null, 3, 112, null },
                    { 103, null, null, null, null, 3, 103, null },
                    { 113, null, null, null, null, 3, 113, null },
                    { 115, null, null, null, null, 3, 115, null },
                    { 116, null, null, null, null, 3, 116, null },
                    { 117, null, null, null, null, 3, 117, null },
                    { 118, null, null, null, null, 3, 118, null },
                    { 119, null, null, null, null, 3, 119, null },
                    { 120, null, null, null, null, 3, 120, null },
                    { 121, null, null, null, null, 3, 121, null },
                    { 122, null, null, null, null, 3, 122, null },
                    { 123, null, null, null, null, 3, 123, null },
                    { 114, null, null, null, null, 3, 114, null },
                    { 80, null, null, null, null, 2, 80, null },
                    { 126, null, null, null, null, 3, 126, null },
                    { 127, null, null, null, null, 3, 127, null },
                    { 157, null, null, null, null, 3, 157, null },
                    { 147, null, null, null, null, 3, 147, null },
                    { 146, null, null, null, null, 3, 146, null },
                    { 145, null, null, null, null, 3, 145, null },
                    { 144, null, null, null, null, 3, 144, null },
                    { 143, null, null, null, null, 3, 143, null },
                    { 142, null, null, null, null, 3, 142, null },
                    { 141, null, null, null, null, 3, 141, null },
                    { 140, null, null, null, null, 3, 140, null },
                    { 139, null, null, null, null, 3, 139, null },
                    { 138, null, null, null, null, 3, 138, null },
                    { 137, null, null, null, null, 3, 137, null },
                    { 136, null, null, null, null, 3, 136, null },
                    { 135, null, null, null, null, 3, 135, null },
                    { 134, null, null, null, null, 3, 134, null },
                    { 133, null, null, null, null, 3, 133, null },
                    { 132, null, null, null, null, 3, 132, null },
                    { 131, null, null, null, null, 3, 131, null },
                    { 130, null, null, null, null, 3, 130, null },
                    { 129, null, null, null, null, 3, 129, null },
                    { 128, null, null, null, null, 3, 128, null },
                    { 155, null, null, null, null, 2, 155, null },
                    { 79, null, null, null, null, 2, 79, null },
                    { 61, null, null, null, null, 2, 61, null },
                    { 77, null, null, null, null, 2, 77, null },
                    { 26, null, null, null, null, 1, 26, null },
                    { 27, null, null, null, null, 1, 27, null },
                    { 28, null, null, null, null, 1, 28, null },
                    { 29, null, null, null, null, 1, 29, null },
                    { 30, null, null, null, null, 1, 30, null },
                    { 31, null, null, null, null, 1, 31, null },
                    { 32, null, null, null, null, 1, 32, null },
                    { 33, null, null, null, null, 1, 33, null },
                    { 34, null, null, null, null, 1, 34, null },
                    { 35, null, null, null, null, 1, 35, null },
                    { 36, null, null, null, null, 1, 36, null },
                    { 37, null, null, null, null, 1, 37, null },
                    { 38, null, null, null, null, 1, 38, null },
                    { 39, null, null, null, null, 1, 39, null },
                    { 40, null, null, null, null, 1, 40, null },
                    { 78, null, null, null, null, 2, 78, null },
                    { 42, null, null, null, null, 1, 42, null },
                    { 43, null, null, null, null, 1, 43, null },
                    { 44, null, null, null, null, 1, 44, null },
                    { 45, null, null, null, null, 1, 45, null },
                    { 46, null, null, null, null, 1, 46, null },
                    { 25, null, null, null, null, 1, 25, null },
                    { 47, null, null, null, null, 1, 47, null },
                    { 24, null, null, null, null, 1, 24, null },
                    { 22, null, null, null, null, 1, 22, null },
                    { 1, null, null, null, null, 1, 1, null },
                    { 2, null, null, null, null, 1, 2, null },
                    { 3, null, null, null, null, 1, 3, null },
                    { 4, null, null, null, null, 1, 4, null },
                    { 5, null, null, null, null, 1, 5, null },
                    { 6, null, null, null, null, 1, 6, null },
                    { 7, null, null, null, null, 1, 7, null },
                    { 8, null, null, null, null, 1, 8, null },
                    { 9, null, null, null, null, 1, 9, null },
                    { 10, null, null, null, null, 1, 10, null },
                    { 11, null, null, null, null, 1, 11, null },
                    { 12, null, null, null, null, 1, 12, null },
                    { 13, null, null, null, null, 1, 13, null },
                    { 14, null, null, null, null, 1, 14, null },
                    { 15, null, null, null, null, 1, 15, null },
                    { 16, null, null, null, null, 1, 16, null },
                    { 17, null, null, null, null, 1, 17, null },
                    { 18, null, null, null, null, 1, 18, null },
                    { 19, null, null, null, null, 1, 19, null },
                    { 20, null, null, null, null, 1, 20, null },
                    { 21, null, null, null, null, 1, 21, null },
                    { 23, null, null, null, null, 1, 23, null },
                    { 48, null, null, null, null, 1, 48, null },
                    { 41, null, null, null, null, 1, 41, null },
                    { 50, null, null, null, null, 1, 50, null },
                    { 57, null, null, null, null, 2, 57, null },
                    { 58, null, null, null, null, 2, 58, null },
                    { 59, null, null, null, null, 2, 59, null },
                    { 60, null, null, null, null, 2, 60, null },
                    { 49, null, null, null, null, 1, 49, null },
                    { 62, null, null, null, null, 2, 62, null },
                    { 63, null, null, null, null, 2, 63, null },
                    { 64, null, null, null, null, 2, 64, null },
                    { 65, null, null, null, null, 2, 65, null },
                    { 170, null, null, null, null, 1, 170, null },
                    { 66, null, null, null, null, 2, 66, null },
                    { 68, null, null, null, null, 2, 68, null },
                    { 69, null, null, null, null, 2, 69, null },
                    { 70, null, null, null, null, 2, 70, null },
                    { 71, null, null, null, null, 2, 71, null },
                    { 72, null, null, null, null, 2, 72, null },
                    { 73, null, null, null, null, 2, 73, null },
                    { 74, null, null, null, null, 2, 74, null },
                    { 75, null, null, null, null, 2, 75, null },
                    { 76, null, null, null, null, 2, 76, null },
                    { 67, null, null, null, null, 2, 67, null },
                    { 169, null, null, null, null, 1, 169, null },
                    { 56, null, null, null, null, 2, 56, null },
                    { 167, null, null, null, null, 1, 167, null },
                    { 51, null, null, null, null, 1, 51, null },
                    { 52, null, null, null, null, 1, 52, null },
                    { 53, null, null, null, null, 1, 53, null },
                    { 54, null, null, null, null, 1, 54, null },
                    { 55, null, null, null, null, 1, 55, null },
                    { 148, null, null, null, null, 1, 148, null },
                    { 149, null, null, null, null, 1, 149, null },
                    { 150, null, null, null, null, 1, 150, null },
                    { 168, null, null, null, null, 1, 168, null },
                    { 152, null, null, null, null, 1, 152, null },
                    { 153, null, null, null, null, 1, 153, null },
                    { 151, null, null, null, null, 1, 151, null },
                    { 156, null, null, null, null, 1, 156, null },
                    { 158, null, null, null, null, 1, 158, null },
                    { 159, null, null, null, null, 1, 159, null },
                    { 160, null, null, null, null, 1, 160, null },
                    { 162, null, null, null, null, 1, 162, null },
                    { 163, null, null, null, null, 1, 163, null },
                    { 164, null, null, null, null, 1, 164, null },
                    { 165, null, null, null, null, 1, 165, null },
                    { 154, null, null, null, null, 1, 154, null },
                    { 166, null, null, null, null, 1, 166, null }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                columns: new[] { "Id", "CoachId", "ColorId", "LeagueSeasonId", "SponsorSeasonId", "TeamId" },
                values: new object[,]
                {
                    { 14, 14, 3, 3, 4, 14 },
                    { 4, 4, 4, 1, 5, 4 },
                    { 9, 9, 3, 2, 4, 9 },
                    { 15, 15, 4, 3, 5, 15 },
                    { 5, 5, 5, 1, 6, 5 },
                    { 10, 10, 4, 2, 5, 10 },
                    { 3, 3, 3, 1, 4, 3 },
                    { 11, 11, 5, 2, 6, 11 },
                    { 8, 8, 2, 2, 3, 8 },
                    { 2, 2, 2, 1, 3, 2 },
                    { 12, 12, 1, 3, 2, 12 },
                    { 7, 7, 1, 2, 2, 7 },
                    { 1, 1, 1, 1, 2, 1 },
                    { 6, 6, 6, 1, 1, 6 },
                    { 13, 13, 2, 3, 3, 13 },
                    { 16, 16, 5, 3, 6, 16 }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "GameTeam_xref",
                columns: new[] { "Id", "GameId", "GameResultTypeId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 143, 72, null, 9 },
                    { 144, 72, null, 11 },
                    { 147, 74, null, 10 },
                    { 148, 74, null, 9 },
                    { 9, 5, null, 12 },
                    { 10, 5, null, 14 },
                    { 142, 71, null, 8 },
                    { 11, 6, null, 16 },
                    { 21, 11, null, 16 },
                    { 22, 11, null, 12 },
                    { 23, 12, null, 13 },
                    { 24, 12, null, 15 },
                    { 33, 17, null, 13 },
                    { 34, 17, null, 14 },
                    { 12, 6, null, 13 },
                    { 141, 71, null, 10 },
                    { 136, 68, null, 8 },
                    { 135, 68, null, 11 },
                    { 80, 40, null, 9 },
                    { 85, 43, null, 11 },
                    { 86, 43, null, 7 },
                    { 87, 44, null, 8 },
                    { 88, 44, null, 10 },
                    { 93, 47, null, 7 },
                    { 94, 47, null, 9 },
                    { 95, 48, null, 8 },
                    { 96, 48, null, 11 },
                    { 109, 55, null, 9 },
                    { 110, 55, null, 8 },
                    { 111, 56, null, 10 },
                    { 112, 56, null, 7 },
                    { 133, 67, null, 9 },
                    { 134, 67, null, 7 },
                    { 35, 18, null, 16 },
                    { 36, 18, null, 15 },
                    { 45, 23, null, 12 },
                    { 46, 23, null, 13 },
                    { 102, 51, null, 12 },
                    { 103, 52, 1, 16 },
                    { 104, 52, 2, 15 },
                    { 113, 57, null, 14 },
                    { 114, 57, null, 13 },
                    { 115, 58, null, 16 },
                    { 116, 58, null, 12 },
                    { 125, 63, null, 14 },
                    { 126, 63, null, 12 },
                    { 127, 64, null, 16 },
                    { 128, 64, null, 13 },
                    { 137, 69, null, 16 },
                    { 138, 69, null, 12 },
                    { 139, 70, null, 13 },
                    { 140, 70, null, 14 },
                    { 101, 51, null, 13 },
                    { 79, 40, null, 10 },
                    { 100, 50, null, 14 },
                    { 98, 49, 1, 12 },
                    { 47, 24, null, 14 },
                    { 48, 24, null, 15 },
                    { 57, 29, null, 13 },
                    { 58, 29, null, 16 },
                    { 59, 30, null, 12 },
                    { 60, 30, null, 14 },
                    { 69, 35, 2, 12 },
                    { 70, 35, 1, 16 },
                    { 71, 36, null, 15 },
                    { 72, 36, null, 14 },
                    { 81, 41, 1, 13 },
                    { 82, 41, 2, 15 },
                    { 83, 42, 1, 16 },
                    { 84, 42, 2, 14 },
                    { 97, 49, 2, 15 },
                    { 99, 50, null, 16 },
                    { 78, 39, null, 11 },
                    { 77, 39, null, 7 },
                    { 68, 34, null, 10 },
                    { 61, 31, null, 4 },
                    { 62, 31, null, 5 },
                    { 63, 32, null, 1 },
                    { 64, 32, null, 6 },
                    { 73, 37, null, 3 },
                    { 74, 37, null, 1 },
                    { 75, 38, null, 2 },
                    { 76, 38, null, 4 },
                    { 89, 45, null, 6 },
                    { 90, 45, null, 2 },
                    { 91, 46, null, 5 },
                    { 92, 46, null, 4 },
                    { 105, 53, null, 6 },
                    { 106, 53, null, 2 },
                    { 107, 54, null, 5 },
                    { 52, 26, 1, 6 },
                    { 108, 54, null, 3 },
                    { 51, 26, 2, 4 },
                    { 49, 25, null, 2 },
                    { 2, 1, null, 2 },
                    { 3, 2, null, 3 },
                    { 4, 2, null, 4 },
                    { 13, 7, null, 5 },
                    { 14, 7, null, 6 },
                    { 15, 8, null, 1 },
                    { 16, 8, null, 3 },
                    { 25, 13, null, 1 },
                    { 26, 13, null, 5 },
                    { 27, 14, null, 3 },
                    { 28, 14, null, 6 },
                    { 37, 19, null, 4 },
                    { 38, 19, null, 2 },
                    { 39, 20, null, 1 },
                    { 40, 20, null, 3 },
                    { 50, 25, null, 5 },
                    { 149, 75, null, 16 },
                    { 117, 59, null, 3 },
                    { 119, 60, null, 1 },
                    { 29, 15, null, 10 },
                    { 30, 15, null, 7 },
                    { 31, 16, null, 11 },
                    { 32, 16, null, 9 },
                    { 41, 21, null, 7 },
                    { 42, 21, null, 8 },
                    { 43, 22, null, 9 },
                    { 44, 22, null, 10 },
                    { 53, 27, null, 8 },
                    { 54, 27, null, 10 },
                    { 55, 28, null, 11 },
                    { 56, 28, null, 9 },
                    { 65, 33, 1, 7 },
                    { 66, 33, 2, 8 },
                    { 67, 34, null, 11 },
                    { 20, 10, null, 8 },
                    { 118, 59, null, 6 },
                    { 19, 10, null, 11 },
                    { 17, 9, null, 7 },
                    { 120, 60, null, 2 },
                    { 121, 61, null, 5 },
                    { 122, 61, null, 6 },
                    { 123, 62, null, 1 },
                    { 124, 62, null, 4 },
                    { 129, 65, null, 5 },
                    { 130, 65, null, 2 },
                    { 131, 66, null, 3 },
                    { 132, 66, null, 4 },
                    { 145, 73, null, 6 },
                    { 146, 73, null, 5 },
                    { 5, 3, null, 11 },
                    { 6, 3, null, 10 },
                    { 7, 4, null, 9 },
                    { 8, 4, null, 8 },
                    { 18, 9, null, 9 },
                    { 150, 75, null, 13 }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "GamePlayer_xref",
                columns: new[] { "Id", "GameTeamId", "JerseyNumber", "PlayerId" },
                values: new object[,]
                {
                    { 1, 1, "0", 7 },
                    { 862, 143, "6", 94 },
                    { 863, 143, "7", 98 },
                    { 864, 143, "12", 95 },
                    { 865, 144, "1", 67 },
                    { 866, 144, "2", 66 },
                    { 867, 144, "3", 73 },
                    { 868, 144, "5", 65 },
                    { 869, 144, "6", 69 },
                    { 870, 144, "7", 68 },
                    { 871, 144, "8", 70 },
                    { 872, 144, "9", 74 },
                    { 861, 143, "5", 162 },
                    { 885, 147, "0", 83 },
                    { 887, 147, "1", 78 },
                    { 888, 147, "2", 77 },
                    { 889, 147, "3", 76 },
                    { 890, 147, "5", 155 },
                    { 891, 147, "6", 75 },
                    { 892, 148, "0", 100 },
                    { 893, 148, "1", 99 },
                    { 894, 148, "4", 96 },
                    { 895, 148, "5", 162 },
                    { 896, 148, "6", 94 },
                    { 897, 148, "7", 98 },
                    { 886, 147, "1", 79 },
                    { 57, 9, "0", 121 },
                    { 860, 143, "3", 102 },
                    { 858, 143, "0", 100 },
                    { 806, 135, "5", 65 },
                    { 807, 135, "7", 68 },
                    { 808, 135, "8", 70 },
                    { 809, 135, "9", 74 },
                    { 810, 136, "0", 88 },
                    { 811, 136, "2", 85 },
                    { 812, 136, "4", 90 },
                    { 813, 136, "5", 86 },
                    { 814, 136, "7", 93 },
                    { 815, 136, "8", 84 },
                    { 844, 141, "0", 83 },
                    { 859, 143, "1", 99 },
                    { 845, 141, "1", 79 },
                    { 847, 141, "2", 77 },
                    { 848, 141, "3", 76 },
                    { 849, 141, "5", 155 },
                    { 850, 141, "6", 75 },
                    { 851, 142, "0", 88 },
                    { 852, 142, "2", 85 },
                    { 853, 142, "3", 87 },
                    { 854, 142, "4", 90 },
                    { 855, 142, "5", 86 },
                    { 856, 142, "6", 156 },
                    { 857, 142, "8", 84 },
                    { 846, 141, "1", 78 },
                    { 58, 9, "1", 127 },
                    { 59, 9, "3", 158 },
                    { 60, 9, "4", 159 },
                    { 143, 21, "2", 117 },
                    { 144, 21, "3", 113 },
                    { 145, 21, "4", 115 },
                    { 146, 21, "5", 120 },
                    { 147, 21, "8", 112 },
                    { 148, 21, "9", 114 },
                    { 149, 22, "0", 121 },
                    { 150, 22, "1", 127 },
                    { 151, 22, "2", 125 },
                    { 152, 22, "3", 158 },
                    { 153, 22, "4", 159 },
                    { 142, 21, "1", 157 },
                    { 154, 22, "5", 129 },
                    { 156, 22, "7", 126 },
                    { 157, 22, "8", 122 },
                    { 158, 22, "9", 124 },
                    { 159, 23, "0", 107 },
                    { 160, 23, "1", 109 },
                    { 161, 23, "3", 105 },
                    { 162, 23, "4", 111 },
                    { 163, 23, "5", 104 },
                    { 164, 23, "6", 80 },
                    { 165, 23, "8", 106 },
                    { 166, 24, "00", 135 },
                    { 155, 22, "6", 123 },
                    { 141, 21, "0", 116 },
                    { 87, 12, "8", 106 },
                    { 86, 12, "6", 80 },
                    { 61, 9, "5", 129 },
                    { 62, 9, "6", 123 },
                    { 63, 9, "7", 126 },
                    { 64, 9, "8", 122 },
                    { 65, 9, "9", 124 },
                    { 66, 10, "0", 143 },
                    { 67, 10, "1", 147 },
                    { 68, 10, "3", 140 },
                    { 69, 10, "4", 139 },
                    { 70, 10, "4", 146 },
                    { 71, 10, "7", 142 },
                    { 72, 10, "8", 141 },
                    { 73, 11, "0", 116 },
                    { 74, 11, "1", 157 },
                    { 75, 11, "2", 117 },
                    { 76, 11, "3", 113 },
                    { 77, 11, "4", 115 },
                    { 78, 11, "5", 120 },
                    { 79, 11, "8", 112 },
                    { 80, 11, "9", 114 },
                    { 81, 12, "0", 107 },
                    { 82, 12, "1", 109 },
                    { 83, 12, "3", 105 },
                    { 84, 12, "4", 111 },
                    { 85, 12, "5", 104 },
                    { 805, 135, "3", 73 },
                    { 804, 135, "2", 66 },
                    { 803, 135, "1", 67 },
                    { 802, 134, "9", 64 },
                    { 515, 85, "5", 65 },
                    { 516, 85, "7", 68 },
                    { 517, 85, "9", 74 },
                    { 518, 86, "0", 59 },
                    { 519, 86, "2", 57 },
                    { 520, 86, "3", 58 },
                    { 521, 86, "7", 62 },
                    { 522, 86, "9", 64 },
                    { 523, 87, "0", 88 },
                    { 524, 87, "2", 85 },
                    { 525, 87, "5", 78 },
                    { 514, 85, "2", 66 },
                    { 526, 87, "6", 156 },
                    { 711, 87, "4", 90 },
                    { 528, 88, "1", 79 },
                    { 529, 88, "2", 87 },
                    { 530, 88, "3", 86 },
                    { 531, 88, "5", 155 },
                    { 532, 88, "6", 75 },
                    { 555, 93, "0", 59 },
                    { 556, 93, "2", 57 },
                    { 557, 93, "3", 58 },
                    { 558, 93, "7", 62 },
                    { 559, 93, "9", 64 },
                    { 527, 87, "7", 93 },
                    { 513, 85, "1", 67 },
                    { 512, 80, "12", 95 },
                    { 511, 80, "8", 97 },
                    { 446, 68, "3", 76 },
                    { 447, 68, "5", 155 },
                    { 448, 68, "6", 75 },
                    { 489, 77, "0", 59 },
                    { 490, 77, "2", 57 },
                    { 491, 77, "3", 58 },
                    { 492, 77, "7", 62 },
                    { 493, 77, "8", 61 },
                    { 494, 77, "9", 64 },
                    { 495, 78, "1", 67 },
                    { 496, 78, "2", 66 },
                    { 497, 78, "5", 65 },
                    { 498, 78, "6", 69 },
                    { 499, 78, "7", 68 },
                    { 500, 78, "9", 74 },
                    { 501, 79, "1", 79 },
                    { 502, 79, "1", 78 },
                    { 503, 79, "2", 77 },
                    { 504, 79, "3", 76 },
                    { 505, 79, "5", 155 },
                    { 506, 79, "6", 75 },
                    { 507, 80, "0", 100 },
                    { 508, 80, "4", 96 },
                    { 509, 80, "6", 94 },
                    { 510, 80, "7", 98 },
                    { 560, 94, "0", 100 },
                    { 167, 24, "2", 130 },
                    { 561, 94, "1", 99 },
                    { 563, 94, "5", 162 },
                    { 641, 110, "8", 84 },
                    { 642, 110, "9", 91 },
                    { 643, 111, "0", 83 },
                    { 644, 111, "1", 79 },
                    { 645, 111, "1", 78 },
                    { 646, 111, "2", 77 },
                    { 647, 111, "3", 76 },
                    { 648, 111, "5", 155 },
                    { 649, 111, "6", 75 },
                    { 650, 111, "7", 154 },
                    { 651, 112, "0", 59 },
                    { 640, 110, "6", 156 },
                    { 652, 112, "2", 57 },
                    { 654, 112, "9", 64 },
                    { 791, 133, "0", 100 },
                    { 792, 133, "1", 99 },
                    { 793, 133, "3", 102 },
                    { 794, 133, "5", 162 },
                    { 795, 133, "7", 98 },
                    { 796, 133, "12", 95 },
                    { 798, 134, "0", 59 },
                    { 799, 134, "1", 56 },
                    { 800, 134, "3", 58 },
                    { 801, 134, "5", 60 },
                    { 653, 112, "8", 61 },
                    { 639, 110, "5", 86 },
                    { 638, 110, "4", 90 },
                    { 637, 110, "3", 87 },
                    { 564, 94, "6", 94 },
                    { 565, 94, "7", 98 },
                    { 566, 94, "8", 97 },
                    { 567, 95, "0", 88 },
                    { 568, 95, "2", 85 },
                    { 569, 95, "3", 87 },
                    { 570, 95, "4", 90 },
                    { 571, 95, "5", 78 },
                    { 572, 95, "6", 156 },
                    { 573, 95, "8", 84 },
                    { 574, 96, "1", 67 },
                    { 575, 96, "2", 66 },
                    { 576, 96, "5", 65 },
                    { 577, 96, "7", 68 },
                    { 578, 96, "9", 74 },
                    { 627, 109, "0", 100 },
                    { 628, 109, "1", 99 },
                    { 629, 109, "3", 102 },
                    { 630, 109, "4", 96 },
                    { 631, 109, "6", 94 },
                    { 632, 109, "7", 98 },
                    { 633, 109, "8", 97 },
                    { 634, 109, "12", 95 },
                    { 635, 110, "0", 88 },
                    { 636, 110, "2", 85 },
                    { 562, 94, "4", 96 },
                    { 445, 68, "2", 77 },
                    { 168, 24, "2", 161 },
                    { 170, 24, "7", 131 },
                    { 674, 115, "3", 113 },
                    { 675, 115, "5", 120 },
                    { 676, 115, "8", 112 },
                    { 677, 115, "9", 114 },
                    { 678, 115, "14", 130 },
                    { 679, 116, "0", 121 },
                    { 680, 116, "1", 127 },
                    { 681, 116, "2", 125 },
                    { 682, 116, "3", 158 },
                    { 683, 116, "4", 159 },
                    { 684, 116, "8", 122 },
                    { 673, 115, "2", 117 },
                    { 738, 125, "1", 147 },
                    { 740, 125, "4", 146 },
                    { 741, 125, "5", 139 },
                    { 742, 125, "7", 142 },
                    { 743, 125, "8", 141 },
                    { 744, 125, "14", 170 },
                    { 745, 125, "15", 135 },
                    { 746, 126, "0", 121 },
                    { 747, 126, "1", 127 },
                    { 748, 126, "2", 125 },
                    { 749, 126, "3", 158 },
                    { 750, 126, "16", 161 },
                    { 739, 125, "3", 140 },
                    { 751, 126, "18", 136 },
                    { 672, 115, "1", 157 },
                    { 670, 114, "11", 131 },
                    { 592, 101, "4", 111 },
                    { 593, 101, "5", 104 },
                    { 594, 101, "6", 80 },
                    { 595, 101, "8", 106 },
                    { 596, 102, "1", 127 },
                    { 597, 102, "2", 125 },
                    { 598, 102, "3", 158 },
                    { 599, 102, "7", 126 },
                    { 600, 102, "8", 122 },
                    { 655, 113, "0", 143 },
                    { 656, 113, "1", 147 },
                    { 671, 115, "0", 116 },
                    { 657, 113, "3", 140 },
                    { 659, 113, "6", 144 },
                    { 660, 113, "7", 142 },
                    { 661, 113, "8", 141 },
                    { 662, 114, "0", 107 },
                    { 663, 114, "1", 109 },
                    { 664, 114, "4", 111 },
                    { 665, 114, "5", 104 },
                    { 666, 114, "6", 80 },
                    { 667, 114, "7", 171 },
                    { 668, 114, "8", 106 },
                    { 669, 114, "11", 105 },
                    { 658, 113, "4", 146 },
                    { 752, 127, "1", 157 },
                    { 753, 127, "3", 113 },
                    { 754, 127, "5", 120 },
                    { 834, 139, "5", 104 },
                    { 835, 139, "6", 80 },
                    { 836, 139, "8", 106 },
                    { 837, 139, "14", 131 },
                    { 838, 140, "0", 143 },
                    { 839, 140, "3", 140 },
                    { 840, 140, "4", 146 },
                    { 841, 140, "5", 139 },
                    { 842, 140, "8", 141 },
                    { 843, 140, "15", 135 },
                    { 898, 149, "0", 116 },
                    { 833, 139, "4", 111 },
                    { 899, 149, "1", 157 },
                    { 901, 149, "3", 113 },
                    { 902, 149, "4", 115 },
                    { 903, 149, "5", 120 },
                    { 904, 149, "8", 112 },
                    { 905, 149, "9", 114 },
                    { 906, 149, "14", 130 },
                    { 907, 150, "1", 109 },
                    { 908, 150, "3", 105 },
                    { 909, 150, "4", 111 },
                    { 910, 150, "5", 104 },
                    { 911, 150, "6", 80 },
                    { 900, 149, "2", 117 },
                    { 832, 139, "3", 105 },
                    { 831, 139, "1", 109 },
                    { 830, 138, "18", 136 },
                    { 755, 127, "8", 112 },
                    { 756, 127, "9", 114 },
                    { 757, 127, "14", 130 },
                    { 765, 127, "2", 117 },
                    { 758, 128, "1", 109 },
                    { 759, 128, "5", 104 },
                    { 760, 128, "6", 80 },
                    { 761, 128, "7", 171 },
                    { 762, 128, "8", 106 },
                    { 763, 128, "11", 105 },
                    { 764, 128, "14", 131 },
                    { 816, 137, "0", 116 },
                    { 817, 137, "1", 157 },
                    { 818, 137, "3", 113 },
                    { 819, 137, "4", 115 },
                    { 820, 137, "5", 120 },
                    { 821, 137, "8", 112 },
                    { 822, 137, "9", 114 },
                    { 823, 137, "14", 130 },
                    { 824, 138, "0", 121 },
                    { 825, 138, "1", 127 },
                    { 826, 138, "2", 125 },
                    { 827, 138, "3", 158 },
                    { 828, 138, "8", 122 },
                    { 829, 138, "16", 161 },
                    { 591, 101, "3", 105 },
                    { 590, 101, "0", 107 },
                    { 589, 100, "7", 142 },
                    { 588, 100, "6", 144 },
                    { 263, 36, "6", 134 },
                    { 264, 36, "7", 131 },
                    { 316, 45, "0", 121 },
                    { 317, 45, "1", 127 },
                    { 318, 45, "2", 125 },
                    { 319, 45, "3", 158 },
                    { 320, 45, "5", 129 },
                    { 321, 45, "6", 123 },
                    { 322, 45, "7", 126 },
                    { 323, 45, "8", 122 },
                    { 324, 46, "0", 107 },
                    { 262, 36, "5", 170 },
                    { 325, 46, "1", 109 },
                    { 327, 46, "3", 105 },
                    { 328, 46, "4", 111 },
                    { 329, 46, "5", 104 },
                    { 330, 46, "6", 80 },
                    { 331, 46, "7", 171 },
                    { 332, 46, "8", 106 },
                    { 333, 47, "0", 143 },
                    { 334, 47, "3", 140 },
                    { 335, 47, "4", 146 },
                    { 336, 47, "6", 144 },
                    { 337, 47, "7", 142 },
                    { 326, 46, "2", 169 },
                    { 261, 36, "4", 160 },
                    { 260, 36, "3", 136 },
                    { 259, 36, "2", 130 },
                    { 171, 24, "8", 132 },
                    { 235, 33, "0", 107 },
                    { 236, 33, "1", 109 },
                    { 237, 33, "2", 169 },
                    { 238, 33, "3", 105 },
                    { 239, 33, "4", 111 },
                    { 240, 33, "5", 104 },
                    { 241, 33, "6", 80 },
                    { 242, 33, "8", 106 },
                    { 243, 34, "0", 143 },
                    { 244, 34, "1", 147 },
                    { 245, 34, "3", 140 },
                    { 246, 34, "4", 146 },
                    { 247, 34, "5", 139 },
                    { 248, 34, "6", 144 },
                    { 249, 34, "7", 142 },
                    { 250, 34, "8", 141 },
                    { 251, 35, "0", 116 },
                    { 252, 35, "1", 157 },
                    { 253, 35, "3", 113 },
                    { 254, 35, "4", 115 },
                    { 255, 35, "5", 120 },
                    { 256, 35, "8", 112 },
                    { 257, 35, "9", 114 },
                    { 258, 36, "0", 135 },
                    { 338, 48, "2", 130 },
                    { 169, 24, "3", 136 },
                    { 339, 48, "4", 161 },
                    { 341, 48, "5", 170 },
                    { 414, 60, "6", 144 },
                    { 415, 60, "7", 142 },
                    { 449, 71, "3", 136 },
                    { 450, 71, "4", 161 },
                    { 451, 71, "4", 160 },
                    { 452, 71, "5", 170 },
                    { 453, 71, "6", 134 },
                    { 454, 71, "7", 131 },
                    { 455, 71, "8", 132 },
                    { 456, 72, "0", 143 },
                    { 457, 72, "1", 147 },
                    { 413, 60, "5", 139 },
                    { 458, 72, "3", 140 },
                    { 460, 72, "5", 139 },
                    { 461, 72, "8", 141 },
                    { 579, 99, "1", 157 },
                    { 580, 99, "2", 117 },
                    { 581, 99, "3", 113 },
                    { 582, 99, "5", 120 },
                    { 583, 99, "8", 112 },
                    { 584, 99, "9", 114 },
                    { 585, 100, "00", 116 },
                    { 586, 100, "0", 143 },
                    { 587, 100, "4", 146 },
                    { 459, 72, "4", 146 },
                    { 412, 60, "4", 146 },
                    { 411, 60, "3", 140 },
                    { 410, 60, "0", 143 },
                    { 342, 48, "6", 134 },
                    { 343, 48, "7", 131 },
                    { 344, 48, "8", 132 },
                    { 388, 57, "0", 107 },
                    { 389, 57, "3", 105 },
                    { 390, 57, "4", 111 },
                    { 391, 57, "5", 104 },
                    { 392, 57, "6", 80 },
                    { 393, 57, "7", 171 },
                    { 394, 57, "8", 106 },
                    { 395, 58, "0", 116 },
                    { 396, 58, "1", 157 },
                    { 397, 58, "2", 117 },
                    { 398, 58, "3", 113 },
                    { 399, 58, "5", 120 },
                    { 400, 58, "8", 112 },
                    { 401, 58, "9", 114 },
                    { 402, 59, "0", 121 },
                    { 403, 59, "1", 127 },
                    { 404, 59, "2", 125 },
                    { 405, 59, "3", 158 },
                    { 406, 59, "5", 129 },
                    { 407, 59, "6", 123 },
                    { 408, 59, "7", 126 },
                    { 409, 59, "8", 122 },
                    { 340, 48, "4", 160 },
                    { 444, 68, "1", 79 },
                    { 443, 68, "0", 83 },
                    { 442, 67, "7", 68 },
                    { 464, 73, "2", 28 },
                    { 465, 73, "7", 25 },
                    { 466, 73, "8", 26 },
                    { 467, 74, "0", 7 },
                    { 468, 74, "2", 1 },
                    { 469, 74, "3", 3 },
                    { 470, 74, "4", 2 },
                    { 471, 74, "5", 5 },
                    { 472, 74, "7", 164 },
                    { 473, 74, "10", 52 },
                    { 474, 75, "0", 149 },
                    { 463, 73, "1", 20 },
                    { 475, 75, "1", 14 },
                    { 477, 75, "3", 12 },
                    { 478, 75, "5", 18 },
                    { 479, 75, "9", 15 },
                    { 480, 75, "10", 16 },
                    { 481, 75, "11", 19 },
                    { 482, 76, "00", 31 },
                    { 483, 76, "0", 32 },
                    { 484, 76, "1", 35 },
                    { 485, 76, "3", 37 },
                    { 486, 76, "8", 30 },
                    { 487, 76, "9", 33 },
                    { 476, 75, "2", 17 },
                    { 488, 76, "10", 36 },
                    { 462, 73, "0", 22 },
                    { 436, 64, "7", 4 },
                    { 353, 50, "0", 46 },
                    { 354, 50, "3", 167 },
                    { 355, 50, "5", 40 },
                    { 356, 50, "10", 45 },
                    { 416, 61, "00", 31 },
                    { 417, 61, "0", 32 },
                    { 418, 61, "1", 35 },
                    { 419, 61, "7", 29 },
                    { 420, 61, "8", 30 },
                    { 421, 61, "10", 36 },
                    { 422, 62, "0", 46 },
                    { 437, 64, "8", 151 },
                    { 423, 62, "2", 166 },
                    { 425, 62, "5", 40 },
                    { 426, 62, "6", 165 },
                    { 427, 63, "0", 7 },
                    { 428, 63, "1", 6 },
                    { 429, 63, "2", 1 },
                    { 430, 63, "3", 3 },
                    { 431, 63, "5", 5 },
                    { 432, 63, "6", 8 },
                    { 433, 63, "7", 164 },
                    { 434, 64, "2", 49 },
                    { 435, 64, "5", 153 },
                    { 424, 62, "3", 167 },
                    { 533, 89, "0", 48 },
                    { 534, 89, "2", 49 },
                    { 535, 89, "5", 153 },
                    { 611, 106, "9", 15 },
                    { 612, 106, "11", 19 },
                    { 613, 107, "0", 46 },
                    { 614, 107, "2", 166 },
                    { 615, 107, "3", 167 },
                    { 616, 107, "5", 40 },
                    { 617, 107, "6", 165 },
                    { 618, 107, "7", 168 },
                    { 619, 107, "11", 150 },
                    { 620, 108, "0", 22 },
                    { 621, 108, "1", 20 },
                    { 610, 106, "5", 18 },
                    { 622, 108, "2", 28 }
                });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "GamePlayer_xref",
                columns: new[] { "Id", "GameTeamId", "JerseyNumber", "PlayerId" },
                values: new object[,]
                {
                    { 624, 108, "6", 27 },
                    { 625, 108, "7", 25 },
                    { 626, 108, "10", 23 },
                    { 685, 117, "0", 22 },
                    { 686, 117, "1", 20 },
                    { 687, 117, "6", 27 },
                    { 688, 117, "7", 25 },
                    { 689, 117, "10", 23 },
                    { 690, 118, "0", 48 },
                    { 691, 118, "2", 49 },
                    { 692, 118, "3", 9 },
                    { 623, 108, "3", 21 },
                    { 609, 106, "3", 12 },
                    { 608, 106, "1", 14 },
                    { 607, 106, "0", 149 },
                    { 536, 89, "6", 47 },
                    { 537, 89, "7", 52 },
                    { 538, 90, "0", 149 },
                    { 539, 90, "1", 17 },
                    { 540, 90, "2", 14 },
                    { 541, 90, "9", 15 },
                    { 542, 90, "10", 16 },
                    { 543, 90, "11", 19 },
                    { 544, 91, "0", 46 },
                    { 545, 91, "2", 166 },
                    { 546, 91, "3", 167 },
                    { 547, 91, "5", 40 },
                    { 548, 91, "6", 165 },
                    { 549, 91, "11", 150 },
                    { 550, 92, "00", 31 },
                    { 551, 92, "0", 32 },
                    { 552, 92, "8", 30 },
                    { 553, 92, "9", 33 },
                    { 554, 92, "10", 36 },
                    { 601, 105, "0", 48 },
                    { 602, 105, "2", 49 },
                    { 603, 105, "5", 153 },
                    { 604, 105, "6", 47 },
                    { 605, 105, "7", 52 },
                    { 606, 105, "8", 151 },
                    { 352, 49, "11", 19 },
                    { 351, 49, "10", 16 },
                    { 350, 49, "9", 15 },
                    { 349, 49, "5", 18 },
                    { 94, 14, "3", 9 },
                    { 95, 14, "5", 153 },
                    { 96, 14, "6", 47 },
                    { 97, 14, "7", 52 },
                    { 98, 14, "8", 151 },
                    { 99, 15, "0", 7 },
                    { 100, 15, "1", 6 },
                    { 101, 15, "2", 1 },
                    { 102, 15, "3", 3 },
                    { 103, 15, "4", 2 },
                    { 104, 15, "6", 8 },
                    { 93, 14, "2", 49 },
                    { 105, 15, "9", 10 },
                    { 107, 16, "1", 20 },
                    { 108, 16, "2", 28 },
                    { 109, 16, "6", 27 },
                    { 110, 16, "7", 25 },
                    { 111, 16, "8", 26 },
                    { 112, 16, "9", 24 },
                    { 113, 16, "10", 23 },
                    { 172, 25, "0", 7 },
                    { 173, 25, "1", 6 },
                    { 174, 25, "2", 1 },
                    { 175, 25, "3", 3 },
                    { 106, 16, "0", 22 },
                    { 92, 14, "0", 48 },
                    { 91, 13, "10", 45 },
                    { 90, 13, "6", 165 },
                    { 2, 1, "1", 6 },
                    { 3, 1, "2", 1 },
                    { 4, 1, "3", 3 },
                    { 5, 1, "4", 2 },
                    { 6, 1, "6", 8 },
                    { 7, 1, "9", 10 },
                    { 8, 1, "10", 4 },
                    { 10, 2, "2", 17 },
                    { 11, 2, "3", 12 },
                    { 14, 2, "9", 15 },
                    { 15, 2, "10", 16 },
                    { 17, 3, "0", 22 },
                    { 18, 3, "1", 20 },
                    { 19, 3, "2", 28 },
                    { 20, 3, "6", 27 },
                    { 21, 3, "7", 25 },
                    { 22, 3, "8", 26 },
                    { 23, 3, "9", 24 },
                    { 24, 3, "10", 23 },
                    { 25, 4, "3", 37 },
                    { 26, 4, "7", 29 },
                    { 27, 4, "8", 30 },
                    { 28, 4, "10", 36 },
                    { 88, 13, "0", 46 },
                    { 89, 13, "5", 40 },
                    { 176, 25, "4", 2 },
                    { 693, 118, "5", 153 },
                    { 177, 25, "6", 8 },
                    { 179, 25, "9", 10 },
                    { 270, 38, "1", 14 },
                    { 271, 38, "3", 12 },
                    { 272, 38, "5", 18 },
                    { 273, 38, "9", 15 },
                    { 274, 38, "10", 16 },
                    { 275, 38, "11", 19 },
                    { 276, 39, "0", 7 },
                    { 277, 39, "2", 1 },
                    { 278, 39, "3", 3 },
                    { 279, 39, "5", 5 },
                    { 280, 39, "7", 164 },
                    { 269, 38, "0", 149 },
                    { 281, 39, "10", 4 },
                    { 283, 40, "1", 20 },
                    { 284, 40, "2", 28 },
                    { 285, 40, "6", 27 },
                    { 286, 40, "7", 25 },
                    { 287, 40, "8", 26 },
                    { 288, 40, "9", 24 },
                    { 289, 40, "10", 23 },
                    { 345, 49, "0", 149 },
                    { 346, 49, "1", 14 },
                    { 347, 49, "2", 17 },
                    { 348, 49, "3", 12 },
                    { 282, 40, "0", 22 },
                    { 268, 37, "10", 36 },
                    { 267, 37, "8", 30 },
                    { 266, 37, "7", 29 },
                    { 180, 25, "10", 4 },
                    { 181, 26, "0", 46 },
                    { 182, 26, "2", 166 },
                    { 183, 26, "3", 167 },
                    { 184, 26, "5", 40 },
                    { 185, 26, "6", 165 },
                    { 186, 26, "7", 168 },
                    { 187, 26, "10", 45 },
                    { 188, 27, "0", 22 },
                    { 189, 27, "1", 20 },
                    { 190, 27, "2", 28 },
                    { 191, 27, "6", 27 },
                    { 192, 27, "7", 25 },
                    { 193, 27, "8", 26 },
                    { 194, 27, "9", 24 },
                    { 195, 27, "10", 23 },
                    { 196, 28, "0", 48 },
                    { 197, 28, "2", 49 },
                    { 198, 28, "3", 9 },
                    { 199, 28, "4", 53 },
                    { 200, 28, "5", 153 },
                    { 201, 28, "6", 47 },
                    { 202, 28, "7", 52 },
                    { 203, 28, "8", 151 },
                    { 265, 37, "3", 37 },
                    { 178, 25, "7", 164 },
                    { 694, 118, "6", 47 },
                    { 695, 118, "7", 52 },
                    { 696, 118, "8", 151 },
                    { 215, 30, "8", 61 },
                    { 216, 30, "9", 64 },
                    { 217, 31, "0", 72 },
                    { 218, 31, "1", 67 },
                    { 219, 31, "2", 66 },
                    { 220, 31, "3", 73 },
                    { 221, 31, "4", 71 },
                    { 222, 31, "5", 65 },
                    { 223, 31, "7", 68 },
                    { 224, 31, "8", 70 },
                    { 225, 31, "9", 74 },
                    { 214, 30, "7", 62 },
                    { 226, 32, "0", 100 },
                    { 228, 32, "2", 101 },
                    { 229, 32, "3", 102 },
                    { 230, 32, "4", 96 },
                    { 231, 32, "5", 162 },
                    { 232, 32, "6", 94 },
                    { 233, 32, "7", 98 },
                    { 234, 32, "8", 97 },
                    { 290, 41, "0", 59 },
                    { 291, 41, "2", 57 },
                    { 292, 41, "3", 58 },
                    { 293, 41, "7", 62 },
                    { 227, 32, "1", 99 },
                    { 213, 30, "5", 60 },
                    { 212, 30, "3", 58 },
                    { 211, 30, "2", 57 },
                    { 123, 18, "6", 94 },
                    { 124, 18, "7", 98 },
                    { 125, 19, "0", 72 },
                    { 126, 19, "1", 67 },
                    { 127, 19, "2", 66 },
                    { 128, 19, "3", 73 },
                    { 129, 19, "5", 65 },
                    { 130, 19, "7", 68 },
                    { 131, 19, "7", 70 },
                    { 132, 19, "9", 74 },
                    { 133, 20, "0", 88 },
                    { 134, 20, "2", 85 },
                    { 135, 20, "4", 90 },
                    { 136, 20, "5", 86 },
                    { 137, 20, "7", 93 },
                    { 138, 20, "8", 84 },
                    { 139, 20, "9", 91 },
                    { 140, 20, "9", 156 },
                    { 204, 29, "0", 83 },
                    { 205, 29, "1", 79 },
                    { 206, 29, "2", 77 },
                    { 207, 29, "3", 76 },
                    { 208, 29, "5", 155 },
                    { 209, 30, "0", 59 },
                    { 210, 30, "1", 56 },
                    { 294, 41, "9", 64 },
                    { 122, 18, "4", 96 },
                    { 295, 42, "0", 88 },
                    { 297, 42, "3", 87 },
                    { 368, 54, "1", 86 },
                    { 369, 54, "3", 76 },
                    { 370, 54, "5", 155 },
                    { 371, 54, "6", 75 },
                    { 372, 55, "2", 66 },
                    { 373, 55, "3", 73 },
                    { 374, 55, "4", 71 },
                    { 375, 55, "5", 65 },
                    { 376, 55, "7", 68 },
                    { 377, 55, "8", 70 },
                    { 378, 55, "9", 74 },
                    { 367, 54, "1", 79 },
                    { 379, 56, "0", 100 },
                    { 381, 56, "3", 102 },
                    { 382, 56, "4", 96 },
                    { 383, 56, "5", 162 },
                    { 384, 56, "6", 94 },
                    { 385, 56, "7", 98 },
                    { 386, 56, "8", 97 },
                    { 387, 56, "12", 95 },
                    { 438, 67, "1", 67 },
                    { 439, 67, "3", 73 },
                    { 440, 67, "5", 65 },
                    { 441, 67, "6", 69 },
                    { 380, 56, "1", 99 },
                    { 366, 54, "0", 83 },
                    { 365, 53, "9", 91 },
                    { 364, 53, "8", 84 },
                    { 298, 42, "4", 90 },
                    { 299, 42, "5", 86 },
                    { 300, 42, "6", 156 },
                    { 301, 42, "7", 93 },
                    { 302, 42, "8", 84 },
                    { 303, 42, "9", 91 },
                    { 304, 43, "0", 100 },
                    { 305, 43, "1", 99 },
                    { 306, 43, "4", 96 },
                    { 307, 43, "6", 94 },
                    { 308, 43, "7", 98 },
                    { 309, 43, "8", 97 },
                    { 310, 44, "0", 83 },
                    { 311, 44, "1", 79 },
                    { 312, 44, "1", 78 },
                    { 313, 44, "2", 77 },
                    { 314, 44, "5", 155 },
                    { 315, 44, "6", 75 },
                    { 357, 53, "0", 88 },
                    { 358, 53, "2", 85 },
                    { 359, 53, "3", 87 },
                    { 360, 53, "4", 90 },
                    { 361, 53, "5", 86 },
                    { 362, 53, "6", 156 },
                    { 363, 53, "7", 93 },
                    { 296, 42, "2", 85 },
                    { 912, 150, "8", 106 },
                    { 121, 18, "3", 102 },
                    { 119, 18, "0", 100 },
                    { 727, 123, "5", 5 },
                    { 728, 123, "6", 8 },
                    { 729, 123, "7", 164 },
                    { 730, 123, "9", 10 },
                    { 731, 124, "00", 31 },
                    { 732, 124, "0", 32 },
                    { 733, 124, "1", 37 },
                    { 734, 124, "7", 29 },
                    { 735, 124, "8", 30 },
                    { 736, 124, "9", 33 },
                    { 737, 124, "10", 36 },
                    { 726, 123, "4", 2 },
                    { 766, 129, "0", 46 },
                    { 768, 129, "3", 167 },
                    { 769, 129, "5", 40 },
                    { 770, 129, "6", 165 },
                    { 771, 129, "7", 168 },
                    { 772, 129, "7", 150 },
                    { 773, 130, "0", 149 },
                    { 774, 130, "1", 14 },
                    { 775, 130, "3", 12 },
                    { 776, 130, "5", 18 },
                    { 777, 130, "9", 15 },
                    { 778, 130, "10", 16 },
                    { 767, 129, "2", 166 },
                    { 725, 123, "3", 3 },
                    { 724, 123, "2", 1 },
                    { 723, 123, "0", 7 },
                    { 697, 119, "2", 1 },
                    { 698, 119, "3", 3 },
                    { 699, 119, "4", 2 },
                    { 700, 119, "5", 5 },
                    { 701, 119, "6", 8 },
                    { 702, 119, "7", 164 },
                    { 703, 119, "10", 4 },
                    { 704, 120, "0", 136 },
                    { 705, 120, "1", 14 },
                    { 706, 120, "3", 12 },
                    { 707, 120, "5", 18 },
                    { 708, 120, "9", 15 },
                    { 709, 120, "10", 16 },
                    { 710, 120, "11", 19 },
                    { 712, 121, "0", 46 },
                    { 713, 121, "2", 166 },
                    { 714, 121, "3", 167 },
                    { 715, 121, "5", 40 },
                    { 716, 121, "6", 165 },
                    { 717, 121, "7", 168 },
                    { 718, 122, "0", 48 },
                    { 719, 122, "2", 49 },
                    { 720, 122, "6", 47 },
                    { 721, 122, "7", 52 },
                    { 722, 122, "8", 151 },
                    { 779, 130, "11", 19 },
                    { 120, 18, "1", 99 },
                    { 780, 131, "0", 22 },
                    { 782, 131, "8", 26 },
                    { 38, 6, "1", 79 },
                    { 39, 6, "2", 77 },
                    { 40, 6, "3", 76 },
                    { 41, 6, "5", 155 },
                    { 42, 6, "6", 75 },
                    { 43, 6, "8", 82 },
                    { 44, 7, "0", 100 },
                    { 45, 7, "1", 99 },
                    { 46, 7, "2", 101 },
                    { 47, 7, "3", 102 },
                    { 48, 7, "4", 96 },
                    { 37, 6, "0", 83 },
                    { 49, 7, "5", 162 },
                    { 51, 7, "7", 98 },
                    { 52, 7, "8", 97 },
                    { 53, 8, "0", 88 },
                    { 54, 8, "4", 90 },
                    { 55, 8, "7", 93 },
                    { 56, 8, "8", 84 },
                    { 114, 17, "0", 59 },
                    { 115, 17, "1", 56 },
                    { 116, 17, "3", 58 },
                    { 117, 17, "7", 62 },
                    { 118, 17, "8", 61 },
                    { 50, 7, "6", 94 },
                    { 36, 5, "9", 74 },
                    { 35, 5, "7", 70 },
                    { 34, 5, "7", 68 },
                    { 783, 131, "9", 24 },
                    { 784, 132, "00", 31 },
                    { 785, 132, "0", 32 },
                    { 786, 132, "1", 35 },
                    { 787, 132, "3", 37 },
                    { 788, 132, "7", 29 },
                    { 789, 132, "8", 30 },
                    { 790, 132, "10", 36 },
                    { 873, 145, "2", 49 },
                    { 874, 145, "4", 53 },
                    { 875, 145, "5", 153 },
                    { 876, 145, "6", 47 },
                    { 877, 145, "7", 52 },
                    { 878, 145, "8", 151 },
                    { 879, 146, "0", 46 },
                    { 880, 146, "2", 166 },
                    { 881, 146, "3", 167 },
                    { 882, 146, "5", 40 },
                    { 883, 146, "6", 165 },
                    { 884, 146, "7", 150 },
                    { 29, 5, "0", 72 },
                    { 30, 5, "1", 67 },
                    { 31, 5, "2", 66 },
                    { 32, 5, "4", 71 },
                    { 33, 5, "5", 65 },
                    { 781, 131, "7", 25 },
                    { 913, 150, "14", 131 }
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Auth",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_RoleId",
                schema: "Auth",
                table: "RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Auth",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Auth",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                schema: "Auth",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                schema: "Auth",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                schema: "Auth",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_LeagueSeasonId",
                schema: "Common",
                table: "Game",
                column: "LeagueSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_LocationId",
                schema: "Common",
                table: "Game",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_xref_GameTeamId",
                schema: "Common",
                table: "GamePlayer_xref",
                column: "GameTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_xref_PlayerId",
                schema: "Common",
                table: "GamePlayer_xref",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTeam_xref_GameId",
                schema: "Common",
                table: "GameTeam_xref",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTeam_xref_GameResultTypeId",
                schema: "Common",
                table: "GameTeam_xref",
                column: "GameResultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTeam_xref_TeamId",
                schema: "Common",
                table: "GameTeam_xref",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_League_SportId",
                schema: "Common",
                table: "League",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueSeason_xref_LeagueId",
                schema: "Common",
                table: "LeagueSeason_xref",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueSeason_xref_SeasonId",
                schema: "Common",
                table: "LeagueSeason_xref",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationTypeId",
                schema: "Common",
                table: "Location",
                column: "LocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ContactId",
                schema: "Common",
                table: "Player",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLeagueSeason_xref_JerseySizeId",
                schema: "Common",
                table: "PlayerLeagueSeason_xref",
                column: "JerseySizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLeagueSeason_xref_LeagueSeasonId",
                schema: "Common",
                table: "PlayerLeagueSeason_xref",
                column: "LeagueSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLeagueSeason_xref_PlayerId",
                schema: "Common",
                table: "PlayerLeagueSeason_xref",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLeagueSeason_xref_SeasonId",
                schema: "Common",
                table: "PlayerLeagueSeason_xref",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorSeason_xref_SeasonId",
                schema: "Common",
                table: "SponsorSeason_xref",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorSeason_xref_SponsorId",
                schema: "Common",
                table: "SponsorSeason_xref",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorSeason_xref_SponsorshipLevelId",
                schema: "Common",
                table: "SponsorSeason_xref",
                column: "SponsorshipLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Stat_GamePlayerId",
                schema: "Common",
                table: "Stat",
                column: "GamePlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stat_StatCategoryId",
                schema: "Common",
                table: "Stat",
                column: "StatCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamLeagueSeason_xref_CoachId",
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamLeagueSeason_xref_ColorId",
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamLeagueSeason_xref_LeagueSeasonId",
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                column: "LeagueSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamLeagueSeason_xref_SponsorSeasonId",
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                column: "SponsorSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamLeagueSeason_xref_TeamId",
                schema: "Common",
                table: "TeamLeagueSeason_xref",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStat_GameTeamId",
                schema: "Common",
                table: "TeamStat",
                column: "GameTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStat_StatCategoryId",
                schema: "Common",
                table: "TeamStat",
                column: "StatCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaim",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserClaim",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserLogin",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "UserToken",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Draft",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "DraftPick",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "PlayerLeagueSeason_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Stat",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "TeamLeagueSeason_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "TeamStat",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "Size",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "GamePlayer_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Color",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "SponsorSeason_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "StatCategory",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "GameTeam_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Player",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Sponsor",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "SponsorshipLevel",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Game",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "GameResultType",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Team",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Auth");

            migrationBuilder.DropTable(
                name: "LeagueSeason_xref",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "League",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Season",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "LocationType",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Sport",
                schema: "Lookup");
        }
    }
}
