// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD5_1302223146;
namespace MOD5_1302223146
{
    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T inputAngka1, T inputAngka2, T inputAngka3)
        {
            dynamic temp1 = inputAngka1;
            dynamic temp2 = inputAngka2;
            dynamic temp3 = inputAngka3;

            dynamic hasil = temp1 + temp2 + temp3;

            Console.WriteLine(hasil);




        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan ank = new Penjumlahan();
            ank.JumlahTigaAngka<int>(22, 23, 14);
        }
    }
}


