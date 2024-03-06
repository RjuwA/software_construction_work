using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int len = 10;   //假设有10个数
            int[] num =new int[10];
            for(int i=0;i<len;i++)
            {
                num[i] = int.Parse(Console.Read());
            }*/
            int[] num = { -10,20,30,50,100};
            int max=-1000, min=100000, sum=0;
            float ave;
            foreach(int i in num)
            {
                if (i > max) { max = i; }
            }
            Console.WriteLine("整数数组的最大值为："+max);
            foreach (int i in num)
            {
                if (i < min) { min =i; }
            }
            Console.WriteLine("整数数组的最小值为：" + min);
            foreach (int i in num)
            {
                sum += i;
            }
            Console.WriteLine("整数数组的和为：" + sum);
            ave = sum / (float)num.Length;
            Console.WriteLine("整数数组的平均值为：" + ave);
        }
    }
}
