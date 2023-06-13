using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chat.Server.Context;
using Chat.Server.Messages;

namespace Chat.Server
{
    public class NetworkManager
    {
        public MainServer server;
        public ConcurrentDictionary<EndPoint, string> connectedClientsWithEndpoint;
        public MessageHandler messageHandler;
        public static object pong;
        public NetworkManager() {
            connectedClientsWithEndpoint = new ConcurrentDictionary<EndPoint, string>();
        }

        public void StartServer(string ip, int port)
        {
            server = new MainServer(this);
            server.StartServer(ip, port);
        }
    }
}
