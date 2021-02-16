using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    //I do not think we would need to edit much in a vido game. The genre, the release year, ect. should never need to be updated.
    // But, I am open to suggestions...
    public class GameEdit
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public int Quantity { get; set; }

    }
}
