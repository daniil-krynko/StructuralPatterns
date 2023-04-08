using System;
using AdapterPattern;

public class RoundHole
{
    public uint radius { get; private set; }
    public RoundHole(uint radius) => this.radius = radius;
    public bool Fits(RoundPeg peg)
    {
        return this.radius >= peg.radius;
    }
}
