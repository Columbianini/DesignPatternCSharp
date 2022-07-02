using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SmallTestConsoleTemp
{
    class BeatController : ControllerInterface, INotifyPropertyChanged
    {
        public BeatModel _model = new BeatModel();

        public int BPM { get { return _model.BPM; } }

        public string Status
        {
            get
            {
                if (_model.Status)
                    return "Music is playing";
                else
                    return "Music is off";
            }
        }
        
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void decreaseBPM()
        {
            _model.BPM--;
            //OnPropertyChanged(string.Empty);
        }

        public void increaseBPM()
        {
            _model.BPM++;
            //OnPropertyChanged(string.Empty);
        }

        public void off()
        {
            _model.off();
            //OnPropertyChanged(string.Empty);
        }

        public void on()
        {
            _model.on();
            //OnPropertyChanged(string.Empty);
        }
    }
}
