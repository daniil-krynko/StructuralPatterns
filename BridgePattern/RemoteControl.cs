using System;
using BridgePattern;

public class RemoteControl
{
	protected IDevice device;

	public RemoteControl(IDevice device) => this.device = device;
	void togglePower()
	{
		if (this.device.IsEnabled())
			device.Disable();
		else
			device.Enable();
	}

	void VolumeDown()
	{ device.SetVolume(device.GetVolume() - 5); }
	void VolumeUp()
	{ device.SetVolume(device.GetVolume() + 5); }
	void ChannelDown()
	{ device.SetChannel(device.GetChannel() - 1); }
	void ChannelUp()
	{ device.SetChannel(device.GetChannel() + 1); }
}
