using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public interface IRequestHandler
    {
        void HandleRequest(Request request);
        void SetNextHandler(IRequestHandler nextHandler);
    }
}
