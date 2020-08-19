using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SS2
{
    class Program
    {
        static int x = -6;
        static void Main(string[] args)
        {
            do
            {            
            s: ForegroundColor = ConsoleColor.Magenta;
            SetCursorPosition(WindowWidth/2-5, x+=6);
            Console.WriteLine("Calculator");
            ResetColor();
            int y = int.Parse(ReadLine());
            string s = ReadLine();
            int z = int.Parse(ReadLine());
            int res=0;
            switch (s)
            {
                case "+":
                    res = y + z;
                    break;
                case "-":
                    res = y - z;
                    break;
                case "*":
                    res = y * z;
                    break;
                case "/":
                        if (z == 0)
                        {
                            ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Usumnasireq matematika !!!");
                            ResetColor();
                            goto s;
                        }
                    res = y / z;
                    break;
                default:
                        ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nshani sxal !!!");
                        ResetColor();
                        goto s;
                        break;
            }
            ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine(y+s+z+"="+res);
            ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tsragiry sharunakelu hamar sexmeq 'Enter'... ");
            } while (ReadKey().Key==ConsoleKey.Enter);
        }
    }
}
