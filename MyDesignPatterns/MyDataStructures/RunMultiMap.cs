using System;
namespace MyDesignPatterns.MyDataStructures
{
    class RunMultiMap : IRunInConsole
    {
        public void Run()
        {
            // use MultiMap with strings to store names within categories
            const string s1 = "cat";
            const string s2 = "dog";

            MultiMap<string> m1 = new MultiMap<string>();
            m1.Add("animal", s1);
            m1.Add("animal", s2);
            m1.Add("human", "tom");
            m1.Add("human", "tim");
            m1.Add("human", "jack");
            m1.Add("mineral", "calcium");

            foreach (string k in m1.Keys)
            {
                foreach (string v in m1[k])
                {
                    Console.WriteLine(k + "=" + v);
                }
            }
        }
    }
}
