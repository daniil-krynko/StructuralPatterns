using System;
using AdapterPattern;
public class Adapter : RoundPeg
{
    private SquarePeg peg;
    public Adapter(SquarePeg peg) : base(Convert.ToUInt32(peg.width * Math.Sqrt(2) / 2))
    {
        this.peg = peg;
    }
}
