using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand_RemoteController
{
    class Light
    {
        public string Name { get; set; }
        public Light(string name) => Name = name; 
        public void on() => Console.WriteLine($"{Name} light is on");
        public void off() => Console.WriteLine($"{Name} light is off");
    }

    class Stereo
    {
        public string Name { get; set; }
        public Stereo(string name) => Name = name;
        public void on() => Console.WriteLine($"{Name} Stereo is on");
        public void off() => Console.WriteLine($"{Name} Stereo is off");
        public void setCd() => Console.WriteLine($"{Name} is set for CD input");
        public void setDvd() => Console.WriteLine($"{Name} is set for DVD input");
        public void setRadio() => Console.WriteLine($"{Name} is set for Radio input");
        public void setVolume(int loudness) => Console.WriteLine($"{Name} volume is set to {loudness}");
    }

    class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;

        private string location;
        public int speed { get; private set; }


        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void high() { Console.WriteLine($"{location} ceiling fan is on high"); speed = HIGH; }
        public void medium() { Console.WriteLine($"{location} ceiling fan is on medium"); speed = MEDIUM; }
        public void low() { Console.WriteLine($"{location} ceiling fan is on low"); speed = LOW; }
        public void off() {Console.WriteLine($"{location} ceiling fan is off"); speed=OFF;}

    }

    class GarageDoor
    {
        public string Name { get; set; }

        public GarageDoor(string name) => Name = name;

        public void up() => Console.WriteLine($"{Name} door is up");
        public void down() => Console.WriteLine($"{Name} door is down");
        public void stop() => Console.WriteLine($"{Name} door is stop");
        public void lightOn() => Console.WriteLine($"{Name} door's light is on");
        public void lightOff() => Console.WriteLine($"{Name} door's light is off");
    }

    class TV
    {
        private string _channel;
        public string Channel
        {
            get => _channel;
            set
            {
                Console.WriteLine($"{location} TV's Channel is set for {value}");
                _channel = value;
            }
        }
        public int Volume
        {
            get => Volume;
            set
            {
                Console.WriteLine($"{location} TV's Volume is set to {value}");
                Volume = value;
            }
        }
        public string location { get; set; }
        public TV(string location) { this.location = location; }
        public void on() => Console.WriteLine($"{location} TV is on");
        public void off() => Console.WriteLine($"{location} TV is off");
    }

    class Hottub
    {
        private int _temp = 0;
        public int Temperature
        {
            get => _temp;
            set
            {
                if (_temp < value)
                {
                    Console.WriteLine($"Hottub is heating to a steaming {value} degrees");
                }
                else
                {
                    Console.WriteLine($"Hottub is cooling to a steaming {value} degrees");
                }
                if (value >= 100)
                    Console.WriteLine("Hottub is bubbling");
                _temp = value;
            }
        }
        public void circulate() => Console.WriteLine("Hottub is circulating");
        public void jetsOn() { Temperature = 104; }
        public void jetsOff() { Temperature = 98; }
    }
}
