using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请分别输入两个数字和一个运算符");
            float num1 = int.Parse (Console.ReadLine());
            float num2 = int.Parse (Console.ReadLine());
            char  c = char.Parse (Console.ReadLine());
            float s;
            switch (c)
            {
                case '+': 
                    s = num1 + num2;
                    Console.WriteLine("result="+ s);
                    break;
                case '-': 
                    s = num1 - num2;
                    Console.WriteLine("result=" + s);
                    break;
                case '*': 
                    s = num1 * num2;
                    Console.WriteLine("result=" + s);
                    break;
                case '/':
                    if (num2 == 0) Console.WriteLine("input error");
                    else { s = num1 / num2; Console.WriteLine("result=" + s); }
                    break;
                default:Console.WriteLine("input error");break;
            }

        }
    }
}
