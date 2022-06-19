using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand_RemoteController
{
    interface Command
    {
        void execute();
        void undo();
    }

    class NoCommand : Command
    {
        public void execute() => Console.WriteLine("No Command found");

        public void undo() => Console.WriteLine("No Command found");
    }

    class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light light) => this.light = light;
        public void execute() => light.on();

        public void undo() => light.off();
    }

    class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light light) => this.light = light;
        public void execute() => light.off();

        public void undo() => light.on();
    }


    class StereoOnWithCDCommnad : Command
    {
        Stereo stereo;
        public StereoOnWithCDCommnad(Stereo stereo) => this.stereo = stereo;
        public void execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }

        public void undo() => stereo.off();
    }

    class StereoOffCommnad : Command
    {
        Stereo stereo;
        public StereoOffCommnad(Stereo stereo) => this.stereo = stereo;
        public void execute() => stereo.off();

        public void undo()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }
    }

    class CeilingFanHighCommand: Command
    {
        CeilingFan ceilingFan;
        private int prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan) => this.ceilingFan = ceilingFan;

        public void execute() { prevSpeed = ceilingFan.speed; ceilingFan.high(); }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (prevSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else
                ceilingFan.off();
        }
    }

    class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        private int prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan) => this.ceilingFan = ceilingFan;

        public void execute() { prevSpeed = ceilingFan.speed; ceilingFan.medium(); }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (prevSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else
                ceilingFan.off();
        }
    }

    class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        private int prevSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan) => this.ceilingFan = ceilingFan;

        public void execute() { prevSpeed = ceilingFan.speed; ceilingFan.low(); }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (prevSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else
                ceilingFan.off();
        }
    }

    class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        private int prevSpeed;
        public CeilingFanOffCommand(CeilingFan ceilingFan) => this.ceilingFan = ceilingFan;
        public void execute() {prevSpeed = ceilingFan.speed; ceilingFan.off();}

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
                ceilingFan.high();
            else if (prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.medium();
            else if (prevSpeed == CeilingFan.LOW)
                ceilingFan.low();
            else
                ceilingFan.off();
        }
    }

    class GarageDoorOnCommand : Command
    {
        public GarageDoor garageDoor;
        public GarageDoorOnCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;
        public void execute()
        {
            garageDoor.up();
            garageDoor.lightOn();
        }

        public void undo()
        {
            garageDoor.lightOff();
            garageDoor.down();
        }
    }

    class GarageDoorOffCommand : Command
    {
        public GarageDoor garageDoor;
        public GarageDoorOffCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;
        public void execute()
        {
            garageDoor.lightOff();
            garageDoor.down();
        }

        public void undo()
        {
            garageDoor.up();
            garageDoor.lightOn();
        }
    }

    class TVOnCommand : Command
    {
        public TV tv;
        public TVOnCommand(TV tv) => this.tv = tv;

        public void execute()
        {
            tv.on();
            tv.Channel = "DVD";
        }

        public void undo()
        {
            tv.off();
        }
    }

    class TVOffCommand : Command
    {
        public TV tv;
        public TVOffCommand(TV tv) => this.tv = tv;

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
            tv.Channel = "DVD";
        }
    }

    class HottubOnCommand : Command
    {
        private Hottub hottub;
        public HottubOnCommand(Hottub hottub) => this.hottub = hottub;
        public void execute()
        {
            hottub.jetsOn();
        }

        public void undo()
        {
            hottub.jetsOff();
        }
    }

    class HottubOffCommand : Command
    {
        private Hottub hottub;
        public HottubOffCommand(Hottub hottub) => this.hottub = hottub;
        public void execute()
        {
            hottub.jetsOff();
        }

        public void undo()
        {
            hottub.jetsOn();
        }
    }

    class MacroCommand : Command
    {
        private List<Command> commands;

        public MacroCommand(IEnumerable<Command> commands) => this.commands = new List<Command>(commands);
        public void execute()
        {
            foreach(var command in commands)
            {
                command.execute();
            }
        }

        public void undo()
        {
            foreach (var command in commands)
            {
                command.undo();
            }
        }
    }
}
