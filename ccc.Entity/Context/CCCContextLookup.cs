using Microsoft.EntityFrameworkCore;
using ccc.Entity.DataClasses;
using System;

namespace ccc.Entity.Context
{
    public partial class CCCContext
    {
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<GameResultType> GameResultTypes { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<SponsorshipLevel> SponsorshipLevels { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<StatCategory> StatCategories { get; set; }

        public void OnModelCreating_Lookup(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.Color { Id = 1, Name = "Green" },
                    new DataClasses.Color { Id = 2, Name = "Black" },
                    new DataClasses.Color { Id = 3, Name = "Red" },
                    new DataClasses.Color { Id = 4, Name = "Blue" },
                    new DataClasses.Color { Id = 5, Name = "Yellow" },
                    new DataClasses.Color { Id = 6, Name = "Deep Sky Blue" }
                );
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.ToTable("LocationType", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.LocationType { Id = 1, Name = "Park" },
                    new DataClasses.LocationType { Id = 2, Name = "Court" }
                );
            });

            modelBuilder.Entity<GameResultType>(entity =>
            {
                entity.ToTable("GameResultType", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.GameResultType { Id = 1, Name = "Win" },
                    new DataClasses.GameResultType { Id = 2, Name = "Loss" },
                    new DataClasses.GameResultType { Id = 3, Name = "Tie" }
                );
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.ToTable("Season", "Lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasData(
                  new DataClasses.Season
                  {
                      Id = 1,
                      Name = "2019",
                      IsActive = true,
                      StartDate = new DateTime(2019, 6, 16),
                      EndDate = new DateTime(2020, 8, 3)
                  },
                  new DataClasses.Season
                  {
                      Id = 2,
                      Name = "2020",
                      IsActive = true,
                      StartDate = new DateTime(2020, 6, 16),
                      EndDate = new DateTime(2020, 8, 3)
                  }
                );
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.Size { Id = 1, Name = "Child S" },
                    new DataClasses.Size { Id = 2, Name = "Child M" },
                    new DataClasses.Size { Id = 3, Name = "Child L" },
                    new DataClasses.Size { Id = 4, Name = "Child XL" },
                    new DataClasses.Size { Id = 5, Name = "Adult S" },
                    new DataClasses.Size { Id = 6, Name = "Adult M" },
                    new DataClasses.Size { Id = 7, Name = "Adult L" },
                    new DataClasses.Size { Id = 8, Name = "Adult XL" }
                );
            });

            modelBuilder.Entity<SponsorshipLevel>(entity =>
            {
                entity.ToTable("SponsorshipLevel", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.Color { Id = 1, Name = "Black Level" },
                    new DataClasses.Color { Id = 2, Name = "Green Level" },
                    new DataClasses.Color { Id = 3, Name = "White Level" }
                );
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.ToTable("Sport", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new DataClasses.Color { Id = 1, Name = "Basketball" }
                );
            });

            modelBuilder.Entity<StatCategory>(entity =>
            {
                entity.ToTable("StatCategory", "Lookup");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Label).HasMaxLength(100);

                entity.HasData(
                  new DataClasses.StatCategory { Id = 1, Name = "PTS", Label = "Points" },
                  new DataClasses.StatCategory { Id = 2, Name = "REB", Label = "Rebounds" },
                  new DataClasses.StatCategory { Id = 3, Name = "AST", Label = "Assists" },
                  new DataClasses.StatCategory { Id = 4, Name = "BLK", Label = "Blocks" },
                  new DataClasses.StatCategory { Id = 5, Name = "STL", Label = "Steals" },
                  new DataClasses.StatCategory { Id = 6, Name = "PF", Label = "Personal Fouls" }
                );
            });
        }
    }
}
