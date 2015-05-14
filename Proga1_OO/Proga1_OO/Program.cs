using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Proga1_OO
{
    class Program
    {

        static void Main(string[] args)
        {
            Worker worker = new Worker(1.0000001,1.0000001);
            Renderer renderer = new Renderer(500,
                (object sender, ElapsedEventArgs e) =>
                {
                    Console.WriteLine(worker.GetValue().ToString()+"кк раз число возведено в степень");
                });
            renderer.Start();
            while(!Console.KeyAvailable)
            {
                worker.DoWork();
            }
            renderer.Stop();
        }
    }
}
