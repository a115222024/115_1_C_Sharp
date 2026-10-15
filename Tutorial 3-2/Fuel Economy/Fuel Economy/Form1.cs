using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 讀取並驗證使用者輸入（已將單位改為 公里 與 公升）
            double kilometers;
            double liters;

            if (!double.TryParse(milesTextBox.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out kilometers) || kilometers <= 0)
            {
                MessageBox.Show("請輸入有效的正數：行駛公里數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                milesTextBox.Focus();
                return;
            }

            if (!double.TryParse(gallonsTextBox.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out liters) || liters <= 0)
            {
                MessageBox.Show("請輸入有效的正數：使用公升數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gallonsTextBox.Focus();
                return;
            }

            // 計算 公里/公升 並顯示（保留兩位小數）
            double kmPerLiter = kilometers / liters;
            mpgLabel.Text = kmPerLiter.ToString("F2") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
