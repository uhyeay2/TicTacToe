using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain.Entities
{
    public class BoardSpace
    {
        public int Id { get; set; }
        public Board Board { get; set; }
        public bool? Status { get; set; }
        public int Position { get; set; }
    }
}
