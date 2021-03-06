using BlueBadge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class GameEdit
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public GameConsole Console { get; set; }
        public TypeOfGenre GenreType { get; set; }
        [Required]
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ReleaseYear { get; set; }
    }
}
