namespace App_01_ServerManagement.Models
{
    public class ServerRepository
    {
        private static List<Server> servers = new List<Server>()
        {
            new Server { ServerId = 1, Name = "SRV-NYC-01", City = "New York" },
            new Server { ServerId = 2, Name = "SRV-LAX-01", City = "London" },
            new Server { ServerId = 3, Name = "SRV-CHI-01", City = "Chicago" },
            new Server { ServerId = 4, Name = "SRV-LON-01", City = "London" },
            new Server { ServerId = 5, Name = "SRV-TKY-01", City = "Tokyo" },
            new Server { ServerId = 6, Name = "SRV-SYD-01", City = "London" },
            new Server { ServerId = 7, Name = "SRV-SIN-01", City = "Chicago" },
            new Server { ServerId = 8, Name = "SRV-FRA-01", City = "Chicago" },
            new Server { ServerId = 9, Name = "SRV-TOR-01", City = "Chicago" },
            new Server { ServerId = 10, Name = "SRV-AMS-01", City = "London" }
        };

        public static void AddServer(Server server)
        {
            var maxId = servers.Max(x => x.ServerId);
            server.ServerId = maxId + 1;
            servers.Add(server);
        }

        public static List<Server> GetServers() => servers;

        public static List<Server> GetServerByCity(string cityName)
        {
            return servers.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static Server? GetServerById(int id)
        {
            var server = servers.FirstOrDefault(s => s.ServerId == id);
            if (server != null)
            {
                return new Server
                {
                    ServerId = server.ServerId,
                    Name = server.Name,
                    City = server.City,
                    IsOnline = server.IsOnline,
                };
            }
            return null;
        }

        public static void UpdateServer(int serverId, Server server)
        {
            System.Console.WriteLine(serverId + server.ServerId + server.Name + server.City + server.IsOnline);
            if (serverId != server.ServerId) return;

            var serverToUpdate = servers.FirstOrDefault(s => s.ServerId == serverId);
            if (serverToUpdate != null)
            {
                serverToUpdate.IsOnline = server.IsOnline;
                serverToUpdate.City = server.City;
                serverToUpdate.Name = server.Name;
            }

            foreach (var item in servers)
            {
                System.Console.WriteLine(item.ServerId + item.Name + item.City + item.IsOnline);
            }


        }
        public static void DeleteServer(int serverId)
        {
            var server = servers.FirstOrDefault(s => s.ServerId == serverId);
            if (server != null)
            {
                servers.Remove(server);
            }
        }

        public static List<Server> SearchServers(string serverFilter)
        {
            return servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }


    public static class CityRepository
    {
        private static List<string> cities = new List<string>
        {
            "NewYork","London","Chicago","Tokyo","Singapore"

        };

        public static List<string> GetCities() => cities;
    }

}
