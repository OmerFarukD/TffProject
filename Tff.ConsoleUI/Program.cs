using Tff.ConsoleUI.Repsitory;
using Tff.ConsoleUI.Service;

Console.WriteLine("Hello, World!");
TeamService teamService = new TeamService();

Console.WriteLine(teamService.GetById(300));
