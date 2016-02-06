using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Week2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Users\Admin\Downloads\myc#texts\my.txt");
            {
                string st;
                int maxi = -10000000;
                int mini = 100000000;

                while ((st = file.ReadLine()) != null)
                {
                    int a = int.Parse(st);
                    if (a > maxi)
                    {
                        maxi = a;


                    }
                    if (a < mini)
                    {
                        mini = a;

                    }
                }

                Console.WriteLine("Max is" + maxi + "Min" + mini);
            }
            Console.ReadKey();



        }
    }
}

