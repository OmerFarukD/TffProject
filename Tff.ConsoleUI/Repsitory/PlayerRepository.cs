using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff.ConsoleUI.Models;

namespace Tff.ConsoleUI.Repsitory
{
    public class PlayerRepository : IRepository<Player, Guid>
    {
        public Player Add(Player entity)
        {
            BaseRepository.Players.Add(entity);
            return entity;
        }

        public Player? Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetAll()
        {
            throw new NotImplementedException();
        }

        public Player? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Player? Update(Guid id, Player entity)
        {
            throw new NotImplementedException();
        }
    }
}
