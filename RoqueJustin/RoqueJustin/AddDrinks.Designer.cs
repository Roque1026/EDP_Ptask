namespace RoqueJustin
{
    partial class AddDrinks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            add_Drinks = new Button();
            bevName = new TextBox();
            addRemarks = new Label();
            label1 = new Label();
            bevPrice = new TextBox();
            SuspendLayout();
            // 
            // add_Drinks
            // 
            add_Drinks.Location = new Point(136, 231);
            add_Drinks.Name = "add_Drinks";
            add_Drinks.Size = new Size(132, 41);
            add_Drinks.TabIndex = 9;
            add_Drinks.Text = "ADD";
            add_Drinks.UseVisualStyleBackColor = true;
            add_Drinks.Click += add_Drinks_Click;
            // 
            // bevName
            // 
            bevName.Location = new Point(19, 101);
            bevName.Multiline = true;
            bevName.Name = "bevName";
            bevName.Size = new Size(223, 40);
            bevName.TabIndex = 7;
            bevName.TextAlign = HorizontalAlignment.Center;
            // 
            // addRemarks
            // 
            addRemarks.Location = new Point(79, 157);
            addRemarks.Name = "addRemarks";
            addRemarks.Size = new Size(247, 58);
            addRemarks.TabIndex = 6;
            addRemarks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 24);
            label1.Name = "label1";
            label1.Size = new Size(247, 49);
            label1.TabIndex = 5;
            label1.Text = "Add Drinks";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bevPrice
            // 
            bevPrice.Location = new Point(266, 101);
            bevPrice.Multiline = true;
            bevPrice.Name = "bevPrice";
            bevPrice.Size = new Size(123, 40);
            bevPrice.TabIndex = 8;
            bevPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // AddDrinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 297);
            Controls.Add(add_Drinks);
            Controls.Add(bevPrice);
            Controls.Add(bevName);
            Controls.Add(addRemarks);
            Controls.Add(label1);
            Name = "AddDrinks";
            Text = "AddDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_Drinks;
        private TextBox bevName;
        private Label addRemarks;
        private Label label1;
        private TextBox bevPrice;
    }
}