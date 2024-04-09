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
            string[] targets = { "杩樿缁х画娣诲姞鍚楋紵锛圷/N锛?, "璇疯緭鍏ヨ鍗曞彿锛?,"璇疯緭鍏ュ鎴峰悕锛?,"璇疯緭鍏ヤ骇鍝佸悕绉帮細","璇疯緭鍏ュ崟浠凤細","璇疯緭鍏ヨ喘涔版暟閲忥細" };
            foreach (string target in targets)
            {
                s = s.Replace(target, "");
            }
            string ExpectedOutput = /*"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+ */
<<<<<<< HEAD
                      /*            "订单号: 0001       客户: Amy        产品: apple      数量: 10         单价: 5.5        总金额: 55\n"
                                   +"订单号: 0002       客户: Ben        产品: banana     数量: 5          单价: 7          总金额: 35\n"
                                   +"订单号: 0003       客户: Cary       产品: cherry     数量: 2          单价: 20         总金额: 40\n"
                                   +"订单号: 0004       客户: Doggy      产品: durian     数量: 3          单价: 10         总金额: 30\n";
=======
                                    "璁㈠崟鍙? 0001       瀹㈡埛: Amy        浜у搧: apple      鏁伴噺: 10         鍗曚环: 5.5        鎬婚噾棰? 55\n"
                                   +"璁㈠崟鍙? 0002       瀹㈡埛: Ben        浜у搧: banana     鏁伴噺: 5          鍗曚环: 7          鎬婚噾棰? 35\n"
                                   +"璁㈠崟鍙? 0003       瀹㈡埛: Cary       浜у搧: cherry     鏁伴噺: 2          鍗曚环: 20         鎬婚噾棰? 40\n"
                                   +"璁㈠崟鍙? 0004       瀹㈡埛: Doggy      浜у搧: durian     鏁伴噺: 3          鍗曚环: 10         鎬婚噾棰? 30\n";
>>>>>>> 6dcca91692db77a5b8f2a226f1db94bc959d72e1
            Assert.AreEqual(ExpectedOutput,s);
        }*/

  

    }
}
