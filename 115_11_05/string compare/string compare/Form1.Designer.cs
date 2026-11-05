namespace string_compare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblString1;
        private Label lblString2;
        private TextBox stringTextBox;
        private TextBox string2TextBox;
        private Button btnCompare;
        private Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblString1 = new Label();
            lblString2 = new Label();
            stringTextBox = new TextBox();
            string2TextBox = new TextBox();
            btnCompare = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblString1
            // 
            lblString1.AutoSize = true;
            lblString1.Location = new Point(50, 45);
            lblString1.Name = "lblString1";
            lblString1.Size = new Size(56, 23);
            lblString1.TabIndex = 0;
            lblString1.Text = "字串1";
            // 
            // lblString2
            // 
            lblString2.AutoSize = true;
            lblString2.Location = new Point(50, 95);
            lblString2.Name = "lblString2";
            lblString2.Size = new Size(56, 23);
            lblString2.TabIndex = 1;
            lblString2.Text = "字串2";
            // 
            // stringTextBox
            // 
            stringTextBox.Location = new Point(125, 40);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.Size = new Size(300, 30);
            stringTextBox.TabIndex = 2;
            // 
            // string2TextBox
            // 
            string2TextBox.Location = new Point(125, 90);
            string2TextBox.Name = "string2TextBox";
            string2TextBox.Size = new Size(300, 30);
            string2TextBox.TabIndex = 3;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(125, 145);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(100, 35);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "比較";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(250, 145);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 230);
            Controls.Add(btnExit);
            Controls.Add(btnCompare);
            Controls.Add(string2TextBox);
            Controls.Add(stringTextBox);
            Controls.Add(lblString2);
            Controls.Add(lblString1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "字串比較";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
