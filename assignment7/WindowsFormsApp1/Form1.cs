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
    public partial class Form1 : Form
    {
        private BindingList<DbOrder> bd_orderList = new BindingList<DbOrder>();
        private BindingList<DbOrderDetails> bd_detailsList = new BindingList<DbOrderDetails>();
        private Form2 form2;
        public DbOrderService DbOrderService1
        {
            get { return dborderservice1; }
            set { dborderservice1 = value; }
        }
        private DbOrderService dborderservice1 = new DbOrderService();
        public Form1()
        {
            InitializeComponent(); 
            comboBox_search.SelectedIndex = 0; //comboBox默认显示第一个
            dataGridView1.DataSource = bd_orderList;
            dataGridView2.DataSource = bd_detailsList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 existForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (existForm != null)
            {
                existForm.Activate();
            }
            else
            {
                form2 = new Form2(DbOrderService1);
                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                DbOrderService1 = form2.DbOrderService2;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = form2.DbOrderService2.ReturnOrders();
                dataGridView1.Refresh();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = form2.DbOrderService2.ReturnAllDetails();
                dataGridView2.Refresh();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            
            int index = comboBox_search.SelectedIndex;//订单号查询\客户查询\商品查询\总金额查询
            if (!IsSearchValidInput(index))
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbOrder search_order = new DbOrder();
            List<DbOrder> search_orderlist = new List<DbOrder>();
            switch (index)
            {
                case 0:
                    search_order = form2.DbOrderService2.SearchOrder_ID(textBox_search.Text);
                    break;
                case 1:
                    search_orderlist = form2.DbOrderService2.SearchOrder_Customer(textBox_search.Text);
                    break;
                case 2:
                    search_orderlist = form2.DbOrderService2.SearchOrder_Name(textBox_search.Text);
                    break;
                default:break;
            }
            if (search_order != null || search_orderlist.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;

                if (search_order != null)
                {
                    dataGridView1.DataSource = new List<DbOrder> { search_order };
                    dataGridView2.DataSource = form2.DbOrderService2.ReturnDetails(search_order.OrderID);
                }
                else
                {
                    List<DbOrderDetails> allDetails = new List<DbOrderDetails>();

                    foreach (DbOrder order in search_orderlist)
                    {
                        List<DbOrderDetails> orderDetails = form2.DbOrderService2.ReturnDetails(order.OrderID);
                        allDetails.AddRange(orderDetails);
                    }

                    dataGridView1.DataSource = search_orderlist;
                    dataGridView2.DataSource = allDetails;
                }

                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("没有找到符合要求的订单！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private bool IsSearchValidInput(int index)
        {
            if (string.IsNullOrWhiteSpace(textBox_search.Text) )
            {
                return false;
            }
            double price;
            int quantity;
            switch (index)
            {
                case 2:
                    if (!double.TryParse(textBox_search.Text, out price))
                    {
                        return false;
                    }
                    break;
                case 3:
                    if (!int.TryParse(textBox_search.Text, out quantity))
                    {
                        return false;
                    }
                    break;
                default: break;
            }
            return true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
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
