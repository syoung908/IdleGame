using Entities.Database;
using Microsoft.EntityFrameworkCore;
using System;

namespace DL {
    public class GameDbContext: DbContext {
        public GameDbContext() : base() { }
        public GameDbContext(DbContextOptions options) : base(options) { }

        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<GameConnection> GameConnections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<GameUser>()
                .HasIndex(u => u.UserName).IsUnique();
            modelBuilder.Entity<GameConnection>()
                .HasOne(c => c.GameUser)
                .WithMany(u => u.Connections)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
