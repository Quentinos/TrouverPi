using System;

namespace TrouverPi
{
    class Program
    {
        static void Main(string[] args)
        {
           int findPi(double n)
            {
                int num_circle = 0;
            int num_total = 0;

                for(double i = 0; i < n; i++)
                {
                    var rand = new Random();
                    double x = rand.NextDouble();
                    double y = rand.NextDouble();
                    double distance = x * x + y * y;
                    if(distance <= 1)
                    {
                        num_circle = num_circle + 1;
                    }
                    num_total = num_total + 1;
                }
                return (4 * num_circle / num_total);
           }

            Console.WriteLine(findPi(1000000.000));
        }
    }
}
