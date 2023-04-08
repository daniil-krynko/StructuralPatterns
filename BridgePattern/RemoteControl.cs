using System;

public class RemoteControl
{
	protected IDevice device;

	public RemoteControl(IDevice device) => this.device = device;
	public void TogglePower()
	{
		Console.Write($"{device.GetDeviceType()} was ");
		if (this.device.IsEnabled())
		{
			Console.WriteLine("ON, but now OFF");
			device.Disable();
		}
		else
		{
			Console.WriteLine("OFF, but now ON");
            device.Enable();
		}
	}

	void VolumeDown()
	{
        device.SetVolume(device.GetVolume() - 5);
		Console.WriteLine($"Volume of {device.GetDeviceType()} is {device.GetVolume()}");
	}
	void VolumeUp()
	{
        device.SetVolume(device.GetVolume() + 5);
        Console.WriteLine($"Volume of {device.GetDeviceType()} is {device.GetVolume()}");
    }
    void ChannelDown()
	{
        device.SetChannel(device.GetChannel() - 1);
        Console.WriteLine($"Channel of {device.GetDeviceType()} is {device.GetChannel()}");
    }
    void ChannelUp()
	{
        device.SetChannel(device.GetChannel() + 1);
        Console.WriteLine($"Channel of {device.GetDeviceType()} is {device.GetChannel()}");
    }
}
