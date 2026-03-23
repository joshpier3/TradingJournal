using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingJournal.Data
{
    public class TradeJournalDBContext : DbContext
    {
        public DbSet<TradeJournalEntry> TradeJournalEntry { get; set; }
        public DbSet<Trade> Trade { get; set; }
        public DbSet<TradeAsset> TradeAsset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TradingJournal.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeAsset>().
                HasIndex("Name", "Type").
                IsUnique();

            modelBuilder.Entity<TradeJournalEntry>().
                HasOne(j => j.Trade).
                WithOne(t => t.JournalEntry).
                HasForeignKey<TradeJournalEntry>(e => e.TradeId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Trade>().
                HasOne(t => t.Asset).
                WithMany(a => a.Trades).
                HasForeignKey(t => t.AssetId).
                OnDelete(DeleteBehavior.Cascade);
        }
    }
}
