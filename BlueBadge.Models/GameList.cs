using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class GameList
    {
        //this is for when we want to see a specific vidoe game in our database
        public int GameId { get; set; }
        public string Title { get; set; }
        //datetimeoffset may need to change.
        public DateTimeOffset GameAdded { get; set; }
    }
}
