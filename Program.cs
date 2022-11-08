using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace anhyeuemnhieulam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int count = 0;
            for(float y = 3f; y > -2f; y -= 0.1f)
            {
                for(float x=-2.5f; x < 2.5f; x += 0.04f)
                {
                    float a = x * x + y * y - 4f;
                    if((a*a*a-x*x * y * y * y) < -0.0f)
                    {
                        String str = " ANH YÊU HIỀN LƯƠNG ";
                        int num = count % str.Length;
                        Console.Write(str[num]);
                        count++;    
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Thread.Sleep(100);
            }
            Console.WriteLine("Đức văn cntt1405 , đại học Đại Nam ");
            Console.ReadLine();
        }
    }
}
