namespace RoqueJustin
{
    partial class ProductOrder
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 91);
            button1.Name = "button1";
            button1.Size = new Size(299, 115);
            button1.TabIndex = 0;
            button1.Text = "View Products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(114, 247);
            button2.Name = "button2";
            button2.Size = new Size(299, 115);
            button2.TabIndex = 1;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = false;
            // 
            // ProductOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(531, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProductOrder";
            Text = "PRODUCT_ORDER";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
