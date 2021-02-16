using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{

    //can not figure out how to use this enum. We may need to use a list instead.
  /* public enum GameConsole
    {
        Playstation1 = 1,
        Playstation2,
        Playstation3,
        Playstation4,
        Playstation5,
        Nintindo,
        SuperNintindo,
        NintindoDS,
        Xbox,
        Xbox369,
        Sega,
        Atari,
        SegaDreamcast,
        Gameboy,
        N64,
        GameCube,
    }*/


    public class VideoGames
    {


        [Key]
        public int GameId { get; set; }
        [Required]
   
        public string GameTitle { get; set; }
        [Required]
        public string GameConsole { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
