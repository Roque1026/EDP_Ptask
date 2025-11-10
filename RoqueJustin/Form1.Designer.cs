namespace RoqueJustin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            firstName = new TextBox();
            button1 = new Button();
            lastName = new TextBox();
            label2 = new Label();
            firstNumber = new TextBox();
            label3 = new Label();
            secondNumber = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // firstName
            // 
            firstName.Location = new Point(197, 45);
            firstName.Multiline = true;
            firstName.Name = "firstName";
            firstName.Size = new Size(176, 34);
            firstName.TabIndex = 1;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(35, 288);
            button1.Name = "button1";
            button1.Size = new Size(162, 55);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(197, 109);
            lastName.Multiline = true;
            lastName.Name = "lastName";
            lastName.Size = new Size(176, 34);
            lastName.TabIndex = 4;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 110);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name :";
            // 
            // firstNumber
            // 
            firstNumber.Location = new Point(197, 166);
            firstNumber.Multiline = true;
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(176, 34);
            firstNumber.TabIndex = 6;
            firstNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 167);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Number 1 :";
            // 
            // secondNumber
            // 
            secondNumber.Location = new Point(197, 224);
            secondNumber.Multiline = true;
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(176, 34);
            secondNumber.TabIndex = 8;
            secondNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 225);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Number 2 :";
            // 
            // button2
            // 
            button2.Location = new Point(234, 288);
            button2.Name = "button2";
            button2.Size = new Size(162, 55);
            button2.TabIndex = 9;
            button2.Text = "SUBTRACT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 369);
            button3.Name = "button3";
            button3.Size = new Size(162, 55);
            button3.TabIndex = 10;
            button3.Text = "MULTIPLY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(234, 369);
            button4.Name = "button4";
            button4.Size = new Size(162, 55);
            button4.TabIndex = 11;
            button4.Text = "DIVISION";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 444);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(secondNumber);
            Controls.Add(label4);
            Controls.Add(firstNumber);
            Controls.Add(label3);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Delegate Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Button button1;
        private TextBox lastName;
        private Label label2;
        private TextBox firstNumber;
        private Label label3;
        private TextBox secondNumber;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
