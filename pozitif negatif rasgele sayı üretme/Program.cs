using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitif_negatif_rasgele_sayı_üretme
{
    internal class Program
    {
        static void Main(string[] args)
        { Random rasgele=new Random();
            int üretilensayı;
            int ps = 0, ns = 0;
            for(int i = 0; i<50;i++)
            {
                üretilensayı = rasgele.Next(-100,100);
                Console.WriteLine(üretilensayı+",");
                if (üretilensayı > 0)
                {
                    ps++; 
                }
                else if (üretilensayı < 0) 
                {
                    ns++;
                }
                Console.WriteLine($"\n50 adet sayıdan {ps}tanesi pozitif, {ns} tanesi negatiftir.");
                Console.ReadKey();





            }
        }
    }
}
