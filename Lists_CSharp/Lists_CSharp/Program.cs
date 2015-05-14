using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime st = System.DateTime.Now;
            int M = int.Parse(args[0]);
            int N = int.Parse(args[1]);
            Renderer.Write("Generating lists");
            for (int i = 0; i < N; i++)
            {
                int[] list = ListWorker.GenerateList(M);
                Renderer.Write(".");
            }
            Renderer.WriteLine("Finished");
            //Renderer.WriteLine("Generated "+N+" lists of length "+M);
            //Renderer.WriteLine(System.DateTime.Now-st+"ms elapsed");
            //Console.ReadLine();
        }

        private static void SetSingleCore()
        {
            var proc = Process.GetCurrentProcess();
            foreach (ProcessThread pt in proc.Threads)
            {
                pt.IdealProcessor = 0;
                pt.ProcessorAffinity = (IntPtr)1;
            }
        }
    }
}
