using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public DbOrderService DbOrderService2
        {
            get { return dborderservice2; }
            set { dborderservice2 = value;}
        }
        private DbOrderService dborderservice2 = new DbOrderService();
        private BindingList<DbOrder> bd_orderList = new BindingList<DbOrder>();
        private BindingList<DbOrderDetails> bd_detailsList = new BindingList<DbOrderDetails>();
        public Form2(DbOrderService ex)
        {
            //BindingSource bindingSource1 = new BindingSource();
            // BindingSource bindingSource2 = new BindingSource();
            //dataGridView1.DataSource = bindingSource1;
            //dataGridView2.DataSource = bindingSource2;
            InitializeComponent();
            dborderservice2 = ex;
            dataGridView1.DataSource = bd_orderList;
            dataGridView2.DataSource = bd_detailsList;
            
        }
      

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!IsAddValidInput())
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbOrder existingOrder = dborderservice2.SearchOrder_ID(textBox_id.Text);
            if (existingOrder == null)
            {
                var _order = new DbOrder
                {
                    OrderID = textBox_id.Text,
                    Customer = textBox_customer.Text,
                    OrderDate = DateTime.Now,
                    DbOrderDetails = new List<DbOrderDetails>
                 {
                     new DbOrderDetails
                     {
                         OrderDetailsID = textBox_detailid.Text,
                         ProductName = textBox_name.Text,
                         Price = double.Parse(textBox_price.Text),
                         Quantity =int.Parse(textBox_quantity.Text)
                     },
                 }
                };

                dborderservice2.AddOrder(_order);
                bd_orderList.Add(_order);
                foreach (var ex in _order.DbOrderDetails)
                {
                    bd_detailsList.Add(ex);
                }
            }
            else
            {
                existingOrder.OrderDate = DateTime.Now;
                existingOrder.DbOrderDetails.Add(new DbOrderDetails
                {
                    OrderDetailsID = textBox_detailid.Text,
                    ProductName = textBox_name.Text,
                    Price = double.Parse(textBox_price.Text),
                    Quantity = int.Parse(textBox_quantity.Text)
                });
                dborderservice2.ModifyOrder_AddNewDetail(existingOrder.OrderID, existingOrder);
                bd_orderList.Add(existingOrder);
                foreach (var ex in existingOrder.DbOrderDetails)
                {
                    bd_detailsList.Add(ex);
                }
            }
           
            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dborderservice2.ReturnOrders();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dborderservice2.ReturnAllDetails();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_modifyid.Text)|| string.IsNullOrWhiteSpace(textBox_modifydetailid.Text))
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbOrder modify_order = dborderservice2.SearchOrder_ID(textBox_modifyid.Text);

            if (modify_order==null)
            {
                MessageBox.Show("订单未找到！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var _order = new DbOrder
            {
                OrderID = textBox6.Text,
                Customer = textBox5.Text,
                OrderDate = DateTime.Now,
                DbOrderDetails = new List<DbOrderDetails>
                 {
                     new DbOrderDetails
                     {
                         OrderDetailsID = textBox4.Text,
                         ProductName = textBox3.Text,
                         Price = double.Parse(textBox2.Text),
                         Quantity =int.Parse(textBox1.Text)
                     },
                 }
            };
            dborderservice2.ModifyOrder(textBox_modifyid.Text, textBox_modifydetailid.Text, _order);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dborderservice2.ReturnOrders();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dborderservice2.ReturnAllDetails();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!IsDeleteValidInput())
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string deleteorder_id = textBox_deleteid.Text; 
            DbOrder delete_order = dborderservice2.SearchOrder_ID(textBox_modifyid.Text);
           
            dborderservice2.DeleteOrder(deleteorder_id);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dborderservice2.ReturnOrders();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dborderservice2.ReturnAllDetails();

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void button_clear1_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_customer.Clear();
            textBox_detailid.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
        }

        private void button_clear2_Click(object sender, EventArgs e)
        {
            textBox_modifyid.Clear();
            textBox_modifydetailid.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button_clear3_Click(object sender, EventArgs e)
        {
            textBox_deleteid.Clear();
        }

        private bool IsAddValidInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_customer.Text) ||
                string.IsNullOrWhiteSpace(textBox_detailid.Text) ||
                string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(textBox_price.Text)||
                string.IsNullOrWhiteSpace(textBox_detailid.Text) )
            {
                return false;
            }

            double price;
            int quantity;
            if (!double.TryParse(textBox_price.Text, out price) ||
                !int.TryParse(textBox_quantity.Text, out quantity))
            {
                return false;
            }

            return true;
        }

        private bool IsModifyValidInput(int index)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                 string.IsNullOrWhiteSpace(textBox2.Text) ||
                 string.IsNullOrWhiteSpace(textBox3.Text) ||
                 string.IsNullOrWhiteSpace(textBox4.Text) ||
                 string.IsNullOrWhiteSpace(textBox5.Text) ||
                 string.IsNullOrWhiteSpace(textBox6.Text))
            {
                return false;
            }

            double price;
            int quantity;
            if (!double.TryParse(textBox2.Text, out price) ||
                !int.TryParse(textBox1.Text, out quantity))
            {
                return false;
            }
            return true;
        }

        private bool IsDeleteValidInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_deleteid.Text))
            {
                return false;
            }
            return true;
        }

        private void button_showall_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                var orders = context.DbOrders.Include("DbOrderDetails").ToList();

                if (orders != null && orders.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = orders;

                    // 如果您需要在第二个 DataGridView 中显示所有订单详情，则您可以直接从订单中提取订单详情列表并显示
                    var allDetails = orders.SelectMany(o => o.DbOrderDetails).ToList();
                    if (allDetails != null && allDetails.Count > 0)
                    {
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = allDetails;
                    }

                    dataGridView1.Refresh();
                    dataGridView2.Refresh();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string orderId = selectedRow.Cells["OrderID"].Value.ToString();

                using (var context = new OrderDbContext())
                {
                    var details = context.DbOrderDetails.Where(d => d.OrderID == orderId).ToList();

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = details;
                    dataGridView2.Refresh();
                }
            }
        }
    }
}
