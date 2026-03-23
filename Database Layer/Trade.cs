using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingJournal.Data
{
    public class Trade
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public decimal Pnl { get; set; }
        public decimal Fees { get; set; }
        public int Quanity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual TradeAsset Asset { get; set; }
        public virtual TradeJournalEntry JournalEntry { get; set; }
    }
}
