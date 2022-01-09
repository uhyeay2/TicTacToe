using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Domain.Entities;

namespace TicTacToe.Domain.Repositories
{
    interface IBoardSpaceRepo
    {
        public Task AddBoardSpaces(Board board);
        public Task UpdateBoardSpace(string spaceUuid, char symbol);

    }
}
