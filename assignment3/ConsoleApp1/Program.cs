using System;
/*
抽象类Shape
    Input():输入形状的相关信息
    Legality():判断形状的合法性并返回true/false
    Area():计算面积
子类Rectangle、Square、Triangle
    重写父类中的方法
    添加形状的属性如边长等
*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择你要输入的形状：1、长方形；2、正方形；3、三角形。");
            int choice;
            Console.WriteLine("请输入一个整数");
            while (true)
            {
                try        //异常抛出并重新选择形状
                {
                    if (!int.TryParse(Console.ReadLine(), out choice) || !( choice==1 || choice==2 || choice==3))     
                    {
                        throw new ArgumentException("Input error! Please retype.");
                    }
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            switch (choice)
            {
                case 1:
                {
                        Rectangle Rec = new Rectangle();

                        while (true)
                        {
                            Rec.Input();       
                            bool legal=Rec.Legality();
                            if (!legal)
                            {
                                Console.WriteLine("形状不合法，请重新输入。");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("输入的形状合法。");
                                break;
                            }
                        }
                        double S = Rec.Area();
                        Console.WriteLine($"长方形的面积为{S:f3}。");
                }break;

                case 2:
                    {
                        Square Squ = new Square();
                        while (true)
                        {
                            Squ.Input();
                            bool legal = Squ.Legality();
                            if (!legal)
                            {
                                Console.WriteLine("形状不合法，请重新输入。");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("输入的形状合法。");
                                break;
                            }
                        }
                        double S = Squ.Area();
                        Console.WriteLine($"正方形的面积为{S:f3}。");
                    }break;
                    
                case 3:
                    {
                        Triangle Tri = new Triangle();
                        while (true)
                        {
                            Tri.Input();
                            bool legal = Tri.Legality();
                            if (!legal)
                            {
                                Console.WriteLine("形状不合法，请重新输入。");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("输入的形状合法。");
                                break;
                            }
                        }
                        double S = Tri.Area();
                        Console.WriteLine($"三角形形的面积为{S:f3}。");
                    }break;

                default:break;
                        
            }
        }
        
        abstract class Shape
        {

            public abstract double Area();
            public abstract bool Legality();
            public abstract void Input();
        }

        class Rectangle:Shape
        {
            private double len;
            private double wid;
            private double area;

            public override double Area()
            {
                area = len * wid;
                return area;
            }

            public override bool Legality()
            {
                return wid > 0 && len > 0 ? true : false; 
            }

            public override void Input()
            {
                //throw new NotImplementedException();
                while (true)
                {
                    Console.WriteLine("请输入长方形的长和高");
                    string len1 = Console.ReadLine();
                    string wid1 = Console.ReadLine();
                    try
                    {
                        if (!double.TryParse(len1, out len) || !double.TryParse(wid1, out wid))
                        {
                            throw new ArgumentException("Input error! Please retype.");
                        }
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

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
            public override double Area()
            {
                area = side*side;
                return area;
            }
            public override bool Legality()
            {
                return side > 0 ? true : false;
            }
            public override void Input()
            {
                //throw new NotImplementedException();
                while (true)
                {
                    Console.WriteLine("请输入正方形的边长");
                    string side1 = Console.ReadLine();
                    try
                    {
                        if (!double.TryParse(side1, out side))
                        {
                            throw new ArgumentException("Input error!Please retype.");
                        } 
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
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
            public override double Area()
            {
                double p = (side1 + side2 + side3) / 2;
                area = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
                return area;
            }
            public override bool Legality()
            {
                if(side1>0 &&side2>0&&side3>0)
                {
                    return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1) ? true : false;
                }
                else
                {
                    return false;
                }
                  
            }
            public override void Input()
            {
                //throw new NotImplementedException();
                while (true)
                {
                    Console.WriteLine("请输入三角形的三条边");
                    string side11 = Console.ReadLine();
                    string side22 = Console.ReadLine();
                    string side33 = Console.ReadLine();
                    try
                    {
                        if (!double.TryParse(side11, out side1) || !double.TryParse(side22, out side2) || !double.TryParse(side33, out side3))
                        {
                            throw new ArgumentException("Input error!Please retype.");
                            //Console.WriteLine("输入类型错误，请重新输入。");
                            //continue;
                        }
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

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

    }
}
