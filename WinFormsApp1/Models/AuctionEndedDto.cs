using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class AuctionEndedDto
    {
        public int AuctionId { get; set; }
        public string WinnerName { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
