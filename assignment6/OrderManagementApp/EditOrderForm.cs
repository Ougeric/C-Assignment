using OrderManagementCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System;

public partial class EditOrderForm : Form
{
    public Order CurrentOrder { get; set; }
    private readonly BindingSource _detailBS = new BindingSource();

    public EditOrderForm()
    {
        InitializeComponent();
        _detailBS.DataSource = new List<OrderDetail>();
        dgvDetails.DataSource = _detailBS;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (CurrentOrder != null)
        {
            txtOrderId.Text = CurrentOrder.OrderId.ToString();
            txtCustomer.Text = CurrentOrder.Customer;
            _detailBS.DataSource = new BindingList<OrderDetail>(CurrentOrder.Details);
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCustomer.Text))
        {
            MessageBox.Show("客户名称不能为空");
            return;
        }

        CurrentOrder ??= new Order();
        CurrentOrder.Customer = txtCustomer.Text;
        CurrentOrder.Details = _detailBS.List.Cast<OrderDetail>().ToList();

        DialogResult = DialogResult.OK;
        Close();
    }
}