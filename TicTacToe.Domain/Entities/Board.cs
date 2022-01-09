using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain.Entities
{
    public class Board
    {
        public int Id { get; set; }
        public int BoardSpaceId { get; set; }
        public string Uuid { get; set; }
    }
}
