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
            string[] targets = { "还要继续添加吗？（Y/N）", "请输入订单号：","请输入客户名：","请输入产品名称：","请输入单价：","请输入购买数量：" };
            foreach (string target in targets)
            {
                s = s.Replace(target, "");
            }
            string ExpectedOutput = /*"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+ */
                                    "订单号: 0001       客户: Amy        产品: apple      数量: 10         单价: 5.5        总金额: 55\n"
                                   +"订单号: 0002       客户: Ben        产品: banana     数量: 5          单价: 7          总金额: 35\n"
                                   +"订单号: 0003       客户: Cary       产品: cherry     数量: 2          单价: 20         总金额: 40\n"
                                   +"订单号: 0004       客户: Doggy      产品: durian     数量: 3          单价: 10         总金额: 30\n";
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
