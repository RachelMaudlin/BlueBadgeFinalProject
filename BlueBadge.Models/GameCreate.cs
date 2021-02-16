using BlueBadge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class GameCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "There must be a minimum of two characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters")]
        public string GameTitle { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }
        public TypeOfGenre GenreType { get; set; }
        public GameConsole Console { get; set; }
    }
}
