﻿using System;
using System.Collections.Generic;
using System.Linq;
using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.ReturnModels;
using Tff.ConsoleUI.Repsitory;

namespace Tff.ConsoleUI.Service;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();

    public ReturnModel<List<Team>> GetAll()
    {
       List<Team> list = teamRepository.GetAll();

        return new ReturnModel<List<Team>>
        {
            Data = list,
            Success = true,
            StatusCode = System.Net.HttpStatusCode.OK,
        };
    }

    public ReturnModel<Team> GetById(int id)
    {
        try
        {
            Team team = teamRepository.GetById(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = $"Aradığınız Id ye ait takım görüntülendi: {id}",
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (Exception ex) 
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode =System.Net.HttpStatusCode.NotFound
            };
        }
      

    }
}
