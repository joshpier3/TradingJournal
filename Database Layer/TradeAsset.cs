using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingJournal.Data
{
    public class TradeAsset
    {
        public long Id { get; set; }   
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual List<Trade> Trades { get; set; }
    }
}
