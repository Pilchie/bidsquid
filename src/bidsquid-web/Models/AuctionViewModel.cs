using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bidsquid_web.Models
{
    public class AuctionViewModel
    {
        public DateTime Date { get; }

        public string TagLine { get; }

        public AuctionViewModel(DateTime date, string tagLine)
        {
            Date = date;
            TagLine = tagLine;
        }
    }
}
