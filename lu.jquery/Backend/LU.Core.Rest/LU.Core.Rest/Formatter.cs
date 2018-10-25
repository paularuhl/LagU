using LU.Core.Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LU.Core.Rest
{
    public class Formatter
    {
        public static readonly Expression<Func<Game, object>> FormatGame = (game) =>
            new
            {
                game.Id,
                game.StartDateTime,
                game.EndDateTime,
                Scores = game.PlayerGames.Select(d => new
                {
                    d.Player.Name,
                    d.Player.Country,
                    d.Kills,
                    d.Deaths,
                    d.Assists
                })
            };

        public static readonly Expression<Func<Player, object>> FormatPlayer = (player) =>
            new
            {
                player.Id,
                player.Name,
                player.Country,
                Scores = player.PlayerGames.Select(d => new
                {
                    d.Game.Id,
                    d.Game.StartDateTime,
                    d.Game.EndDateTime,
                    d.Kills,
                    d.Deaths,
                    d.Assists
                })
            };
    }
}
