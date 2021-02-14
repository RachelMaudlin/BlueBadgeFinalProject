using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{//enum is not done yet.
    public enum GameConsole
    {
        Playstation1=1,
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


    }
    public class GameCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "There must be a minimum of two characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters")]
        public string GameTitle { get; set; }
        public string GameConsole { get; set; }
       
        
       
    }
}
