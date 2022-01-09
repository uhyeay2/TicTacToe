using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Domain.Entities;

namespace TicTacToe.Domain.Repositories
{
    interface IBoardRepo
    {
        public Task<Board> AddBoardToDatabase(Board board);
        public Task<Board> GetBoardByUuid(string uuid);
        public Task DeleteBoard(string uuid);
        public Task<Board> ResetBoard(string uuid);
    }
}
