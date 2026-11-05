using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string grade;
            const double PASSING_SCORE = 60;
            const double HIGH_SCORE = 95;
            double test1, test2, test3, average;
            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("F1");

                if(average>=60)
                {
                    if(average>=80)
                    {
                        if(average>=90)
                        {
                            grade = "A";
                        }
                        else
                        {
                            grade = "B";
                        }
                    }
                    else
                    {
                        if(average>=70)
                        {
                            grade = "C";
                        }
                        else
                        {
                            grade = "D";
                        }
                    }
                }
                else
                {
                    grade = "F";
                }
                MessageBox.Show("成績等級" + grade);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
