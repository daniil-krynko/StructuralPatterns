using System;

public class AdvancedRemoteControl : RemoteControl
{
	public AdvancedRemoteControl(IDevice device) : base(device)
	{}
	void Mute()
	{ device.SetVolume(0); }
}
