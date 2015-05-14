using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Proga1_OO
{
    class Renderer
    {
        Timer _timer;
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
}
