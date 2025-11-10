namespace RoqueJustin
{
    partial class RemoveDrinks
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
            delete_Beverage = new Button();
            delBeverage = new TextBox();
            delRemarks = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // delete_Beverage
            // 
            delete_Beverage.Location = new Point(129, 231);
            delete_Beverage.Name = "delete_Beverage";
            delete_Beverage.Size = new Size(132, 41);
            delete_Beverage.TabIndex = 12;
            delete_Beverage.Text = "REMOVE";
            delete_Beverage.UseVisualStyleBackColor = true;
            delete_Beverage.Click += delete_Beverage_Click;
            // 
            // delBeverage
            // 
            delBeverage.Location = new Point(12, 101);
            delBeverage.Multiline = true;
            delBeverage.Name = "delBeverage";
            delBeverage.Size = new Size(362, 40);
            delBeverage.TabIndex = 11;
            delBeverage.TextAlign = HorizontalAlignment.Center;
            // 
            // delRemarks
            // 
            delRemarks.Location = new Point(72, 157);
            delRemarks.Name = "delRemarks";
            delRemarks.Size = new Size(247, 58);
            delRemarks.TabIndex = 10;
            delRemarks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 24);
            label1.Name = "label1";
            label1.Size = new Size(247, 49);
            label1.TabIndex = 9;
            label1.Text = "Add Food";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveDrinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 297);
            Controls.Add(delete_Beverage);
            Controls.Add(delBeverage);
            Controls.Add(delRemarks);
            Controls.Add(label1);
            Name = "RemoveDrinks";
            Text = "RemoveDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete_Beverage;
        private TextBox delBeverage;
        private Label delRemarks;
        private Label label1;
    }
}