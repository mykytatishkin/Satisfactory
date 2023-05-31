using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Client_System
{
    public class Client
    {
        public async Task<string> SendMessage(string message)
        {
            try
            {
                TcpClient client = new TcpClient("localhost", 1234);

                NetworkStream stream = client.GetStream();
                var messageBytes = Encoding.Unicode.GetBytes(message);
                await stream.WriteAsync(messageBytes, 0, messageBytes.Length);

                // Ожидание ответа от сервера
                var buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string responseMessage = Encoding.Unicode.GetString(buffer, 0, bytesRead);

                client.Close();
                stream.Close();

                return responseMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ex.Message;
            }
        }
    }
}
