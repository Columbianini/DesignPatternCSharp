using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJApp.Controller
{
    interface ControllerInterface
    {
        void on();
        void off();
        void increaseBPM();
        void decreaseBPM();
    }
}
