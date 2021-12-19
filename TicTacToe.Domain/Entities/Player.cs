using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        string Name { get; set; }
    }
}
