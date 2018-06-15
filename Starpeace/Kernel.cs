using System;

namespace Starpeace
{
    public class Kernel
    {
        Population population = new Population();
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
