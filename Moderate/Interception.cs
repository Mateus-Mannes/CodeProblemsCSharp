using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moderate
{
    public class Coordenada{
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Reta{
        public Coordenada Inicial { get; set; }
        public Coordenada Final { get; set; }
    }

    public static class Interception
    {
        public static void Run(Reta r1, Reta r2){
            if(r1.Final.X < r2.Inicial.X || r2.Final.X < r1.Inicial.X){
                    Console.WriteLine($"fora");
                    return;
            }
                

            if(r1.Final.Y < r2.Inicial.Y || r2.Final.Y < r1.Inicial.Y){
                    Console.WriteLine($"fora");
                    return;
            }

            var ab1 = PegarAeB(r1);
            var ab2 = PegarAeB(r2);

            if(ab1.Item1 == ab2.Item1) {
                    Console.WriteLine($"fora");
                    return;
            }

            decimal x = (ab1.Item2 + ab2.Item2) / (ab1.Item1 - ab2.Item2);

            decimal y = ab1.Item1 * x + ab1.Item2;

            Console.WriteLine($"{x}, {y}");
        }

        public static (decimal, int) PegarAeB(Reta r){
            decimal a = (r.Final.Y - r.Inicial.Y) / (decimal)(r.Final.X - r.Inicial.Y);
            var b = r.Inicial.Y;
            return (a, b);
        }
    }
}