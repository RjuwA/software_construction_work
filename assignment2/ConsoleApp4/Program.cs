using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵行数：");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵列数：");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            Console.WriteLine("请输入你的矩阵：");
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool flag = true;
            for(int i=0;i<row-1;i++)
            {
                for (int j = 0; j < col-1; j++)
                {
                    if(matrix[i,j]!=matrix[i+1,j+1])
                    {
                        flag = false;
                        Console.WriteLine("不是托普利茨矩阵");
                        return;
                    }
                }
            }

            if (flag) { Console.WriteLine("是托普利茨矩阵"); }

        }
    }
}
