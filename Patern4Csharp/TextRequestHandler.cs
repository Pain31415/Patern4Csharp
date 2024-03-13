using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class TextRequestHandler : BaseRequestHandler
    {
        protected override bool CanHandle(Request request)
        {
            return request.Content.Contains("text");
        }

        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Text request handled: " + request.Content);
        }
    }
}
