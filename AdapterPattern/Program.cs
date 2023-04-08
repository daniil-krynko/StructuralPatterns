namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Adapter pattern\n");

            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);
            Console.WriteLine($"Does round peg fits to hole? - {hole.Fits(rpeg)}");

            SquarePeg smallSqpeg = new SquarePeg(5);
            SquarePeg largeSqpeg = new SquarePeg(10);
            // hole.Fits(smallSqpeg); // It won't compile (incompatible types)

            Adapter smallSqpegAdapter = new Adapter(smallSqpeg);
            Adapter largeSqpegAdapter = new Adapter(largeSqpeg);
            Console.WriteLine($"Does small square peg fits to hole? - {hole.Fits(smallSqpegAdapter)} ({smallSqpegAdapter.radius})"); // true
            Console.WriteLine($"Does large square peg fits to hole? - {hole.Fits(largeSqpegAdapter)} ({largeSqpegAdapter.radius})"); // false
        }
    }
}