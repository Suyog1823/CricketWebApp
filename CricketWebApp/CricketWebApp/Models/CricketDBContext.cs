using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CricketWebApp.Models
{
    public partial class CricketDBContext : DbContext
    {

        public CricketDBContext()
        {
        }

        public CricketDBContext(DbContextOptions<CricketDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }

        // Unable to generate entity type for table 'dbo.Anything'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CricketDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.Continent)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode).HasColumnName("Country_Code");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.Property(e => e.MatchId).HasColumnName("Match_ID");

                entity.Property(e => e.DateTime)
                    .HasColumnName("Date_Time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StadiumId).HasColumnName("Stadium_ID");

                entity.Property(e => e.TeamA)
                    .HasColumnName("Team_A")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TeamB)
                    .HasColumnName("Team_B")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WasMatchPlayed)
                    .HasColumnName("Was_Match_Played")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.Property(e => e.PlayerId).HasColumnName("Player_ID");

                entity.Property(e => e.PlayerName)
                    .HasColumnName("Player_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.Property(e => e.StadiumId)
                    .HasColumnName("Stadium_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NoOfMatchesAllowed).HasColumnName("No_of_Matches_Allowed");

                entity.Property(e => e.StadiumCountry).HasColumnName("Stadium_Country");

                entity.Property(e => e.StadiumName)
                    .HasColumnName("Stadium_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
