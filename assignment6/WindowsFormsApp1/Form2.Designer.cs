
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_add = new System.Windows.Forms.TabPage();
            this.groupBox_order = new System.Windows.Forms.GroupBox();
            this.button_clear1 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_customer = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.tabPage_modify = new System.Windows.Forms.TabPage();
            this.button_clear2 = new System.Windows.Forms.Button();
            this.label_modify = new System.Windows.Forms.Label();
            this.textBox_modify = new System.Windows.Forms.TextBox();
            this.button_modify = new System.Windows.Forms.Button();
            this.textBox_modifyid = new System.Windows.Forms.TextBox();
            this.label_modifyid = new System.Windows.Forms.Label();
            this.label_modifychoice = new System.Windows.Forms.Label();
            this.comboBox_modify = new System.Windows.Forms.ComboBox();
            this.tabPage_delete = new System.Windows.Forms.TabPage();
            this.button_clear3 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_deleteid = new System.Windows.Forms.TextBox();
            this.label_deleteid = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_add.SuspendLayout();
            this.groupBox_order.SuspendLayout();
            this.tabPage_modify.SuspendLayout();
            this.tabPage_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_add);
            this.tabControl1.Controls.Add(this.tabPage_modify);
            this.tabControl1.Controls.Add(this.tabPage_delete);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(42, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 274);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_add
            // 
            this.tabPage_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_add.Controls.Add(this.groupBox_order);
            this.tabPage_add.Location = new System.Drawing.Point(4, 29);
            this.tabPage_add.Name = "tabPage_add";
            this.tabPage_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_add.Size = new System.Drawing.Size(631, 241);
            this.tabPage_add.TabIndex = 0;
            this.tabPage_add.Text = "添加订单";
            // 
            // groupBox_order
            // 
            this.groupBox_order.Controls.Add(this.button_clear1);
            this.groupBox_order.Controls.Add(this.button_add);
            this.groupBox_order.Controls.Add(this.textBox_quantity);
            this.groupBox_order.Controls.Add(this.textBox_price);
            this.groupBox_order.Controls.Add(this.textBox_name);
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
            this.groupBox_order.Size = new System.Drawing.Size(602, 143);
            this.groupBox_order.TabIndex = 1;
            this.groupBox_order.TabStop = false;
            this.groupBox_order.Text = "订单基本信息";
            // 
            // button_clear1
            // 
            this.button_clear1.Location = new System.Drawing.Point(486, 76);
            this.button_clear1.Name = "button_clear1";
            this.button_clear1.Size = new System.Drawing.Size(93, 46);
            this.button_clear1.TabIndex = 13;
            this.button_clear1.Text = "清空输入";
            this.button_clear1.UseVisualStyleBackColor = true;
            this.button_clear1.Click += new System.EventHandler(this.button_clear1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(374, 76);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(93, 46);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(241, 95);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(105, 27);
            this.textBox_quantity.TabIndex = 11;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(88, 95);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(105, 27);
            this.textBox_price.TabIndex = 10;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(447, 36);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(105, 27);
            this.textBox_name.TabIndex = 8;
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
            this.label_name.Location = new System.Drawing.Point(370, 39);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(84, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "商品名称：";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(13, 98);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(54, 20);
            this.label_price.TabIndex = 3;
            this.label_price.Text = "单价：";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(199, 98);
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
            this.tabPage_modify.Controls.Add(this.button_clear2);
            this.tabPage_modify.Controls.Add(this.label_modify);
            this.tabPage_modify.Controls.Add(this.textBox_modify);
            this.tabPage_modify.Controls.Add(this.button_modify);
            this.tabPage_modify.Controls.Add(this.textBox_modifyid);
            this.tabPage_modify.Controls.Add(this.label_modifyid);
            this.tabPage_modify.Controls.Add(this.label_modifychoice);
            this.tabPage_modify.Controls.Add(this.comboBox_modify);
            this.tabPage_modify.Location = new System.Drawing.Point(4, 29);
            this.tabPage_modify.Name = "tabPage_modify";
            this.tabPage_modify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_modify.Size = new System.Drawing.Size(631, 241);
            this.tabPage_modify.TabIndex = 1;
            this.tabPage_modify.Text = "修改订单";
            // 
            // button_clear2
            // 
            this.button_clear2.Location = new System.Drawing.Point(483, 42);
            this.button_clear2.Name = "button_clear2";
            this.button_clear2.Size = new System.Drawing.Size(102, 54);
            this.button_clear2.TabIndex = 14;
            this.button_clear2.Text = "清空输入";
            this.button_clear2.UseVisualStyleBackColor = true;
            this.button_clear2.Click += new System.EventHandler(this.button_clear2_Click);
            // 
            // label_modify
            // 
            this.label_modify.AutoSize = true;
            this.label_modify.Location = new System.Drawing.Point(36, 102);
            this.label_modify.Name = "label_modify";
            this.label_modify.Size = new System.Drawing.Size(73, 20);
            this.label_modify.TabIndex = 6;
            this.label_modify.Text = "修改的值:";
            // 
            // textBox_modify
            // 
            this.textBox_modify.Location = new System.Drawing.Point(130, 99);
            this.textBox_modify.Name = "textBox_modify";
            this.textBox_modify.Size = new System.Drawing.Size(170, 27);
            this.textBox_modify.TabIndex = 5;
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(346, 42);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(104, 54);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "修改";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // textBox_modifyid
            // 
            this.textBox_modifyid.Location = new System.Drawing.Point(198, 17);
            this.textBox_modifyid.Name = "textBox_modifyid";
            this.textBox_modifyid.Size = new System.Drawing.Size(102, 27);
            this.textBox_modifyid.TabIndex = 3;
            // 
            // label_modifyid
            // 
            this.label_modifyid.AutoSize = true;
            this.label_modifyid.Location = new System.Drawing.Point(36, 17);
            this.label_modifyid.Name = "label_modifyid";
            this.label_modifyid.Size = new System.Drawing.Size(159, 20);
            this.label_modifyid.TabIndex = 2;
            this.label_modifyid.Text = "需要修改订单的编号：";
            // 
            // label_modifychoice
            // 
            this.label_modifychoice.AutoSize = true;
            this.label_modifychoice.Location = new System.Drawing.Point(36, 58);
            this.label_modifychoice.Name = "label_modifychoice";
            this.label_modifychoice.Size = new System.Drawing.Size(84, 20);
            this.label_modifychoice.TabIndex = 1;
            this.label_modifychoice.Text = "修改选项：";
            // 
            // comboBox_modify
            // 
            this.comboBox_modify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_modify.FormattingEnabled = true;
            this.comboBox_modify.Items.AddRange(new object[] {
            "修改订单编号",
            "修改客户名称",
            "修改商品名称",
            "修改单价",
            "修改购买数量"});
            this.comboBox_modify.Location = new System.Drawing.Point(130, 56);
            this.comboBox_modify.Name = "comboBox_modify";
            this.comboBox_modify.Size = new System.Drawing.Size(171, 28);
            this.comboBox_modify.TabIndex = 0;
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
            this.tabPage_delete.Size = new System.Drawing.Size(631, 241);
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
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(374, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(401, 156);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(42, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(284, 157);
            this.dataGridView1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
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
            this.bindingSource2.DataSource = typeof(WindowsFormsApp1.OrderDetails);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 52;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.Order);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 508);
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
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_name;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_modifyid;
        private System.Windows.Forms.Label label_modifyid;
        private System.Windows.Forms.Label label_modifychoice;
        private System.Windows.Forms.ComboBox comboBox_modify;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.TextBox textBox_modify;
        private System.Windows.Forms.Label label_modify;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_deleteid;
        private System.Windows.Forms.Label label_deleteid;
        private System.Windows.Forms.Button button_clear1;
        private System.Windows.Forms.Button button_clear2;
        private System.Windows.Forms.Button button_clear3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    }
}