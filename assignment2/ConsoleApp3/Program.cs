using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] num= new int[n]; 
            for(int i=2;i*i<=n;i++)
            {
                if(num[i]==0)
                {
                    for(int j=2*i;j<n;j=j+i)
                    {
                        num[j] = 1;
                    }
                }
            }
            Console.WriteLine("2~100的所有素数为：");
            for(int k=2;k<n;k++)
            {
                if (num[k] == 0)
                {
                    Console.Write(k + " ");
                }
            }


        }
    }
}
