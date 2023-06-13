using Chat.Core;

namespace Chat.Server
{
    public class ServerManager: Singleton<ServerManager>
    {
        public NetworkManager networkManager;
        public AppThread appThread;
        
        public ServerManager() { 
            // need an appThread
            appThread = new AppThread();
            Instance = this;
            // need a network manager
            networkManager = new NetworkManager();
            // we need a timer
        }


   
    }
}