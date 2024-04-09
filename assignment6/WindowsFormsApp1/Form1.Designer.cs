
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_function = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.button_showall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_function
            // 
            this.button_function.Location = new System.Drawing.Point(53, 24);
            this.button_function.Name = "button_function";
            this.button_function.Size = new System.Drawing.Size(161, 47);
            this.button_function.TabIndex = 1;
            this.button_function.Text = "订单操作";
            this.button_function.UseVisualStyleBackColor = true;
            this.button_function.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(35, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(283, 214);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.Location = new System.Drawing.Point(380, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(557, 213);
            this.dataGridView2.TabIndex = 3;
            // 
            // groupBox_search
            // 
            this.groupBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_search.Controls.Add(this.button_clear);
            this.groupBox_search.Controls.Add(this.button_search);
            this.groupBox_search.Controls.Add(this.textBox_search);
            this.groupBox_search.Controls.Add(this.label1);
            this.groupBox_search.Controls.Add(this.label_search);
            this.groupBox_search.Controls.Add(this.comboBox_search);
            this.groupBox_search.Location = new System.Drawing.Point(35, 20);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(562, 134);
            this.groupBox_search.TabIndex = 4;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "订单查询";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(374, 32);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(72, 43);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Location = new System.Drawing.Point(281, 30);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(76, 46);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(105, 58);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(154, 25);
            this.textBox_search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询输入:";
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(17, 27);
            this.label_search.Margin = new System.Windows.Forms.Padding(3);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(82, 15);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "查询方式：";
            // 
            // comboBox_search
            // 
            this.comboBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Items.AddRange(new object[] {
            "订单号查询",
            "客户查询",
            "商品查询",
            "总金额查询"});
            this.comboBox_search.Location = new System.Drawing.Point(105, 24);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(154, 23);
            this.comboBox_search.TabIndex = 0;
            // 
            // button_showall
            // 
            this.button_showall.Location = new System.Drawing.Point(53, 84);
            this.button_showall.Name = "button_showall";
            this.button_showall.Size = new System.Drawing.Size(161, 50);
            this.button_showall.TabIndex = 6;
            this.button_showall.Text = "显示所有订单";
            this.button_showall.UseVisualStyleBackColor = true;
            this.button_showall.Click += new System.EventHandler(this.button_showall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_showall);
            this.groupBox1.Controls.Add(this.button_function);
            this.groupBox1.Location = new System.Drawing.Point(615, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按钮菜单";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 76;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
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
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 52;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_function;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_showall;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

