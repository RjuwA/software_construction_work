using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService test = new OrderService();
            while (true)
            {
                Console.WriteLine("请选择你要进行的操作：1：添加订单；2：删除订单；3：修改订单；4：查询订单；5：查看所有订单");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("无效的选择，请重新输入：");
                }
                string[] operation = { "add", "delete", "modify", "search", "show" };
                switch (operation[choice - 1])
                {
                    case "add":
                        test.AddOrder();
                        break;
                    case "delete":
                        test.DeleteOrder();
                        break;
                    case "modify":
                        test.ModifyOrder();
                        break;
                    case "search":
                        test.SearchOrder();
                        break;
                    case "show":
                        test.ShowAllOrders();
                        break;
                    default: break;
                }
            }
        }
    }
    public class OrderDetails
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int  Quantity{ get; set; }
        private double _amount;
        public double Amount 
        {
            get { _amount = Quantity * Price; return _amount ; }
            set { _amount = value; }
        }
        public OrderDetails()
        {
            this.Name = "";
            this.Price = 0.0;
            this.Quantity = 0;
            this.Amount =0.0;
        }
        public OrderDetails(string name,double price,int quantity )
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public override string ToString()
        {
            return $"产品: {Name,-10} 数量: {Quantity,-10} 单价: {Price,-10} 总金额: {Amount,-10}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            OrderDetails example= (OrderDetails)obj ;//转换异常待写
            return (example.Name == Name) && (example.Quantity == Quantity) && (example.Price == Price);
        }
        public override int GetHashCode()  //?
        {
            int hash = 17;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Quantity.GetHashCode();
            hash = hash * 23 + Price.GetHashCode();
            return hash;
        }

    }
    public class Order
    {
        public string ID { get; set; }
        public string Customer { get; set; }
        public OrderDetails Details { get; set; }
        public Order()
        {
            ID = "";
            Customer = "";
            Details = new OrderDetails();
        }
        public Order(string id, string customer)
        {
            ID = id;
            Customer = customer;
            Details = new OrderDetails();
        }
        public void AddDetail(OrderDetails Newdetail)
        {
            Details.Name = Newdetail.Name;
            Details.Price = Newdetail.Price;
            Details.Quantity = Newdetail.Quantity;
        }
        public override string ToString()
        {
            return $"订单号: {ID,-10} 客户: {Customer,-10} {Details}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Order example = (Order)obj;//转换异常待写
            return (example.ID == ID);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + ID.GetHashCode();
            hash = hash * 23 + Customer.GetHashCode();
            return hash;
        }
    }
    public class OrderService
    {
        private List<Order> order = new List<Order>();
        public void AddOrder()
        {
            string add_flag = "Y";
            while (add_flag == "Y" || add_flag == "y")
            {
                Console.WriteLine("请输入订单号：");
                string id = Console.ReadLine();
                Console.WriteLine("请输入客户名：");
                string customer = Console.ReadLine();
                Order NewOrder = new Order(id, customer);
                while (order.Any(order => order.ID == NewOrder.ID))
                {
                    Console.WriteLine("订单重复，请重新输入订单号：");
                    id = Console.ReadLine();
                    Console.WriteLine("请输入客户名：");
                    customer = Console.ReadLine();
                    NewOrder = new Order(id, customer);
                }
                Console.WriteLine("请输入产品名称：");
                string name = Console.ReadLine();
                Console.WriteLine("请输入单价：");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("无效的单价，请重新输入：");
                }
                Console.WriteLine("请输入购买数量：");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("无效的数量，请重新输入：");
                }
                OrderDetails detail = new OrderDetails(name, price, quantity);
                NewOrder.Details = detail;
                order.Add(NewOrder);

                //Console.WriteLine("你添加的订单如下：");
                //ShowOneOrder(id);
                Console.WriteLine("还要继续添加吗？（Y/N）");
                add_flag = Console.ReadLine();
            }
            ShowAllOrders();
        }
        public void DeleteOrder()
        {
            Console.WriteLine("输入需要删除订单的订单号：");
            string id = Console.ReadLine();
            Order _order = order.FirstOrDefault(ex => ex.ID == id);
            if (_order != null)
            {
                order.Remove(_order); 
            }
            else
            {
                Console.WriteLine("未找到相应的订单");
            }
        }
        public void ModifyOrder()
        {
            Console.WriteLine("输入需要修改订单的订单号：");
            string id = Console.ReadLine();
            Console.WriteLine("你修改的订单如下：");
            ShowOneOrder(id);
            Order _order = order.FirstOrDefault(ex => ex.ID == id);
            if (order != null)
            {
                string modify_flag = "Y";
                while(modify_flag=="Y"|| modify_flag == "y") 
                {
                    Console.WriteLine("你需要修改哪一项：1：订单号；2：客户名；3：产品；4：单价；5：数量");
                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("无效的购买数量，请重新输入：");
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("请输入新的订单号：");
                            string new_id = Console.ReadLine();
                            id = new_id;
                            _order.ID = new_id;break;
                        case 2:
                            Console.WriteLine("请输入新的客户名：");
                            string new_customer = Console.ReadLine();
                            _order.Customer = new_customer; break;
                        case 3:
                            Console.WriteLine("请输入新的产品名：");
                            string new_name = Console.ReadLine();
                            _order.Details.Name = new_name; break;
                        case 4:
                            Console.WriteLine("请输入新的单价：");
                            double new_price;
                            while (!double.TryParse(Console.ReadLine(), out new_price))
                            {
                                Console.WriteLine("无效的单价，请重新输入：");
                            }
                            _order.Details.Price = new_price; break;
                        case 5:
                            Console.WriteLine("请输入新的数量：");
                            int new_quantity;
                            while (!int.TryParse(Console.ReadLine(), out new_quantity))
                            {
                                Console.WriteLine("无效的购买数量，请重新输入：");
                            }
                            _order.Details.Quantity = new_quantity; break;
                        default: break;
                    }
                    Console.WriteLine("还需要修改吗？（Y/N）");
                    modify_flag = Console.ReadLine();
                }
            }
            else
            {
                throw new InvalidOperationException("没有找到相应的订单");
            }
            Console.WriteLine("修改后的订单如下：");
            ShowOneOrder(id);
        }
        public void SearchOrder()  
        {
            Console.WriteLine("查询方式：1：订单号；2：客户名；3：产品；4：总金额");
            int choice1;
            string[] operation1 = { "id", "customer", "name", "amount" };

            while (!int.TryParse(Console.ReadLine(), out choice1))
            {
                Console.WriteLine("无效的选择，请重新输入：");
            }
            switch (operation1[choice1-1])
            {
                case "id":
                    {
                        Console.WriteLine("请输入订单号：");
                        string id = Console.ReadLine();
                        ShowOneOrder(id);
                        break;
                    }  
                case "customer":
                    {
                        Console.WriteLine("请输入客户名：");
                        string customer = Console.ReadLine();
                        var set1 = from ex in order
                                    where customer == ex.Customer
                                    orderby ex.Details.Amount descending
                                    select ex;
                        List<Order> order1 = set1.ToList();
                        ShowSomeOrders(order1);
                        break;
                    }
                case "name":
                    {
                        Console.WriteLine("请输入产品名：");
                        string name = Console.ReadLine();
                        var set2 = from ex in order
                                    where name == ex.Details.Name
                                    orderby ex.Details.Amount descending
                                    select ex;
                        List<Order> order2 = set2.ToList();
                        ShowSomeOrders(order2);
                        break;
                    }
                case "amount":
                    {
                        Console.WriteLine("请输入总金额查询的方式：1：最大值；2：最小值；3：区间");
                        int choice2;
                        string[] operation2 = { "max", "min", "min-max" };
                        while (!int.TryParse(Console.ReadLine(), out choice2))
                        {
                            Console.WriteLine("无效的选择，请重新输入：");
                        }
                        double max_amount, min_amount;
                        if (operation2[choice2-1] == "max")
                        {
                            Console.WriteLine("请输入最大值:");
                            while (!double.TryParse(Console.ReadLine(), out max_amount))
                            {
                                Console.WriteLine("无效的最大值，请重新输入：");
                            }
                            var set3 = from ex in order
                                        where ex.Details.Amount<= max_amount
                                        orderby ex.Details.Amount descending
                                        select ex;
                            List<Order> order3= set3.ToList();
                            ShowSomeOrders(order3);
                        }
                        else if (operation2[choice2 - 1] == "min")
                        {
                            Console.WriteLine("请输入最小值:");
                            while (!double.TryParse(Console.ReadLine(), out min_amount))
                            {
                                Console.WriteLine("无效的最小值，请重新输入：");
                            }
                            var set4 = from ex in order
                                        where ex.Details.Amount >= min_amount
                                        orderby ex.Details.Amount descending
                                        select ex;
                            List<Order> order4 = set4.ToList();
                            ShowSomeOrders(order4);
                        }
                        else if(operation2[choice2 - 1] == "min-max")
                        {
                            Console.WriteLine("请输入最小值:");
                            while (!double.TryParse(Console.ReadLine(), out min_amount))
                            {
                                Console.WriteLine("无效的最小值，请重新输入：");
                            }
                            Console.WriteLine("请输入最大值:");
                            while (!double.TryParse(Console.ReadLine(), out max_amount))
                            {
                                Console.WriteLine("无效的最大值，请重新输入：");
                            }
                            var set5 = from ex in order
                                        where ex.Details.Amount >= min_amount  && ex.Details.Amount <= max_amount
                                        orderby ex.Details.Amount descending
                                        select ex;
                            List<Order> order5 = set5.ToList();
                            ShowSomeOrders(order5);
                        }
                        break;
                    }
                       
                default:break;
            }


        }
        public void ShowOneOrder(string id)
        {
            Order _order = order.FirstOrDefault(ex => ex.ID == id);
            if (_order != null)
            {
                Console.WriteLine($"订单号: {_order.ID,-10} 客户: {_order.Customer,-10} {_order.Details}");
            }
            else
            {
                Console.WriteLine("未找到相应的订单");
            }
        }
        public void ShowSomeOrders(List<Order>some_orders )
        {

            if (some_orders.Count>0)
            {
                foreach (Order _order in some_orders)
                {
                    Console.WriteLine($"订单号: {_order.ID,-10} 客户: {_order.Customer,-10} {_order.Details}");
                }
            }
            else
            {
                Console.WriteLine("未找到相应的订单");
            }
           
        }
        public void ShowAllOrders()
        {
            var set = from ex in order
                        where true
                        orderby ex.ID 
                        select ex;
            List<Order> order1 = set.ToList();
            foreach (Order _order in order1)
            {
                Console.WriteLine($"订单号: {_order.ID,-10} 客户: {_order.Customer,-10} {_order.Details}");
            }
        }

        public void AddOrder1(Order neworder)
        {
            if (!order.Any(ex => ex.ID == neworder.ID))
            {
                order.Add(neworder);
            }
        }
    }
}
