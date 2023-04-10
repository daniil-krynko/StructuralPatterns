using System;
using AdapterPattern;
public class Adapter : RoundPeg
{
    private SquarePeg peg;
    // peg.width * Math.Sqrt(2) / 2) - формула описанной окружности квадрата
    public Adapter(SquarePeg peg) : base(Convert.ToUInt32(peg.width * Math.Sqrt(2) / 2)) // Call of parent's constructor
    {
        this.peg = peg;
    }
}
