using QNetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Server.Context
{
    public class MainServer
    {
        private SimpleWebServer webserver;
        private NetworkManager _networkManager;
        public MainServer(NetworkManager networkManager) { 
            _networkManager = networkManager;
        }

        public void StartServer(string ip, int port)
        {
            webserver = new SimpleWebServer(ip, port);
            Console.WriteLine("Webserver is starting successfully!");
            webserver.Start();
            Console.WriteLine("Webserver started successfully!");

        }
    }
}
