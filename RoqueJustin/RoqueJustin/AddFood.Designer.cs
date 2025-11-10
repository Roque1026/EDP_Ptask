namespace RoqueJustin
{
    partial class AddFood
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
            label1 = new Label();
            addRemarks = new Label();
            foodName = new TextBox();
            foodPrice = new TextBox();
            add_Food = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 29);
            label1.Name = "label1";
            label1.Size = new Size(247, 49);
            label1.TabIndex = 0;
            label1.Text = "Add Food";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addRemarks
            // 
            addRemarks.Location = new Point(80, 162);
            addRemarks.Name = "addRemarks";
            addRemarks.Size = new Size(247, 58);
            addRemarks.TabIndex = 1;
            addRemarks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodName
            // 
            foodName.Location = new Point(20, 106);
            foodName.Multiline = true;
            foodName.Name = "foodName";
            foodName.Size = new Size(223, 40);
            foodName.TabIndex = 2;
            foodName.TextAlign = HorizontalAlignment.Center;
            // 
            // foodPrice
            // 
            foodPrice.Location = new Point(267, 106);
            foodPrice.Multiline = true;
            foodPrice.Name = "foodPrice";
            foodPrice.Size = new Size(123, 40);
            foodPrice.TabIndex = 3;
            foodPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // add_Food
            // 
            add_Food.Location = new Point(137, 236);
            add_Food.Name = "add_Food";
            add_Food.Size = new Size(132, 41);
            add_Food.TabIndex = 4;
            add_Food.Text = "ADD";
            add_Food.UseVisualStyleBackColor = true;
            add_Food.Click += add_Food_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 297);
            Controls.Add(add_Food);
            Controls.Add(foodPrice);
            Controls.Add(foodName);
            Controls.Add(addRemarks);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label addRemarks;
        private TextBox foodName;
        private TextBox foodPrice;
        private Button add_Food;
    }
}