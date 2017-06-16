using System.Linq;
using System.Collections.Generic;
using System;

namespace NbaRevolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<string>
            {
                "Atlanta Hawks",
                "Boston Celtics",
                "Brooklyn Nets",
                "Charlotte Hornets",
                "Chicago Bulls",
                "Cleveland Cavaliers",
                "Dallas Mavericks",
                "Denver Nuggets",
                "Detroit Pistons",
                "Golden State Warriors",
                "Houston Rockets",
                "Indiana Pacers",
                "Los Angeles Clippers",
                "Los Angeles Lakers",
                "Memphis Grizzlies",
                "Miami Heat",
                "Milwaukee Bucks",
                "Minnesota Timberwolves",
                "New Orleans Pelicans",
                "New York Knicks",
                "Oklahoma City Thunder",
                "Orlando Magic",
                "Philadelphia 76ers",
                "Phoenix Suns",
                "Portland Trail Blazers",
                "Sacramento Kings",
                "Washington Wizards",
                "San Antonio Spurs",
                "Toronto Raptors",
                "Utah Jazz"
            };

            var schedule = new List<String>();
            teams = teams.OrderBy(x => Guid.NewGuid()).ToList();
            int i = 1;

            foreach (var team in teams)
            {
                var opposingTeam = teams.ElementAt(teams.Count - i);

                if (team == opposingTeam)
                    break;

                i++;
                schedule.Add($"Team {team} will play {opposingTeam} at home.");
            }

            int n = 0;
            int round = 1;
            foreach (var match in schedule)
            {
                if (n % 2 == 0) Console.WriteLine($"{Environment.NewLine}Round {round}{Environment.NewLine}");
                Console.WriteLine(match);

                n++;
                round++;
            }
            Console.ReadLine();
        }
    }
}