
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_add = new System.Windows.Forms.TabPage();
            this.groupBox_order = new System.Windows.Forms.GroupBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_detailid = new System.Windows.Forms.Label();
            this.button_clear1 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_detailid = new System.Windows.Forms.TextBox();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_customer = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.tabPage_modify = new System.Windows.Forms.TabPage();
            this.button_clear2 = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.textBox_modifyid = new System.Windows.Forms.TextBox();
            this.label_modifyid = new System.Windows.Forms.Label();
            this.tabPage_delete = new System.Windows.Forms.TabPage();
            this.button_clear3 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_deleteid = new System.Windows.Forms.TextBox();
            this.label_deleteid = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_showall = new System.Windows.Forms.Button();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_modifydetailid = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_add.SuspendLayout();
            this.groupBox_order.SuspendLayout();
            this.tabPage_modify.SuspendLayout();
            this.tabPage_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_add);
            this.tabControl1.Controls.Add(this.tabPage_modify);
            this.tabControl1.Controls.Add(this.tabPage_delete);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(42, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 274);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_add
            // 
            this.tabPage_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_add.Controls.Add(this.groupBox_order);
            this.tabPage_add.Location = new System.Drawing.Point(4, 29);
            this.tabPage_add.Name = "tabPage_add";
            this.tabPage_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_add.Size = new System.Drawing.Size(750, 241);
            this.tabPage_add.TabIndex = 0;
            this.tabPage_add.Text = "添加订单";
            // 
            // groupBox_order
            // 
            this.groupBox_order.Controls.Add(this.textBox_quantity);
            this.groupBox_order.Controls.Add(this.label_detailid);
            this.groupBox_order.Controls.Add(this.button_clear1);
            this.groupBox_order.Controls.Add(this.button_add);
            this.groupBox_order.Controls.Add(this.textBox_price);
            this.groupBox_order.Controls.Add(this.textBox_name);
            this.groupBox_order.Controls.Add(this.textBox_detailid);
            this.groupBox_order.Controls.Add(this.textBox_customer);
            this.groupBox_order.Controls.Add(this.textBox_id);
            this.groupBox_order.Controls.Add(this.label_customer);
            this.groupBox_order.Controls.Add(this.label_name);
            this.groupBox_order.Controls.Add(this.label_price);
            this.groupBox_order.Controls.Add(this.label_quantity);
            this.groupBox_order.Controls.Add(this.label_id);
            this.groupBox_order.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_order.Location = new System.Drawing.Point(6, 19);
            this.groupBox_order.Name = "groupBox_order";
            this.groupBox_order.Size = new System.Drawing.Size(690, 152);
            this.groupBox_order.TabIndex = 1;
            this.groupBox_order.TabStop = false;
            this.groupBox_order.Text = "订单基本信息";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(589, 102);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(84, 27);
            this.textBox_quantity.TabIndex = 15;
            // 
            // label_detailid
            // 
            this.label_detailid.AutoSize = true;
            this.label_detailid.Location = new System.Drawing.Point(12, 105);
            this.label_detailid.Name = "label_detailid";
            this.label_detailid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_detailid.Size = new System.Drawing.Size(73, 20);
            this.label_detailid.TabIndex = 14;
            this.label_detailid.Text = "明细编号:";
            // 
            // button_clear1
            // 
            this.button_clear1.Location = new System.Drawing.Point(556, 26);
            this.button_clear1.Name = "button_clear1";
            this.button_clear1.Size = new System.Drawing.Size(93, 46);
            this.button_clear1.TabIndex = 13;
            this.button_clear1.Text = "清空输入";
            this.button_clear1.UseVisualStyleBackColor = true;
            this.button_clear1.Click += new System.EventHandler(this.button_clear1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(421, 26);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(93, 46);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(430, 102);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(84, 27);
            this.textBox_price.TabIndex = 11;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(280, 102);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(84, 27);
            this.textBox_name.TabIndex = 10;
            // 
            // textBox_detailid
            // 
            this.textBox_detailid.Location = new System.Drawing.Point(102, 102);
            this.textBox_detailid.Name = "textBox_detailid";
            this.textBox_detailid.Size = new System.Drawing.Size(84, 27);
            this.textBox_detailid.TabIndex = 8;
            // 
            // textBox_customer
            // 
            this.textBox_customer.Location = new System.Drawing.Point(241, 36);
            this.textBox_customer.Name = "textBox_customer";
            this.textBox_customer.Size = new System.Drawing.Size(105, 27);
            this.textBox_customer.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(88, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(105, 27);
            this.textBox_id.TabIndex = 6;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Location = new System.Drawing.Point(199, 39);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(54, 20);
            this.label_customer.TabIndex = 5;
            this.label_customer.Text = "客户：";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(199, 105);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(84, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "商品名称：";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(370, 105);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 20);
            this.label_price.TabIndex = 3;
            this.label_price.Text = "单价：";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(529, 105);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(54, 20);
            this.label_quantity.TabIndex = 2;
            this.label_quantity.Text = "数量：";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(13, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(84, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "订单编号：";
            // 
            // tabPage_modify
            // 
            this.tabPage_modify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_modify.Controls.Add(this.textBox_modifydetailid);
            this.tabPage_modify.Controls.Add(this.label7);
            this.tabPage_modify.Controls.Add(this.groupBox1);
            this.tabPage_modify.Controls.Add(this.textBox_modifyid);
            this.tabPage_modify.Controls.Add(this.label_modifyid);
            this.tabPage_modify.Location = new System.Drawing.Point(4, 29);
            this.tabPage_modify.Name = "tabPage_modify";
            this.tabPage_modify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_modify.Size = new System.Drawing.Size(750, 241);
            this.tabPage_modify.TabIndex = 1;
            this.tabPage_modify.Text = "修改订单";
            // 
            // button_clear2
            // 
            this.button_clear2.Location = new System.Drawing.Point(522, 26);
            this.button_clear2.Name = "button_clear2";
            this.button_clear2.Size = new System.Drawing.Size(102, 54);
            this.button_clear2.TabIndex = 14;
            this.button_clear2.Text = "清空输入";
            this.button_clear2.UseVisualStyleBackColor = true;
            this.button_clear2.Click += new System.EventHandler(this.button_clear2_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(378, 26);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(104, 54);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "修改";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // textBox_modifyid
            // 
            this.textBox_modifyid.Location = new System.Drawing.Point(184, 17);
            this.textBox_modifyid.Name = "textBox_modifyid";
            this.textBox_modifyid.Size = new System.Drawing.Size(102, 27);
            this.textBox_modifyid.TabIndex = 3;
            // 
            // label_modifyid
            // 
            this.label_modifyid.AutoSize = true;
            this.label_modifyid.Location = new System.Drawing.Point(19, 17);
            this.label_modifyid.Name = "label_modifyid";
            this.label_modifyid.Size = new System.Drawing.Size(159, 20);
            this.label_modifyid.TabIndex = 2;
            this.label_modifyid.Text = "需要修改订单的编号：";
            // 
            // tabPage_delete
            // 
            this.tabPage_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_delete.Controls.Add(this.button_clear3);
            this.tabPage_delete.Controls.Add(this.button_delete);
            this.tabPage_delete.Controls.Add(this.textBox_deleteid);
            this.tabPage_delete.Controls.Add(this.label_deleteid);
            this.tabPage_delete.Location = new System.Drawing.Point(4, 29);
            this.tabPage_delete.Name = "tabPage_delete";
            this.tabPage_delete.Size = new System.Drawing.Size(750, 241);
            this.tabPage_delete.TabIndex = 2;
            this.tabPage_delete.Text = "删除订单";
            // 
            // button_clear3
            // 
            this.button_clear3.Location = new System.Drawing.Point(461, 47);
            this.button_clear3.Name = "button_clear3";
            this.button_clear3.Size = new System.Drawing.Size(101, 54);
            this.button_clear3.TabIndex = 14;
            this.button_clear3.Text = "清空输入";
            this.button_clear3.UseVisualStyleBackColor = true;
            this.button_clear3.Click += new System.EventHandler(this.button_clear3_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(330, 47);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(104, 54);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_deleteid
            // 
            this.textBox_deleteid.Location = new System.Drawing.Point(188, 27);
            this.textBox_deleteid.Name = "textBox_deleteid";
            this.textBox_deleteid.Size = new System.Drawing.Size(102, 27);
            this.textBox_deleteid.TabIndex = 5;
            // 
            // label_deleteid
            // 
            this.label_deleteid.AutoSize = true;
            this.label_deleteid.Location = new System.Drawing.Point(26, 27);
            this.label_deleteid.Name = "label_deleteid";
            this.label_deleteid.Size = new System.Drawing.Size(159, 20);
            this.label_deleteid.TabIndex = 4;
            this.label_deleteid.Text = "需要删除订单的编号：";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDetailsID,
            this.ProductName,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(502, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(657, 156);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.Customer,
            this.OrderDate,
            this.orderIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(42, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(422, 157);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button_clear2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_modify);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改后订单基本信息";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 27);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "明细编号:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 27);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 27);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(241, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 27);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(105, 27);
            this.textBox6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "客户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "商品名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "单价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "订单编号：";
            // 
            // OrderDetailsID
            // 
            this.OrderDetailsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDetailsID.DataPropertyName = "OrderDetailsID";
            this.OrderDetailsID.HeaderText = "OrderDetailsID";
            this.OrderDetailsID.MinimumWidth = 6;
            this.OrderDetailsID.Name = "OrderDetailsID";
            this.OrderDetailsID.ReadOnly = true;
            this.OrderDetailsID.Width = 148;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 124;
            // 
            // OrderID
            // 
            this.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 92;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 108;
            // 
            // button_showall
            // 
            this.button_showall.Location = new System.Drawing.Point(871, 148);
            this.button_showall.Name = "button_showall";
            this.button_showall.Size = new System.Drawing.Size(161, 50);
            this.button_showall.TabIndex = 7;
            this.button_showall.Text = "显示所有订单";
            this.button_showall.UseVisualStyleBackColor = true;
            this.button_showall.Click += new System.EventHandler(this.button_showall_Click);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 76;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 84;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(WindowsFormsApp1.DbOrderDetails);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.DbOrder);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "需要修改的明细的编号：";
            // 
            // textBox_modifydetailid
            // 
            this.textBox_modifydetailid.Location = new System.Drawing.Point(510, 17);
            this.textBox_modifydetailid.Name = "textBox_modifydetailid";
            this.textBox_modifydetailid.Size = new System.Drawing.Size(120, 27);
            this.textBox_modifydetailid.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 508);
            this.Controls.Add(this.button_showall);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_add.ResumeLayout(false);
            this.groupBox_order.ResumeLayout(false);
            this.groupBox_order.PerformLayout();
            this.tabPage_modify.ResumeLayout(false);
            this.tabPage_modify.PerformLayout();
            this.tabPage_delete.ResumeLayout(false);
            this.tabPage_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_add;
        private System.Windows.Forms.TabPage tabPage_modify;
        private System.Windows.Forms.TabPage tabPage_delete;
        private System.Windows.Forms.GroupBox groupBox_order;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_detailid;
        private System.Windows.Forms.TextBox textBox_customer;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox textBox_modifyid;
        private System.Windows.Forms.Label label_modifyid;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_deleteid;
        private System.Windows.Forms.Label label_deleteid;
        private System.Windows.Forms.Button button_clear1;
        private System.Windows.Forms.Button button_clear2;
        private System.Windows.Forms.Button button_clear3;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_detailid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_showall;
        private System.Windows.Forms.TextBox textBox_modifydetailid;
        private System.Windows.Forms.Label label7;
    }
}