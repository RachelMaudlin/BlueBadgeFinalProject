using BlueBadge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class GameDetails
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public TypeOfGenre GenreType { get; set; }
        public GameConsole Console { get; set; }
        public DateTime ReleaseYear { get; set; }
        
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
