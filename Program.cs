using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RemoveDupliactesSolution _RemoveDupliactesSolution=new RemoveDupliactesSolution();
            int reuslt = _RemoveDupliactesSolution.RemoveDupliactes(new int[3] {1,1,2});
            Console.WriteLine(reuslt.ToString());
        }
    }
}
