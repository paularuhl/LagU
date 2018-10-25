using System;
using System.Collections.Generic;
using System.Text;

namespace LU.Core.Rest.Model
{
    public class PlayerGame
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public Player Player { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
    }
}
