using Tff.ConsoleUI.Service;
TeamService teamService = new TeamService();

var teams = teamService.GetAll();

foreach (var team in teams.Data)
{
    Console.WriteLine(team);
}

Console.WriteLine(teamService.GetById(2));