using System;

namespace AuctionServer
{
    public class AuctionItem
    {
        public string ItemName { get; set; }

        public int CurrentPrice { get; set; }

        public string HighestBidder { get; set; }

        public DateTime EndTime { get; set; }
    }
}