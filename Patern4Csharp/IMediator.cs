using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public interface IMediator
    {
        void SendMessage(string message, Colleague colleague);
    }
    public abstract class Colleague
    {
        protected IMediator mediator;

        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void ReceiveMessage(string message);
        public abstract void SendMessage(string message);
    }
}
