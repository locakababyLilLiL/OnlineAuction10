using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class BidHistory
    {
        public int Id { get; set; }
        public int AuctionId { get; set; }
        public int UserId { get; set; }

        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }

        public string FullName { get; set; } // thêm để hiển thị
    }
}
