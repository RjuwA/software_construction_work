using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using System.IO;
namespace TestProject1
{

    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void AddTest()
        {
            /* 
             Order TestOrder = new Order();
             List<Order> order = new List<Order>();
            */
            Console.SetIn(new StringReader("0001\nAmy\napple\n5.5\n10\nY\n"
                                          +"0002\nBen\nbanana\n7\n5\nY\n"
                                          +"0003\nCary\ncherry\n20\n2\nY\n"
                                          +"0004\nDoggy\ndurian\n10\n3\nN\n"));
            var output = new StringWriter();
            Console.SetOut(output);
            OrderService orderService = new OrderService();
            orderService.AddOrder();
            string s= output.ToString();
            string[] targets = { "��Ҫ��������𣿣�Y/N��", "�����붩���ţ�","������ͻ�����","�������Ʒ���ƣ�","�����뵥�ۣ�","�����빺��������" };
            foreach (string target in targets)
            {
                s = s.Replace(target, "");
            }
            string ExpectedOutput = /*"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+ */
                                    "������: 0001       �ͻ�: Amy        ��Ʒ: apple      ����: 10         ����: 5.5        �ܽ��: 55\n"
                                   +"������: 0002       �ͻ�: Ben        ��Ʒ: banana     ����: 5          ����: 7          �ܽ��: 35\n"
                                   +"������: 0003       �ͻ�: Cary       ��Ʒ: cherry     ����: 2          ����: 20         �ܽ��: 40\n"
                                   +"������: 0004       �ͻ�: Doggy      ��Ʒ: durian     ����: 3          ����: 10         �ܽ��: 30\n";
            Assert.AreEqual(ExpectedOutput,s);
        }

       /* [TestMethod]
        public void AddTest1()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("0001","Amy");
            order1.AddDetail(new OrderDetails("apple",5.5,3));
            orderService.AddOrder1(order1);
            Assert.AreEqual(order1, ("0001","Amy","apple",5.5,3));
        }*/

    }
}
