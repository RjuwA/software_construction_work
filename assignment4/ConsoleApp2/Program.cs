using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SubForm clockform1 = new SubForm();
            clockform1.clock.SetTime();  //设置闹钟时间
            clockform1.clock.Countdown(clockform1.clock.Count);
        }
    }

    public delegate void ClockEvent(object sender);

    public class Clock
    {
        public event ClockEvent Tick;
        public event ClockEvent Alarm;
        private int hour,minute,second;
        private int count;
        public void SetTime()
        {
            try
            {
                Console.WriteLine("请设置闹钟的时分秒");

                Console.WriteLine("时:");
                hour = int.Parse(Console.ReadLine());
                if (hour < 0 || hour > 23)
                {
                    throw new ArgumentException("时应在0到23之间");
                }

                Console.WriteLine("分:");
                minute = int.Parse(Console.ReadLine());
                if (minute < 0 || minute > 59)
                {
                    throw new ArgumentException("分应在0到59之间");
                }

                Console.WriteLine("秒:");
                second = int.Parse(Console.ReadLine());
                if (second < 0 || second > 59)
                {
                    throw new ArgumentException("秒应在0到59之间");
                }

                count = hour * 3600 + minute * 60 + second;
                Console.WriteLine($"你输入的闹钟为{hour:00}:{minute:00}:{second:00}");
            }
            catch (FormatException)
            {
                Console.WriteLine("输入错误，请输入数字");
                SetTime(); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("错误: " + ex.Message);
                SetTime(); 
            }
        }
        public int Count 
        {
            get { return count; }
            set { count = value; }
        }
        public void Countdown(int count)
        {       
            for(int i = count;i >= 0;i--)
            {
                if (i == 0)
                {
                    Alarm(this);
                }
                else
                {
                    Thread.Sleep(1000);
                    Tick(this); 
                }
            }
        }




    }

    public class SubForm
    {
        public Clock clock = new Clock();
        public SubForm()
        {
            clock.Alarm += new ClockEvent(OnAlarm);
            clock.Tick += new ClockEvent(OnTick);
        }
        void OnAlarm(object sender)
        {
            Console.WriteLine("Alarm!");
        }
        void OnTick(object sender)
        {
            Console.WriteLine("Tick!");
        }
    }
}
