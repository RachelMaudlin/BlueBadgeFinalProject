using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public enum TypeOfGenre
    {
        Fighting,
        Adventure,
        Servival,
        Retro,
        Shooting,
        RPG,
        Puzzle,
        Sports,
        Simulation,
        Action,
        Stratagy
    }
    public enum GameConsole
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
        GameCube
    }
    public class VideoGames
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string GameTitle { get; set; }
        public GameConsole Console { get; set; }
        public bool IsOnline { get; set; }
        public int Quantity { get; set; }
        public DateTime ReleaseYear { get; set; }
        [Required]
        public TypeOfGenre GenreType { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
