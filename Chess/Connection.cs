using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;


namespace Chess
{
    public class Connection
    {
        public string Connect(string message)
        {

            TcpClient client = new TcpClient("127.0.0.1", 8888);

            Byte[] data = Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new Byte[256];
            string responseData;

            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            stream.Close();
            client.Close();
            return responseData;
        }
    }
}
