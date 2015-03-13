using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Proga1_OO
{
    class Renderer
    {
        Timer _timer;
        Worker _worker;
        List<System.Timers.ElapsedEventHandler> _procList = new List<ElapsedEventHandler>();

        public Renderer(int ticktime, System.Timers.ElapsedEventHandler proc)
        {
            _timer = new Timer();
            _timer.Interval = ticktime;
            _timer.Elapsed += proc;
            _procList.Add(proc);
        }

        public Renderer(int ticktime)
        {
            _timer = new Timer();
            _timer.Interval = ticktime;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void AddTimerTickProc(System.Timers.ElapsedEventHandler proc)
        {
            _timer.Elapsed += proc;
            _procList.Add(proc);
        }

        ~Renderer()
        {
            foreach (System.Timers.ElapsedEventHandler e in _procList)
            {
                _timer.Elapsed -= e;
            }
            _procList.Clear();
        }
    }

    class Worker
    {
        double _value;
        double _rank;
        
        public Worker(double rank, double value = 1.1)
        {
            _rank = rank;
            _value = value;
        }

        public double GetValue()
        {
            return _value;
        }

        public void DoWork()
        {
            _value = Math.Pow(_value, _rank);
        }

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(_value.ToString());
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Worker worker = new Worker(1.0000001,1.0000001);
            Renderer renderer = new Renderer(500, worker.timer_Elapsed);
            renderer.Start();
            while(!Console.KeyAvailable)
            {
                worker.DoWork();
            }
            renderer.Stop();
        }
    }
}
