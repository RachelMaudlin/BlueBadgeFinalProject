using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class GameList
    {
        
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public short    Quantity { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }




        
    }
}
