using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Form1());
            //var dborderservice = new DbOrderService();
            /*var order1 = new DbOrder
            {
                OrderID = "0001",
                Customer = "Amy",
                OrderDate = DateTime.Now,
                DbOrderDetails = new List<DbOrderDetails>
                {
                    new DbOrderDetails
                    {
                        OrderDetailsID = "A0001",
                        ProductName = "apple",
                        Price = 5.5,
                        Quantity = 3
                    },
                    new DbOrderDetails
                    {
                        OrderDetailsID = "A0002",
                        ProductName = "banana",
                        Price = 11,
                        Quantity =2
                    }
                }
            };

           dborderservice.AddOrder(order1);

           var order2 = new DbOrder
           {
               OrderID = "0002",
               Customer = "Ben",
               OrderDate = DateTime.Now,
               DbOrderDetails = new List<DbOrderDetails>
               {
                   new DbOrderDetails
                   {
                       OrderDetailsID = "A0003",
                       ProductName = "pear",
                       Price = 15,
                       Quantity = 2
                   },
               }
           };
           dborderservice.AddOrder(order2);*/
            /* var order3 = new DbOrder
             {
                 OrderID = "0003",
                 Customer = "Cary",
                 OrderDate = DateTime.Now,
                 DbOrderDetails = new List<DbOrderDetails>
                 {
                     new DbOrderDetails
                     {
                         OrderDetailsID = "A0004",
                         ProductName = "peach",
                         Price = 15,
                         Quantity = 2
                     },
                 }
             };
             dborderservice.AddOrder(order3);
             var order4 = new DbOrder
             {
                 OrderID = "0004",
                 Customer = "Denny",
                 OrderDate = DateTime.Now,
                 DbOrderDetails = new List<DbOrderDetails>
                 {
                     new DbOrderDetails
                     {
                         OrderDetailsID = "A0005",
                         ProductName = "apple",
                         Price = 5.5,
                         Quantity = 12
                     },
                 }
             };
             dborderservice.AddOrder(order4);
           */
            // dborderservice.DeleteOrder("0002");
            /*var _order = new DbOrder
            {
                OrderID = "0007",
                Customer = "Mike",
                OrderDate = DateTime.Now,
                DbOrderDetails = new List<DbOrderDetails>
                 {
                     new DbOrderDetails
                     {
                         OrderDetailsID = "A0010",
                         ProductName = "watermelon",
                         Price = 0.7,
                         Quantity =21
                     },
                 }
            };
            dborderservice.ModifyOrder("0001",_order);*/

        }
    }
}
