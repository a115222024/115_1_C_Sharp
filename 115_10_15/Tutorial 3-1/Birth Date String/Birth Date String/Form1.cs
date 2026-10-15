using System;
// 程式檔案：Form1.cs
// 說明：此表單用來接收使用者輸入的星期、月份、日期與年份，並可將它們組合成字串。
// 所有註解皆使用繁體中文。

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    // 主表單類別：負責回應表單上各種控制項的事件
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 「顯示日期」按鈕的事件處理器
        // 將使用者在各個文字方塊輸入的內容組合成一個日期字串
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串變數來儲存組合結果
            string output;

            // 透過字串串接把星期、月份、日與年組合起來
            // 範例結果格式：星期一，十月15，2026
            output = dayOfWeekTextBox.Text + "，" + monthTextBox.Text + "" + dayOfMonthTextBox.Text + "，" + yearTextBox.Text;

            // 注意：目前只建立了 output 變數，但沒有將它顯示在介面上。
            // 若要顯示，請將下列程式取消註解：
            // dateOutputLabel.Text = output;
        }

        // 「清除」按鈕的事件處理器
        // 清空所有輸入欄位與輸出顯示標籤
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";    // 清除星期輸入
            monthTextBox.Text = "";       // 清除月份輸入
            dayOfMonthTextBox.Text = "";  // 清除日期輸入
            yearTextBox.Text = "";        // 清除年份輸入

            dateOutputLabel.Text = "";    // 清除輸出標籤
        }

        // 「離開」按鈕的事件處理器
        // 關閉目前表單（視專案設定可能會結束應用程式）
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 表單載入事件（如果需在表單載入時初始化資料，可在此處加入程式碼）
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 提示標籤的 Click 事件通常不需要處理，保留空方法以避免設計工具錯誤
        private void dayOfWeekPromptLabel_Click(object sender, EventArgs e)
        {

        }

        // 提示標籤的 Click 事件通常不需要處理，保留空方法以避免設計工具錯誤
        private void dayOfMonthPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
