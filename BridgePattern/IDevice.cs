using System;

public interface IDevice
{
    bool IsEnabled();
    void Enable();
    void Disable();
    uint GetVolume();
    void SetVolume(uint percent);
    uint GetChannel();
    void SetChannel(uint channel);
}