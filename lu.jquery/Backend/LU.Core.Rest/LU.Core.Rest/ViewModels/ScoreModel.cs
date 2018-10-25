using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LU.Core.Rest.ViewModels
{
    public class ScoreModel
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
    }
}
