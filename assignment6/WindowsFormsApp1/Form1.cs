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
        private BindingList<Order> bd_orderList = new BindingList<Order>();
        private BindingList<OrderDetails> bd_detailsList = new BindingList<OrderDetails>();
        private Form2 form2;
        public OrderService OrderService1
        {
            get { return orderservice1; }
            set { orderservice1 = value; }
        }
        private OrderService orderservice1 = new OrderService();
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
                form2 = new Form2(OrderService1);
                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                OrderService1 = form2.OrderService2;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = form2.OrderService2.ReturnAll();
                dataGridView1.Refresh();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = form2.OrderService2.ReturnAllDetails();
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
            Order search_order = new Order();
            List<Order> search_orderlist = new List<Order>();
            OrderService ex = new OrderService();
            switch (index)
            {
                case 0:
                    search_order = form2.OrderService2.SearchOrder_ID(textBox_search.Text);
                    break;
                case 1:
                    search_orderlist = form2.OrderService2.SearchOrder_Customer(textBox_search.Text);
                    break;
                case 2:
                    search_orderlist = form2.OrderService2.SearchOrder_Name(textBox_search.Text);
                    break;
                default:break;
            }
            if(index==0)
            {
                if (search_order == null)
                {
                    MessageBox.Show("没有找到符合要求的订单！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ex.AddOrder(search_order);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ex.ReturnAll();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = ex.ReturnAllDetails();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
            else if (index == 1 || index == 2)
            {
                if (search_orderlist == null)
                {
                    MessageBox.Show("没有找到符合要求的订单！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Order _order in search_orderlist)
                {
                    
                    ex.AddOrder(_order);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ex.ReturnAll();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = ex.ReturnAllDetails();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
                
        }

        private void button_showall_Click(object sender, EventArgs e)
        {
            if(form2.OrderService2.ReturnAll()!=null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = form2.OrderService2.ReturnAll();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = form2.OrderService2.ReturnAllDetails();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
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
    }
}
