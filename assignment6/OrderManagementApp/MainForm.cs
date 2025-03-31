using OrderManagementApp;
using OrderManagementCore;
using System.Windows.Forms;
using System;

public partial class MainForm : Form
{
    private readonly OrderService _service = new OrderService();
    private readonly BindingSource _orderBS = new BindingSource();
    private readonly BindingSource _detailBS = new BindingSource();

    public MainForm()
    {
        InitializeComponent();

        // 主订单绑定
        _orderBS.DataSource = _service.QueryOrders();
        dgvOrders.DataSource = _orderBS;

        // 明细数据绑定（主从关系）
        _detailBS.DataMember = "Details"; // 绑定到Order类的Details属性
        _detailBS.DataSource = _orderBS;
        dgvDetails.DataSource = _detailBS;

        ConfigureDataGridView();
    }

    private void ConfigureDataGridView()
    {
        dgvOrders.AutoGenerateColumns = false;
        dgvOrders.Columns.Clear();
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "OrderId",
            HeaderText = "订单号"
        });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Customer",
            HeaderText = "客户"
        });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "OrderTime",
            HeaderText = "下单时间"
        });
        dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TotalAmount",
            HeaderText = "总金额",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
        });
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        using var editForm = new EditOrderForm();
        editForm.CurrentOrder = new Order { OrderId = GenerateNewId() };
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _service.AddOrder(editForm.CurrentOrder);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void RefreshData()
    {
        _orderBS.DataSource = _service.QueryOrders();
        _orderBS.ResetBindings(false);
    }

    private int GenerateNewId()
    {
        return _service.QueryOrders().Count > 0
             ? _service.QueryOrders().Max(o => o.OrderId) + 1
             : 1;
    }
}
