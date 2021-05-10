using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            int adet = 0;
            
            string sesli = "a,e,i,ı,o,ö,u,ü";
            Console.Write("Bir cümle giriniz :");
            cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int k = 0; k < cumle.Length; k++)
                {
                    if (cumle[i] == sesli[k])
                    {
                        adet++;
                    }
                }
                
            }
            Console.WriteLine("Sesli harf sayısı :{0}", adet);
            Console.ReadKey();
        }
    }
}
