using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DJApp.Model;



namespace DJApp.Controller
{
    class BeatController : ControllerInterface, INotifyPropertyChanged
    {
        public BeatModel _model = new BeatModel();

        public int BPM 
        { 
            get 
            { 
                return _model.BPM; 
            }
            set
            {
                if (value >= 0)
                {
                    _model.BPM = value;
                    OnPropertyChanged("BPM");
                }     
            }        
        }

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

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void decreaseBPM()
        {
            _model.BPM--;
            OnPropertyChanged("BPM");
        }

        public void increaseBPM()
        {
            _model.BPM++;
            OnPropertyChanged("BPM");
        }

        public void off()
        {
            _model.off();
            OnPropertyChanged("Status");
            OnPropertyChanged("BPM");
        }

        public void on()
        {
            _model.on();
            OnPropertyChanged("Status");
            OnPropertyChanged("BPM");
        }
    }
}
