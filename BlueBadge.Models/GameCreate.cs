using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{//enum is not done yet.
   


    public class GameCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "There must be a minimum of two characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters")]
        public string GameTitle { get; set; }
        [Required]
        public string GameConsole { get; set; }
        public DateTime ReleaseYear { get; set; }



    }
}
