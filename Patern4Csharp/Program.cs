namespace Patern4Csharp
{
     class Program
     {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            Light kitchenLight = new Light();

            ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            ICommand kitchenLightOn = new LightOnCommand(kitchenLight);
            ICommand kitchenLightOff = new LightOffCommand(kitchenLight);

            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(livingRoomLightOn);
            remoteControl.SetCommand(kitchenLightOn);
            remoteControl.SetCommand(livingRoomLightOff);
            remoteControl.SetCommand(kitchenLightOff);

            remoteControl.ExecuteCommands();
        }
     }
}