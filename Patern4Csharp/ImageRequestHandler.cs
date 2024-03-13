using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class ImageRequestHandler : BaseRequestHandler
    {
        protected override bool CanHandle(Request request)
        {
            return request.Content.Contains("image");
        }

        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Image request handled: " + request.Content);
        }
    }
}
