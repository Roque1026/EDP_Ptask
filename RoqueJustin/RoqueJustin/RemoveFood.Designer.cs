namespace RoqueJustin
{
    partial class RemoveFood
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
            delete_Food = new Button();
            delFood = new TextBox();
            delRemarks = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // delete_Food
            // 
            delete_Food.Location = new Point(129, 232);
            delete_Food.Name = "delete_Food";
            delete_Food.Size = new Size(132, 41);
            delete_Food.TabIndex = 8;
            delete_Food.Text = "REMOVE";
            delete_Food.UseVisualStyleBackColor = true;
            delete_Food.Click += delete_Food_Click;
            // 
            // delFood
            // 
            delFood.Location = new Point(12, 102);
            delFood.Multiline = true;
            delFood.Name = "delFood";
            delFood.Size = new Size(362, 40);
            delFood.TabIndex = 7;
            delFood.TextAlign = HorizontalAlignment.Center;
            // 
            // delRemarks
            // 
            delRemarks.Location = new Point(72, 158);
            delRemarks.Name = "delRemarks";
            delRemarks.Size = new Size(247, 58);
            delRemarks.TabIndex = 6;
            delRemarks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 25);
            label1.Name = "label1";
            label1.Size = new Size(247, 49);
            label1.TabIndex = 5;
            label1.Text = "Add Food";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 297);
            Controls.Add(delete_Food);
            Controls.Add(delFood);
            Controls.Add(delRemarks);
            Controls.Add(label1);
            Name = "RemoveFood";
            Text = "RemoveFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete_Food;
        private TextBox delFood;
        private Label delRemarks;
        private Label label1;
    }
}