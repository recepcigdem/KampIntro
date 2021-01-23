using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();

            myDict.Add(34, "İstanbul");
            myDict.Add(6, "Ankara");
            myDict.Add(35, "İzmir");
            myDict.Add(54, "Sakarya");
            myDict.Add(16, "Bursa");

            for (int i = 0; i < myDict.keys.Length; i++)
            {
                Console.WriteLine(myDict.keys[i] + " -> " + myDict.values[i]);
            }

        }
    }
}
