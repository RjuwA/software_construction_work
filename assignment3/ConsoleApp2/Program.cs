using System;
/*
抽象类Shape
    CalcuArea()：计算面积
子类Rectangle、Square、Triangle
    构造函数初始化形状信息
    重写父类中的方法CalcuArea
工厂CreateShape
    随机数产生对应形状的相关信息
*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] type = new int[10];
            Random rd = new Random();
            double sum = 0.0;
            for (int i = 0; i < 10; i++)//产生10个形状的类型并计算面积和
            {
                type[i] = rd.Next(1, 4);
                Shape shape = ShapeFactory.CreateShape(type[i]);
                sum += shape.CalcuArea();
                if (type[i] == 1) { Console.WriteLine($"此长方形面积为{shape.CalcuArea():f3}"); }
                else if (type[i] == 2) { Console.WriteLine($"此正方形面积为{shape.CalcuArea():f3}"); }
                else if (type[i] == 3) { Console.WriteLine($"此三角形面积为{shape.CalcuArea():f3}"); }
            }
            Console.WriteLine($"总面积为{sum:f3}");
        }

        abstract class Shape
        {
            public abstract double CalcuArea();
        }

        class Rectangle : Shape
        {
            private double len;
            private double wid;
            private double area;
            public Rectangle(double len1,double wid1)
            {
                len = len1;
                wid = wid1;
            }
            public override double CalcuArea()
            {
                area = len * wid;
                return area;
            }
            public double Length
            {
                get { return len; }
                set { len = value; }
            }
            public double Width
            {
                get { return wid; }
                set { wid = value; }
            }

        }

        class Square : Shape
        {
            private double side;
            private double area;
            public Square(double side1)
            {
                side = side1;
            }
            public override double CalcuArea()
            {
                area = side * side;
                return area;
            }
            public double Side
            {
                get { return side; }
                set { side = value; }
            }


        }

        class Triangle : Shape
        {
            private double side1;
            private double side2;
            private double side3;
            private double area;
            public Triangle(double side11,double side22, double side33)
            {
                side1 = side11;
                side2 = side22;
                side3 = side33;
            }
            public override double CalcuArea()
            {
                double p = (side1 + side2 + side3) / 2;
                area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                return area;
            }
            public double Side1
            {
                get { return side1; }
                set { side1 = value; }
            }
            public double Side2
            {
                get { return side2; }
                set { side2 = value; }
            }
            public double Side3
            {
                get { return side3; }
                set { side3 = value; }
            }

        }

        class ShapeFactory
        {
            public static Shape CreateShape(int num)
            {
                Random random = new Random();
                switch (num)
                {
                    case 1:
                        {
                            double len1 = 0.0;
                            double wid1 = 0.0;
                            while (len1 == 0.0) { len1 = random.NextDouble() * 10; }
                            while (wid1 == 0.0) { wid1 = random.NextDouble() * 10; }
                            return new Rectangle(len1,wid1);
                        }
                    case 2:
                        {
                            double side1 = 0.0;
                            while (side1 == 0.0) { side1 = random.NextDouble() * 10; }
                            return new Square(side1);
                        }
                    case 3:
                        {
                            double side1 = 0.0;
                            double side2 = 0.0;
                            double side3 = 0.0;
                            while (side1 == 0.0) { side1 = random.NextDouble() * 10; }
                            while (side2 == 0.0) { side2 = random.NextDouble() * 10; }
                            while (side3 == 0.0) { side3 = random.NextDouble() * (Math.Min(2*side1,2*side2))+Math.Abs(side1-side2); }
                            return new Triangle(side1, side2, side3);
                        }
                    default:return null;
                }
            }
      
        }
    }
}
