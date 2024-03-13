using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class ConcreteMediator : IMediator
    {
        private List<Colleague> colleagues;

        public ConcreteMediator()
        {
            colleagues = new List<Colleague>();
        }

        public void AddColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        public void SendMessage(string message, Colleague colleague)
        {
            foreach (var col in colleagues)
            {
                if (col != colleague)
                {
                    col.ReceiveMessage(message);
                }
            }
        }
    }
}
