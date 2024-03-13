using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public abstract class BaseRequestHandler : IRequestHandler
    {
        private IRequestHandler nextHandler;

        public void SetNextHandler(IRequestHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(Request request)
        {
            if (CanHandle(request))
            {
                ProcessRequest(request);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No handler found for the request.");
            }
        }

        protected abstract bool CanHandle(Request request);
        protected abstract void ProcessRequest(Request request);
    }
}
