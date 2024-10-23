using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararyapılarıIf_ElseIf_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time < 11)
            {
                Console.WriteLine("günaydın");
            }
           else if (time <= 18)
            {
                Console.WriteLine("iyi günler");

            }
            else
            {
                Console.WriteLine("iyi geceler");
                string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
                Console.WriteLine(sonuc);
            }
        }
    }
}
