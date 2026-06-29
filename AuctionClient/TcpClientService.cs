using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuctionClient
{
    public class TcpClientService
    {
        private TcpClient client;
        private NetworkStream stream;

        public event Action<string> OnMessageReceived;

        public void Connect(string ip, int port)
        {
            client = new TcpClient();
            client.Connect(ip, port);
            stream = client.GetStream();

            Thread thread = new Thread(ReceiveLoop);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ReceiveLoop()
        {
            byte[] buffer = new byte[4096];

            while (true)
            {
                int bytes = stream.Read(buffer, 0, buffer.Length);
                if (bytes > 0)
                {
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    OnMessageReceived?.Invoke(msg);
                }
            }
        }

        public void Send(string message)
        {
            if (stream == null) return;

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
    }
}
