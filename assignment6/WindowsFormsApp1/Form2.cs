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
        public OrderService OrderService2
        {
            get { return orderservice2; }
            set { orderservice2 = value; }
        }
        private OrderService orderservice2 = new OrderService();
        private BindingList<Order> bd_orderList = new BindingList<Order>();
        private BindingList<OrderDetails> bd_detailsList = new BindingList<OrderDetails>();
        public Form2(OrderService ex)
        {
            //BindingSource bindingSource1 = new BindingSource();
            // BindingSource bindingSource2 = new BindingSource();
            //dataGridView1.DataSource = bindingSource1;
            //dataGridView2.DataSource = bindingSource2;
            InitializeComponent();
            orderservice2 = ex;
            comboBox_modify.SelectedIndex = 0; //comboBox默认显示第一个
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
            OrderDetails _detail = new OrderDetails(textBox_name.Text, double.Parse(textBox_price.Text), int.Parse(textBox_quantity.Text));
            Order _order = new Order(textBox_id.Text, textBox_customer.Text);
            _order.Details = _detail;
            orderservice2.AddOrder(_order);
            bd_orderList.Add(_order); 
            bd_detailsList.Add(_detail);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orderservice2.ReturnAll();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderservice2.ReturnAllDetails();

            dataGridView1.Refresh();
            dataGridView2.Refresh();
            
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_modifyid.Text))
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Order modify_order = orderservice2.SearchOrder_ID(textBox_modifyid.Text);

            if (modify_order==null)
            {
                MessageBox.Show("订单未找到！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = comboBox_modify.SelectedIndex;  //修改订单编号,修改客户名称,修改商品名称,修改单价,修改购买数量
            if (!IsModifyValidInput(index))
            {
                MessageBox.Show("请输入有效的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (index)
            {
                case 0: 
                    if(orderservice2.SearchOrder_ID(textBox_modify.Text)==null)
                    {
                        modify_order.ID = textBox_modify.Text;
                    }
                    else
                    {
                        MessageBox.Show("订单号已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 1:
                    modify_order.Customer = textBox_modify.Text; 
                    break;
                case 2: 
                    modify_order.Details.Name = textBox_modify.Text; 
                    break;
                case 3: 
                    if (!double.TryParse(textBox_modify.Text, out double price))
                    {
                        MessageBox.Show("输入的价格格式不正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    modify_order.Details.Price = price;
                    break;
                case 4: 
                    if (!int.TryParse(textBox_modify.Text, out int quantity))
                    {
                        MessageBox.Show("输入的数量格式不正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    modify_order.Details.Quantity = quantity;
                    break;
                default: break;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orderservice2.ReturnAll();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderservice2.ReturnAllDetails();

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
            Order delete_order = orderservice2.SearchOrder_ID(textBox_modifyid.Text);
           
            orderservice2.DeleteOrder(deleteorder_id);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orderservice2.ReturnAll();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderservice2.ReturnAllDetails();

            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void button_clear1_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_customer.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
        }

        private void button_clear2_Click(object sender, EventArgs e)
        {
            textBox_modifyid.Clear();
            textBox_modify.Clear();
        }

        private void button_clear3_Click(object sender, EventArgs e)
        {
            textBox_deleteid.Clear();
        }

        private bool IsAddValidInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_customer.Text) ||
                string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(textBox_price.Text) ||
                string.IsNullOrWhiteSpace(textBox_quantity.Text))
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
            if (string.IsNullOrWhiteSpace(textBox_modifyid.Text) ||
                string.IsNullOrWhiteSpace(textBox_modify.Text))
            {
                return false;
            }
            double price;
            int quantity;
            switch (index)
            {
                case 3:
                    if (!double.TryParse(textBox_price.Text, out price))
                    {
                        return false;
                    }
                    break;
                case 4:
                    if (!int.TryParse(textBox_quantity.Text, out quantity))
                    {
                        return false;
                    }
                    break;
                default: break;
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
    }
}
