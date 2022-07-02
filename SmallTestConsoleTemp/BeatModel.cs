using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTestConsoleTemp
{
    class BeatModel : IBeatModel
    {
        private int _bpm = 0;
        public int BPM 
        { 
            get { return _bpm; } 
            set 
            { 
                if (_status & value>0)
                {
                    BPM = value; 
                }
                else
                {
                    BPM = 0;
                }         
            } 
        }
        private bool _status = false;
        public bool Status { get { return _status; } set { _status = value;} }

        public void off()
        {
            Status = false;
            BPM = 0; 
        }

        public void on()
        {
            Status = true;
            BPM = 90;
        }
    }
}
