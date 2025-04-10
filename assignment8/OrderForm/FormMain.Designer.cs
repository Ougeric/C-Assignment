namespace OrderForm
{
    partial class FormMain
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
            this.panelQuery = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbvOrders = new System.Windows.Forms.DataGridView();
            this.dbvItems = new System.Windows.Forms.DataGridView();
            this.bdsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bdsOrders = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.cbxField);
            this.panelQuery.Controls.Add(this.txtKeyword);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.panelQuery.Size = new System.Drawing.Size(1340, 100);
            this.panelQuery.TabIndex = 0;
            // 
            // cbxField
            // 
            this.cbxField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
            this.cbxField.Location = new System.Drawing.Point(26, 33);
            this.cbxField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(238, 32);
            this.cbxField.TabIndex = 0;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(276, 26);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(486, 35);
            this.txtKeyword.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(774, 26);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 46);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnModify);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnExport);
            this.panelButtons.Controls.Add(this.btnImport);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 100);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(1340, 68);
            this.panelButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(188, 16);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 46);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修改订单";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(512, 16);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 46);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(674, 16);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 46);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 789);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1340, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panel1.Size = new System.Drawing.Size(1340, 621);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 20);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dbvOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dbvItems);
            this.splitContainer1.Size = new System.Drawing.Size(1300, 581);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 5;
            // 
            // dbvOrders
            // 
            this.dbvOrders.AllowUserToAddRows = false;
            this.dbvOrders.AutoGenerateColumns = false;
            this.dbvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dbvOrders.DataSource = this.bdsOrders;
            this.dbvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbvOrders.Location = new System.Drawing.Point(0, 0);
            this.dbvOrders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dbvOrders.Name = "dbvOrders";
            this.dbvOrders.RowHeadersWidth = 82;
            this.dbvOrders.RowTemplate.Height = 23;
            this.dbvOrders.Size = new System.Drawing.Size(314, 581);
            this.dbvOrders.TabIndex = 6;
            this.dbvOrders.DoubleClick += new System.EventHandler(this.dbvOrders_DoubleClick);
            // 
            // dbvItems
            // 
            this.dbvItems.AllowUserToAddRows = false;
            this.dbvItems.AutoGenerateColumns = false;
            this.dbvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.GoodsName,
            this.dataGridViewTextBoxColumn2,
            this.UnitPrice,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dbvItems.DataSource = this.bdsDetails;
            this.dbvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbvItems.Location = new System.Drawing.Point(0, 0);
            this.dbvItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dbvItems.Name = "dbvItems";
            this.dbvItems.RowHeadersWidth = 82;
            this.dbvItems.RowTemplate.Height = 23;
            this.dbvItems.Size = new System.Drawing.Size(978, 581);
            this.dbvItems.TabIndex = 0;
            // 
            // bdsDetails
            // 
            this.bdsDetails.DataMember = "Details";
            this.bdsDetails.DataSource = this.bdsOrders;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(912, 852);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 35);
            this.textBox1.TabIndex = 3;
            // 
            // bdsOrders
            // 
            this.bdsOrders.DataSource = typeof(OrderApp.Order);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "序号";
            this.indexDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.Width = 50;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "ProductName";
            this.GoodsName.HeaderText = "货物";
            this.GoodsName.MinimumWidth = 10;
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "数量";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.MinimumWidth = 10;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelQuery);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.Text = "订单管理";
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelQuery;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dbvOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridView dbvItems;
    private System.Windows.Forms.BindingSource bdsOrders;
    private System.Windows.Forms.BindingSource bdsDetails;
    private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
    }
}

