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
            double km;
            double liters;
            double kmpl;



            if (double.TryParse(kmTextBox.Text, out km) )
            {
                if (double.TryParse(literTextBox.Text, out liters) )
                {
                    if (km > 0 && liters > 0)
                    {
                        kmpl = km / liters;
                        kmplLabel.Text = kmpl.ToString("F2") + " 公里/公升";
                    }
                    else
                    {
                        MessageBox.Show("行駛公里數和使用汽油公升數必須大於零。");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的使用汽油公升數。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的行駛公里數。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
