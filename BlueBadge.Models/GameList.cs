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
        //this is for when we want to see a specific vidoe game in our database
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        //datetimeoffset may need to change.
        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset? CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
