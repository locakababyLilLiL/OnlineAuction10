using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace AuctionServer
{
    public class AuctionRoom
    {
        public bool CountdownPaused { get; set; }      
        public TimeSpan RemainingWhenPaused { get; set; }  
        public string AuctionId { get; set; }     // ID của phiên đấu giá
        public string ItemName { get; set; }      // Tên sản phẩm đấu giá
        public int StartPrice { get; set; }       // Giá khởi điểm
        public int CurrentPrice { get; set; }     // Giá cao nhất hiện tại    
        public string HighestBidder { get; set; }  // Tên người đấu giá cao nhất hiện tại
        public DateTime EndTime { get; set; }     // Thời gian kết thúc phiên đấu giá
        public bool AuctionEnded { get; set; }    // Trạng thái kết thúc phiên đấu giá
        public List<TcpClient> Clients { get; set; } = new List<TcpClient>();  // Danh sách các client đang tham gia phiên đấu giá
        public List<Bid> BidHistory { get; set; } = new List<Bid>();  // Lịch sử các lượt đặt giá trong phiên đấu giá
        public object RoomLock { get; } = new object();  // Đối tượng khóa để đồng bộ hóa truy cập vào phiên đấu giá
    }
}