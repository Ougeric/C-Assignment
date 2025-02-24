using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double num1) ||
                !double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("请输入有效数字！");
                return;
            }

            string op = cmbOp.SelectedItem?.ToString() ?? "+";

            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("除数不能为零！");
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            lblResult.Text = $"结果：{result:F2}";
        }  
    }
}
