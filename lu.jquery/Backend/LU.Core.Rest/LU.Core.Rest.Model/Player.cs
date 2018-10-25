using System;
using System.Collections.Generic;

namespace LU.Core.Rest.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get;set; }
        public IList<PlayerGame> PlayerGames { get; set; }
    }
}
