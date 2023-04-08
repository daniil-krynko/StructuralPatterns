namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            RemoteControl remote = new RemoteControl(tv);
            remote.TogglePower();

            Radio radio = new Radio();
            AdvancedRemoteControl advRemote = new AdvancedRemoteControl(radio);
        }
    }
}