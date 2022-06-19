using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand_RemoteController
{
    class SimpleRemoteControl
    {
        //Command slot; 

        //public void setCommand(Command command) => slot = command;

        public Command Slot { private get; set; }

        public void buttonWasPressed() => Slot.execute();
    }
}
