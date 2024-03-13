using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(IMediator mediator) : base(mediator) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Received message: " + message);
        }

        public override void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }
    }
}
