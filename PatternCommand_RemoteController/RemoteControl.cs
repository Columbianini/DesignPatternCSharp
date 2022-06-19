using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand_RemoteController
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            


            var noCommand = new NoCommand();
            undoCommand = noCommand;
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)

        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }

        public override string ToString()
        {
            List<string> outputString = new List<string>() { "----- Remote Control -----" };
            for(int i = 0; i < onCommands.Length; i++)
            {
                outputString.Add($"[slot {i}] {onCommands[i].GetType().Name} {offCommands[i].GetType().Name}");
            }
            outputString.Add($"[slot undo] {undoCommand.GetType().Name}");
            return string.Join(Environment.NewLine, outputString);
        }
    }
}
