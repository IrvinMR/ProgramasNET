﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using soccerTeam.Data;

namespace soccerTeam.Migrations
{
    [DbContext(typeof(soccerTeamContext))]
    [Migration("20191203044844_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("soccerTeam.Models.Competitions", b =>
                {
                    b.Property<int>("CompetitionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompetitionName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int?>("CompetitionsCompetitionID");

                    b.HasKey("CompetitionID");

                    b.HasIndex("CompetitionsCompetitionID");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("soccerTeam.Models.Fixtures", b =>
                {
                    b.Property<int>("FixtureID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AwayTeamID");

                    b.Property<int>("CompetitionID");

                    b.Property<string>("FixtureDate");

                    b.Property<string>("FixtureTime");

                    b.Property<int>("HomeTeamID");

                    b.HasKey("FixtureID");

                    b.HasIndex("CompetitionID");

                    b.ToTable("Fixtures");
                });

            modelBuilder.Entity("soccerTeam.Models.PlayerFixtures", b =>
                {
                    b.Property<int>("FixtureID");

                    b.Property<int>("PlayerID");

                    b.Property<int?>("FixtureID1");

                    b.Property<int>("GoalsScored");

                    b.HasKey("FixtureID", "PlayerID");

                    b.HasAlternateKey("FixtureID");

                    b.HasIndex("FixtureID1");

                    b.HasIndex("PlayerID");

                    b.ToTable("PlayerFixtures");
                });

            modelBuilder.Entity("soccerTeam.Models.Players", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("PlayerSquadNumber");

                    b.Property<int>("PositionID");

                    b.Property<int>("TeamID");

                    b.HasKey("PlayerID");

                    b.HasIndex("PositionID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("soccerTeam.Models.Positions", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PositionDesc");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("soccerTeam.Models.Teams", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("soccerTeam.Models.Competitions", b =>
                {
                    b.HasOne("soccerTeam.Models.Competitions")
                        .WithMany("Competition")
                        .HasForeignKey("CompetitionsCompetitionID");
                });

            modelBuilder.Entity("soccerTeam.Models.Fixtures", b =>
                {
                    b.HasOne("soccerTeam.Models.Competitions", "Competitions")
                        .WithMany()
                        .HasForeignKey("CompetitionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("soccerTeam.Models.PlayerFixtures", b =>
                {
                    b.HasOne("soccerTeam.Models.Fixtures", "Fixture")
                        .WithMany("PlayerFixtures")
                        .HasForeignKey("FixtureID1");

                    b.HasOne("soccerTeam.Models.Players", "Player")
                        .WithMany("PlayerFixtures")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("soccerTeam.Models.Players", b =>
                {
                    b.HasOne("soccerTeam.Models.Positions", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("soccerTeam.Models.Teams", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
