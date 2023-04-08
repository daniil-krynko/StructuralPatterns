using System;

public interface IDevice
{
    string GetDeviceType();
    bool IsEnabled();
    void Enable();
    void Disable();
    uint GetVolume();
    void SetVolume(uint percent);
    uint GetChannel();
    void SetChannel(uint number);
}