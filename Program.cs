using DesignPatterns.Mediator;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    static class Program
    {
        static void Main(string[] args)
        {
            /*-------MEDIATOR-----------*/

            Mediator.Mediator mediator = new Mediator.Mediator();

            IColleague colleagueUser = new User(mediator);

            IColleague colleagueAdmin = new UserAdmin(mediator);

            mediator.Add(colleagueAdmin);
            mediator.Add(colleagueUser);

            colleagueUser.Comunicate("Soporte");

            /*--------------------------*/

            /*---------SINGLETON--------*/

            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            // Next, load balance 15 requests for a server
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
            // Wait for user
            Console.ReadKey();
 
            /*--------------------------*/

        }
    }
}
