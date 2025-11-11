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
            viewProducts = new Button();
            orderProducts = new Button();
            SuspendLayout();
            // 
            // viewProducts
            // 
            viewProducts.BackColor = SystemColors.Control;
            viewProducts.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewProducts.Location = new Point(114, 91);
            viewProducts.Name = "viewProducts";
            viewProducts.Size = new Size(299, 115);
            viewProducts.TabIndex = 0;
            viewProducts.Text = "View Products";
            viewProducts.UseVisualStyleBackColor = false;
            viewProducts.Click += button1_Click;
            // 
            // orderProducts
            // 
            orderProducts.BackColor = SystemColors.Control;
            orderProducts.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderProducts.Location = new Point(114, 247);
            orderProducts.Name = "orderProducts";
            orderProducts.Size = new Size(299, 115);
            orderProducts.TabIndex = 1;
            orderProducts.Text = "Order";
            orderProducts.UseVisualStyleBackColor = false;
            orderProducts.Click += button2_Click;
            // 
            // ProductOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(531, 450);
            Controls.Add(orderProducts);
            Controls.Add(viewProducts);
            Name = "ProductOrder";
            Text = "PRODUCT_ORDER";
            ResumeLayout(false);
        }

        #endregion

        private Button viewProducts;
        private Button orderProducts;
    }
}
