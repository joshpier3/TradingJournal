using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TradingJournal.Data
{
    public class TradeJournalEntry
    {
        public long Id { get; set; }
        public long TradeId { get; set; }
        public string Title { get; set; }
        public string Entry { get; set; }

        public virtual Trade Trade { get; set; }
    }
}
