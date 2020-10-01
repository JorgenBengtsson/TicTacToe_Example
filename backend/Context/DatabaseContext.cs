using Microsoft.EntityFrameworkCore;
using TicTacToe_BackEnd.Entities;

namespace TicTacToeBackend.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Player> Players { set; get; }
        public DbSet<Address> Addresses { set; get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne<Player>(a => a.player)
                .WithOne(c => c.address)
                .HasForeignKey<Player>(c => c.fkAdress);
        }
    }
}