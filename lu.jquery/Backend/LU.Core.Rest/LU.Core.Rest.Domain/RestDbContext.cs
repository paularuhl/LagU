using LU.Core.Rest.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace LU.Core.Rest.Domain
{
    public class RestDbContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;
        public RestDbContext(DbContextOptions<RestDbContext> options, ILoggerFactory loggerFactory)
            : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerGame> PlayerGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>()
                .HasMany(c => c.PlayerGames)
                .WithOne(c => c.Player);

            builder.Entity<Game>()
                .HasMany(c => c.PlayerGames)
                .WithOne(c => c.Game);

            builder.Entity<PlayerGame>()
                .HasOne(c => c.Game)
                .WithMany(c => c.PlayerGames);

            builder.Entity<PlayerGame>()
                .HasOne(c => c.Player)
                .WithMany(c => c.PlayerGames);
        }
    }
}
