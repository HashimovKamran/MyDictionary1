using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kullanici = new MyDictionary<int, string>();
            kullanici.Add(0, "Kerem");
            kullanici.Add(1, "Ali");
            kullanici.Add(2, "Aykut");
            kullanici.Add(3, "Birkan");
            kullanici.Add(4, "Kaan");

            for (int i = 0; i < kullanici.Count; i++)
            {
                Console.WriteLine(kullanici.Keys[i] + " " + kullanici.Values[i]);
            }
        }
    }
}
