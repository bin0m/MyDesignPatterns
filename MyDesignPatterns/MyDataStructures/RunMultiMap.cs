using System;
namespace MyDesignPatterns.MyDataStructures
{
    class RunMultiMap : IRunInConsole
    {
        public void Run()
        {
            bool b1 = true;
            bool b2 = false;
            bool b3 = false;

            MultiMap<bool> m1 = new MultiMap<bool>();
            m1.Add("key1", b1);
            m1.Add("key1", b2);
            m1.Add("key2", b3);

            foreach (string k in m1.Keys)
            {
                foreach (bool b in m1[k])
                {
                    Console.WriteLine(k + "=" + b);
                }
            }
        }
    }
}
