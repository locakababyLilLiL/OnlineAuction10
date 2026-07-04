using System;

namespace AuctionServer
{
    public class Bid
    {
        public string Username { get; set; }

        public int Price { get; set; }

        public DateTime Time { get; set; }
    }
}