using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Pixel
    {
        public bool Visited { get; set; }
        public string Color { get; set; }
    }
    public static class Paint_Fill
    {
        public static void Run(Pixel[][] arr, int y, int x, string color)
        {
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Append(new Tuple<int, int>(x, y));
            var originalColor = arr[x][y].Color;
            while(queue.Count > 0)
            {
                var pixel = queue.Peek();
                arr[pixel.Item1][pixel.Item2].Visited = true;
                arr[pixel.Item1][pixel.Item2].Color = color;

                if (pixel.Item1 - 1 >= 0 && arr[pixel.Item1-1][pixel.Item2].Visited == false && arr[pixel.Item1-1][pixel.Item2].Color == originalColor)
                {
                    arr[pixel.Item1-1][pixel.Item2].Visited = true;
                    arr[pixel.Item1-1][pixel.Item2].Color = color;
                }

                if (pixel.Item1 + 1 < arr.GetLength(1) && arr[pixel.Item1 + 1][pixel.Item2].Visited == false && arr[pixel.Item1 + 1][pixel.Item2].Color == originalColor)
                {
                    arr[pixel.Item1 + 1][pixel.Item2].Visited = true;
                    arr[pixel.Item1 + 1][pixel.Item2].Color = color;
                }

                if (pixel.Item2 - 1 >= 0 && arr[pixel.Item1][pixel.Item2 - 1].Visited == false && arr[pixel.Item1][pixel.Item2 - 1].Color == originalColor)
                {
                    arr[pixel.Item1][pixel.Item2 - 1].Visited = true;
                    arr[pixel.Item1 - 1][pixel.Item2 - 1].Color = color;
                }

                if (pixel.Item2 + 1 < arr.GetLength(0) && arr[pixel.Item1][pixel.Item2 + 1].Visited == false && arr[pixel.Item1][pixel.Item2 + 1].Color == originalColor)
                {
                    arr[pixel.Item1 ][pixel.Item2 + 1].Visited = true;
                    arr[pixel.Item1][pixel.Item2 + 1].Color = color;
                }
            }

        }
    }
}
