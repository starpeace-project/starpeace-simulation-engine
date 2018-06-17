using System;

namespace Starpeace
{
    public class Kernel
    {
        int Counter { get; set; }

        public Kernel()
        {
            Counter = 0;
        }

        public void Update()
        {
            Counter++;
            Console.WriteLine(Counter);
            population.Calculate();
        }
    }
}
