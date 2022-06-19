using System;
using System.Collections.Generic;
namespace PatternCommand_RemoteController
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            TV tv = new TV("Living Room");
            Hottub hottub = new Hottub();
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            TVOnCommand tvOn = new TVOnCommand(tv);
            TVOffCommand tvOff = new TVOffCommand(tv);

            HottubOnCommand hottubOnCommand = new HottubOnCommand(hottub);
            HottubOffCommand hottubOffCommand = new HottubOffCommand(hottub);

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);



            GarageDoorOnCommand garageDoorOnCommand = new GarageDoorOnCommand(garageDoor);
            GarageDoorOffCommand garageDoorOffCommand = new GarageDoorOffCommand(garageDoor);

            StereoOnWithCDCommnad stereoOnWithCDCommnad = new StereoOnWithCDCommnad(stereo);
            StereoOffCommnad stereoOffCommnad = new StereoOffCommnad(stereo);


            MacroCommand partyOnMacro = new MacroCommand(new List<Command>() { livingRoomLightOn, stereoOnWithCDCommnad, tvOn, hottubOnCommand });
            MacroCommand partyOffMacro = new MacroCommand(new List<Command>() { livingRoomLightOff, stereoOffCommnad, tvOff, hottubOffCommand });




            //remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchLightOn, kitchLightOff);
            remoteControl.setCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);
            remoteControl.setCommand(3, ceilingFanMediumCommand, ceilingFanOffCommand);
            remoteControl.setCommand(4, partyOnMacro, partyOffMacro);
            //remoteControl.setCommand(3, stereoOnWithCDCommnad, stereoOffCommnad);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro on ---");
            remoteControl.onButtonWasPushed(4);
            Console.WriteLine("--- Pushing Macro off ---");
            remoteControl.offButtonWasPushed(4);


            //remoteControl.onButtonWasPushed(3);
            //remoteControl.offButtonWasPushed(3);
            //Console.WriteLine(remoteControl);
            //remoteControl.undoButtonWasPushed();

            //remoteControl.onButtonWasPushed(2);
            //Console.WriteLine(remoteControl);
            //remoteControl.undoButtonWasPushed();


            //remoteControl.onButtonWasPushed(0);
            //remoteControl.offButtonWasPushed(0);
            //Console.WriteLine(remoteControl);

            //remoteControl.undoButtonWasPushed();
            //remoteControl.offButtonWasPushed(0);
            //remoteControl.onButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.undoButtonWasPushed();



            //for(int i = 0; i <= 3; i++)
            //{
            //    remoteControl.onButtonWasPushed(i);
            //    remoteControl.offButtonWasPushed(i);
            //}
        }
    }
}
