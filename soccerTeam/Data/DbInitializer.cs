using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using soccerTeam.Models;

namespace soccerTeam.Data {
    public static class DbInitializer{
        public static void Initializate(soccerTeamContext context){
            context.Database.EnsureCreated();

            if(context.Teams.Any()){
                return;
            }

            // Teams
            var Teams = new Teams[] {
                new Teams {TeamName="Guerreros del balon"},
                new Teams {TeamName="Gladiadores"},
                new Teams {TeamName="Los de la esquina"},
                new Teams {TeamName="Los campeones"},
                new Teams {TeamName="Espartanos"},
                new Teams {TeamName="Vikingos"},
                new Teams {TeamName="Luchadores"},
            };
            foreach(Teams t in Teams) {
                context.Teams.Add(t);
            }
            context.SaveChanges();

           
            // Positions
            var Positions = new Positions[] {
                new Positions {PositionDesc="Portero"},
                new Positions {PositionDesc="Delantero"},
                new Positions {PositionDesc="Defenza"},
                new Positions {PositionDesc="Medio lateral"},
            };
            foreach(Positions p in Positions) {
                context.Positions.Add(p);
            }
            context.SaveChanges();


            // Competitions
            var Competitions = new Competitions[] {
                new Competitions {CompetitionName="Copa del Barrio"},
                new Competitions {CompetitionName="Liga regional"},
                new Competitions {CompetitionName="Copa FIFA"},
                new Competitions {CompetitionName="Mundial de barrios"},
            };
            foreach(Competitions c in Competitions) {
                context.Competitions.Add(c);
            }
            context.SaveChanges();


            // PlayerFixtures
            var PlayerFixtures = new PlayerFixtures[] {
                new PlayerFixtures { GoalsScored=1},
                new PlayerFixtures { GoalsScored=2},
                new PlayerFixtures { GoalsScored=3},
                new PlayerFixtures { GoalsScored=4},
                new PlayerFixtures { GoalsScored=5},
            };
            foreach(PlayerFixtures pf in PlayerFixtures) {
                context.PlayerFixtures.Add(pf);
            }
            context.SaveChanges();

            //Players
            var Players = new Players[]{
                new Players{ TeamID = 1, PlayerName="Roberto Robles", PlayerSquadNumber=9, PositionID=1},
                new Players{ TeamID = 2, PlayerName="Luis Lopez", PlayerSquadNumber=8, PositionID=3},
                new Players{ TeamID = 3, PlayerName="Carlos Contreras", PlayerSquadNumber=8, PositionID=2},
                new Players{ TeamID = 4, PlayerName="Francisco Reyes", PlayerSquadNumber=10, PositionID=3},
                new Players{ TeamID = 5, PlayerName="Martin Flores", PlayerSquadNumber=11, PositionID=3},
                new Players{ TeamID = 6, PlayerName="Eduardo Rivas", PlayerSquadNumber=9, PositionID=2},
                new Players{ TeamID = 7, PlayerName="Fernando Rodriguez", PlayerSquadNumber=10, PositionID=2},
            };
            foreach(Players p in Players){
                context.Players.Add(p);
            }
            context.SaveChanges();


            // Fixtures
            var Fixtures = new Fixtures[] {
                new Fixtures{ FixtureDate="11/9/2019", FixtureTime="9:30 AM", HomeTeamID=1, AwayTeamID=4, CompetitionID=2},
                new Fixtures{ FixtureDate="15/11/2019", FixtureTime="10:30 AM", HomeTeamID=3, AwayTeamID=5, CompetitionID=2},
                new Fixtures{ FixtureDate="20/12/2019", FixtureTime="14:30 AM", HomeTeamID=6, AwayTeamID=7, CompetitionID=4},
            };
            foreach(Fixtures f in Fixtures) {
                context.Fixtures.Add(f);
            }
            context.SaveChanges();

        }
    }
}