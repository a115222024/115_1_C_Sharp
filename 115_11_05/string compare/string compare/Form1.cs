namespace string_compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            string string1,string2;
            string1 = stringTextBox.Text;
            string2 = string2TextBox.Text;

            if (String.Compare(string1, string2) == 0)
            {
                MessageBox.Show("兩個字串相同。");
            }
            else if(String.Compare(string1, string2) < 0)
            {
                MessageBox.Show("字串1小於字串2。");
            }
            else
            {
                MessageBox.Show("字串1大於字串2。");
            }

            MessageBox.Show( "比較結果");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
