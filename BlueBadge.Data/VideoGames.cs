using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class VideoGames
    {
      

        [Key]
        public int GameId { get; set; }
        [Required]
   
        public string GameTitle { get; set; }
        [Required]

        public decimal StarRating { get; set; }
        [Required]
        public DataType ReleaseYear { get; set; }

    }
}
