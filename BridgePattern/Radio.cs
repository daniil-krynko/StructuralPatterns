using System;

public class Radio : IDevice
{
    bool power;
    uint volume;
    uint channel;
    string deviceType;

    public Radio()
    {
        power = false;
        volume = 100;
        channel = 10;
        deviceType = "Radio";
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
        volume = percent;
    }
    public uint GetChannel()
    {
        return channel;
    }
    public void SetChannel(uint frequency)
    {
        this.channel = frequency;
    }
}
