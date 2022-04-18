using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator { get; }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Comunicate(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }
}
