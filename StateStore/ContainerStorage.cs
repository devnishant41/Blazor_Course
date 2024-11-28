using App_01_ServerManagement.Models;

namespace App_01_ServerManagement.StateStore
{
    public class ContainerStorage
    {
        private Server _server = new Server();

        public Server GetServer()
        {
            return _server;
        }

        public void SetServer(Server? server)
        {
            _server = server;
        }
    }

}
