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


    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>(); 
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan ank = new Penjumlahan();
            ank.JumlahTigaAngka<int>(22, 23, 14);
            SimpleDataBase<int> dt = new SimpleDataBase<int>();
            dt.AddNewData(12);
            dt.AddNewData(34);
            dt.AddNewData(56);
            dt.printAllData();

        }
    }
}


