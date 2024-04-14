using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
//using Microsoft.EntityFrameworkCore;
namespace WindowsFormsApp1
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderDbContext : DbContext
    {
        public DbSet<DbOrder> DbOrders { get; set; }
        public DbSet<DbOrderDetails> DbOrderDetails { get; set; }


        public OrderDbContext() : base("name=OrderBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDbContext>()); 
            Database.SetInitializer<OrderDbContext>(null); // 禁用模型兼容性检查
        }

        public OrderDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DbOrderService
    {
        private readonly OrderDbContext dbContext;

        public DbOrderService()
        {
            dbContext = new OrderDbContext();
        }

        public void AddOrder(DbOrder order)
        {

            dbContext.DbOrders.Add(order);
            dbContext.SaveChanges();
        }

        public void DeleteOrder(string orderId)
        {
            var orderToDelete = dbContext.DbOrders.Include(o => o.DbOrderDetails)
                                                 .FirstOrDefault(o => o.OrderID == orderId);
            if (orderToDelete != null)
            {
                foreach (var orderDetail in orderToDelete.DbOrderDetails.ToList())
                {
                    dbContext.DbOrderDetails.Remove(orderDetail);
                }
                dbContext.DbOrders.Remove(orderToDelete);
                dbContext.SaveChanges();
            }
        }
        public void ModifyOrder(string id,string detailid, DbOrder order)
        {
            var oldOrder = dbContext.DbOrders.Include(o => o.DbOrderDetails)
                                              .FirstOrDefault(o => o.OrderID == id);
            if (oldOrder != null)
            {
                // 更新订单的基本信息
                oldOrder.Customer = order.Customer;
                oldOrder.OrderDate = order.OrderDate;

                
                var existingDetail = oldOrder.DbOrderDetails.FirstOrDefault(d => d.OrderDetailsID == detailid);
                if (existingDetail != null)
                {
                    // 删除对应的订单详情
                    dbContext.DbOrderDetails.Remove(existingDetail);
                }

                // 添加新的订单详情
                foreach (var newDetail in order.DbOrderDetails)
                {
                    var detail = new DbOrderDetails
                    {
                        OrderDetailsID = newDetail.OrderDetailsID,
                        ProductName = newDetail.ProductName,
                        Price = newDetail.Price,
                        Quantity = newDetail.Quantity
                    };
                    oldOrder.DbOrderDetails.Add(detail);
                }

                // 保存更改
                dbContext.SaveChanges();
            }
        }

        public void ModifyOrder_AddNewDetail(string id, DbOrder order)
        {
            var oldOrder = dbContext.DbOrders.Include(o => o.DbOrderDetails)
                                              .FirstOrDefault(o => o.OrderID == id);
            if (oldOrder != null)
            {
                // 更新订单的基本信息
                oldOrder.Customer = order.Customer;
                oldOrder.OrderDate = order.OrderDate;

                // 添加新的订单详情
                foreach (var newDetail in order.DbOrderDetails)
                {
                    var detail = new DbOrderDetails
                    {
                        OrderDetailsID = newDetail.OrderDetailsID,
                        ProductName = newDetail.ProductName,
                        Price = newDetail.Price,
                        Quantity = newDetail.Quantity
                    };
                    oldOrder.DbOrderDetails.Add(detail);
                }

                // 保存更改
                dbContext.SaveChanges();
            }
        }
        public DbOrder SearchOrder_ID(string id)
        {
            using (var context = new OrderDbContext())
            {
                var order = context.DbOrders
                                   .Include(o => o.DbOrderDetails)
                                   .FirstOrDefault(o => o.OrderID == id);
                return order;
            }
        }
        public List<DbOrder> SearchOrder_Customer(string customer)
        {
            using (var context = new OrderDbContext())
            {
                var orders = context.DbOrders
                                    .Include(o => o.DbOrderDetails)
                                    .Where(o => o.Customer == customer)
                                    .ToList();
                return orders;
            }
        }

        public List<DbOrder> SearchOrder_Name(string name)
        {
            using (var context = new OrderDbContext())
            {
                var orders = context.DbOrders
                                    .Include(o => o.DbOrderDetails)
                                    .Where(o => o.DbOrderDetails.Any(d => d.ProductName == name))
                                    .ToList();
                return orders;
            }
        }
        public List<DbOrder> ReturnOrders()
        {
            using (var context = new OrderDbContext())
            {
                var orders = context.DbOrders.Include(o => o.DbOrderDetails).ToList();
                if (orders.Count == 0)
                {
                    return null;
                }
                return orders;
            }
        }
        public List<DbOrderDetails> ReturnDetails(string id)
        {
            using (var context = new OrderDbContext())
            {
                var details = context.DbOrderDetails
                                     .Where(detail => detail.OrderID == id)
                                     .ToList();
                return details;
            }
        }
        public List<DbOrderDetails> ReturnAllDetails()
        {
            using (var context = new OrderDbContext())
            {
                var allDetails = context.DbOrderDetails.ToList();
                return allDetails;
            }
        }

    }
    public class DbOrder
    {
        [Key]
        public string OrderID { get; set; }
        //[Required]
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<DbOrderDetails> DbOrderDetails { get; set; } //一对多关联
    
        public DbOrder(string id, string customer)
        {
            OrderID= id;
            Customer = customer;
            DbOrderDetails = new List<DbOrderDetails>();
        }
        public DbOrder()
        {
            OrderID = "";
            Customer = "";
            DbOrderDetails = new List<DbOrderDetails>();
        }

    }

    public class DbOrderDetails
    {
        [Key, Column(Order = 0)]
        public string OrderDetailsID { get; set; }
        [Key, Column(Order = 1)]
        public string OrderID{ get; set; } // 自动识别为外键，指向 Order 表的 OrderID
        [ForeignKey("OrderID")]
        public DbOrder DbOrder { get; set; } //多对一关联
       // [Required]
        public string ProductName { get; set; }
        //[Required]
        public double Price { get; set; }
       // [Required]
        public int Quantity { get; set; }
        private decimal _amount;
        public decimal Amount
        {
            get { _amount = (decimal)(Quantity * Price); return _amount; }
            set { _amount = value; }
        }
        public DbOrderDetails(string id, string pname, double price, int quantity)
        {
            OrderDetailsID = id;
            ProductName = pname;
            Price = price;
            Quantity = quantity;
        }
        public DbOrderDetails()
        {
            OrderDetailsID = "";
            ProductName = "";
            Price = 0;
            Quantity = 0;
        }
    }
}
