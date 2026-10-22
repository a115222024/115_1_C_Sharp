using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有視覺元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 處理「計算售價」按鈕的 Click 事件。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 儲存使用者輸入的商品原價。
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
            salePrice = originalPrice * (1 - discountPercentage / 100);

            // 將計算結果顯示在售價標籤上。
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 處理「離開」按鈕的 Click 事件。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
