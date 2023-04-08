using System;

public class Tv : IDevice
{
	bool power;
	uint volume;
	uint channel;
    string deviceType;

    public Tv()
	{
		power = false;
		volume = 50;
		channel = 1;
		deviceType = "TV";
	}
    public string GetDeviceType()
	{
		return deviceType;
	}
    public bool IsEnabled()
	{
		return power;
	}
    public void Enable()
	{
		power = true;
	}
    public void Disable()
	{
		power = false;
	}
    public uint GetVolume()
	{
		return volume;
	}
    public void SetVolume(uint percent)
	{
		if (percent > 100 || percent < 0)
			return;
        volume = percent;
	}
    public uint GetChannel()
	{
		return channel;
	}
    public void SetChannel(uint number)
	{
		if (channel > 99)
		{
			channel = 1;
			return;
		}
        if (channel < 1)
        {
            channel = 99;
            return;
        }
        this.channel = number;
	}
}
