using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Repsitory;
using Tff.ConsoleUI.Service;
TeamService teamService = new TeamService();

var teams = teamService.GetAll();

var takim = new Team
{
    Id = 200,
    Name = "FenerBahçe",
    Since = new DateTime(1907, 5, 3)
};


BaseRepository.Players.ForEach(p=> Console.WriteLine(p));

//Console.WriteLine(teamService.Update(4,takim));

