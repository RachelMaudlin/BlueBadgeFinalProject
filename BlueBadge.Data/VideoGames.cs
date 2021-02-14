using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    class VideoGames
    {
      

        [Key]
        public int GameId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage ="There must be a minimum of two characters.")]
        [MaxLength(50, ErrorMessage ="There are too many characters")]
        public string GameName { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage ="Please choose a rating between 1 and 5.")]
        public decimal StarRating { get; set; }
        [Required]
        public DataType ReleaseYear { get; set; }

    }
}
