using System;
using System.Collections.Generic;
using System.Text;

namespace LU.Core.Rest.Model
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public IList<PlayerGame> PlayerGames { get; set; }
    }
}
