using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_CSharp
{
    static class Renderer
    {
        internal static void WriteLine(object mes)
        {
            Console.WriteLine(mes.ToString());
        }

        internal static void Write(object mes)
        {
            Console.Write(mes.ToString());
        }

        internal static void StartWaiter()
        {
            throw new NotImplementedException();
        }

        internal static void StopWaiter()
        {
            throw new NotImplementedException();
        }
    }
}
