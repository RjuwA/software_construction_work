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

        }
        /*
        public void AddTest()
        {
           
            Console.SetIn(new StringReader("0001\nAmy\napple\n5.5\n10\nY\n"
                                          +"0002\nBen\nbanana\n7\n5\nY\n"
                                          +"0003\nCary\ncherry\n20\n2\nY\n"
                                          +"0004\nDoggy\ndurian\n10\n3\nN\n"));
            var output = new StringWriter();
            Console.SetOut(output);
            OrderService orderService = new OrderService();
            orderService.AddOrder();
            string s= output.ToString();
            string[] targets = { "还要继续添加吗？（Y/N�?, "请输入订单号�?,"请输入客户名�?,"请输入产品名称：","请输入单价：","请输入购买数量：" };
            foreach (string target in targets)
            {
                s = s.Replace(target, "");
            }
            string ExpectedOutput = /*"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+ */
<<<<<<< HEAD
                      /*            "������: 0001       �ͻ�: Amy        ��Ʒ: apple      ����: 10         ����: 5.5        �ܽ��: 55\n"
                                   +"������: 0002       �ͻ�: Ben        ��Ʒ: banana     ����: 5          ����: 7          �ܽ��: 35\n"
                                   +"������: 0003       �ͻ�: Cary       ��Ʒ: cherry     ����: 2          ����: 20         �ܽ��: 40\n"
                                   +"������: 0004       �ͻ�: Doggy      ��Ʒ: durian     ����: 3          ����: 10         �ܽ��: 30\n";
=======
                                    "订单�? 0001       客户: Amy        产品: apple      数量: 10         单价: 5.5        总金�? 55\n"
                                   +"订单�? 0002       客户: Ben        产品: banana     数量: 5          单价: 7          总金�? 35\n"
                                   +"订单�? 0003       客户: Cary       产品: cherry     数量: 2          单价: 20         总金�? 40\n"
                                   +"订单�? 0004       客户: Doggy      产品: durian     数量: 3          单价: 10         总金�? 30\n";
>>>>>>> 6dcca91692db77a5b8f2a226f1db94bc959d72e1
            Assert.AreEqual(ExpectedOutput,s);
        }*/

  

    }
}
