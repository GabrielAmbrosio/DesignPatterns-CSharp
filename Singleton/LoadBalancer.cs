using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer instance = new LoadBalancer();
        private readonly List<Server> servers;
        private readonly Random random = new Random();

        private LoadBalancer()
        {
            servers = new List<Server>
                {
                  new Server{ name = "ServerI", ip = "120.14.220.18" },
                  new Server{ name = "ServerII", ip = "120.14.220.19" },
                  new Server{ name = "ServerIII", ip = "120.14.220.20" },
                  new Server{ name = "ServerIV", ip = "120.14.220.21" },
                  new Server{ name = "ServerV", ip = "120.14.220.22" },
                };
        }
        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}

