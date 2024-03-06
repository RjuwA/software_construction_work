using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            string input= Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine("它的所有素数为：");
            int flag1 = 1;
            for (int i=2;i<=Math.Sqrt(n);i++)
            {
                while(n%i==0)
                {
                    if (n == 1) { break; }
                    if(flag1!=i)
                    {
                        Console.Write(i + " ");
                        flag1 = i;
                    }        
                    n = n / i;
                }
            }
            if(n!=1)
            {
                Console.WriteLine(n);
            }
        }
    }
}
