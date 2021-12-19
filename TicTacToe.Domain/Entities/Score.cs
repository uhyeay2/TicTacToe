using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain.Entities
{
    public class Score
    {
        [Key]
        int Id { get; set; }
        int PlayerOwnerId { get; set; }
        int AgainstPlayerId { get; set; }
        int WinCount { get; set; }
        int LoseCount { get; set; }
        int DrawCount { get; set; }
    }
}
