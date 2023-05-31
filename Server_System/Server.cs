using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows;
using System.Xml.Linq;
using System.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace Server_System
{

    internal class Server
    {
        static void Main(string[] args)
        {
            /*var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();

            DbContextOptionsBuilder<SatisfactoryDbContext> dbContextOptionsBuilder = 
                new DbContextOptionsBuilder<SatisfactoryDbContext>();
            var options = dbContextOptionsBuilder;*/
                //.UseLazyLoadingProxies()
                //.UseSqlServer(config.GetConnectionString("MainConnectionString")).Options;

            /*using (SatisfactoryDbContext db = new SatisfactoryDbContext(options))
            {
                db.Subjects.AddRange(new Subject { Name = "Math" }, new Subject { Name = "Biology" });
                db.SaveChanges();
            }*/
            TcpListener server = new TcpListener(IPAddress.Loopback, 1234);
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                var buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                var requestMessage = Encoding.Unicode.GetString(buffer, 0, bytesRead);

                switch (requestMessage)
                {
                    case "Button Add clicked":
                        // выполнить реализацию после нажатия кнопки "Добавить"

                        // отправить ответ обратно клиенту
                        var responseMessage = Encoding.Unicode.GetBytes("server got add button");
                        stream.Write(responseMessage, 0, responseMessage.Length);
                        break;

                    case "Button Delete clicked":
                        // выполнить реализацию после нажатия кнопки "Удалить"

                        // отправить ответ обратно клиенту
                        responseMessage = Encoding.Unicode.GetBytes("server got delete button");
                        stream.Write(responseMessage, 0, responseMessage.Length);
                        break;

                    case "Button Edit clicked":
                        // выполнить реализацию после нажатия кнопки "Редактировать"

                        // отправить ответ обратно клиенту
                        responseMessage = Encoding.Unicode.GetBytes("server got edit button");
                        stream.Write(responseMessage, 0, responseMessage.Length);
                        break;

                    default:
                        break;
                }

                client.Close();
                stream.Close();
            }
        }
    }
}
