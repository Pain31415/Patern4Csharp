using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class Request
    {
        public string Content { get; }

        public Request(string content)
        {
            Content = content;
        }
    }
}
