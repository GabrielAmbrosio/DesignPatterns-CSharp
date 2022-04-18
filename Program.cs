using DesignPatterns.Mediator;
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

        }
    }
}
