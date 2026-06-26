using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal StepPrice { get; set; }

        public DateTime EndTime { get; set; }
        public int Status { get; set; }

        public int? WinnerId { get; set; }
    }
}
