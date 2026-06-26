using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class BidUpdatedDto
    {
        public int AuctionId { get; set; }
        public decimal CurrentPrice { get; set; }
        public BidHistory NewBid { get; set; }
    }
}
