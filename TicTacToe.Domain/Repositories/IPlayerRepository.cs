using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Domain.Entities;

namespace TicTacToe.Domain.Repositories
{
    interface IPlayerRepository
    {
        public Task<Player> GetPlayerByUuid(string uuid);
        public Task<Player> ChangeToken(string uuid);
        public Task<Player> AddPlayerToDatabase(Player playerToAdd);
    }
}
