namespace RoqueJustin
{
    partial class OrderForm
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
            orderDrinkList = new ListView();
            orderFoodList = new ListView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Order = new Button();
            SuspendLayout();
            // 
            // orderDrinkList
            // 
            orderDrinkList.Location = new Point(292, 150);
            orderDrinkList.Name = "orderDrinkList";
            orderDrinkList.Size = new Size(176, 204);
            orderDrinkList.TabIndex = 9;
            orderDrinkList.UseCompatibleStateImageBehavior = false;
            orderDrinkList.View = View.List;
            // 
            // orderFoodList
            // 
            orderFoodList.Location = new Point(39, 150);
            orderFoodList.Name = "orderFoodList";
            orderFoodList.Size = new Size(180, 204);
            orderFoodList.TabIndex = 8;
            orderFoodList.UseCompatibleStateImageBehavior = false;
            orderFoodList.View = View.List;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 91);
            label3.Name = "label3";
            label3.Size = new Size(176, 46);
            label3.TabIndex = 7;
            label3.Text = "DRINKS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 91);
            label2.Name = "label2";
            label2.Size = new Size(176, 46);
            label2.TabIndex = 6;
            label2.Text = "FOODS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(487, 63);
            label1.TabIndex = 5;
            label1.Text = "ORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Order
            // 
            Order.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order.Location = new Point(172, 370);
            Order.Name = "Order";
            Order.Size = new Size(155, 57);
            Order.TabIndex = 10;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = true;
            Order.Click += Order_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(Order);
            Controls.Add(orderDrinkList);
            Controls.Add(orderFoodList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
        }

        #endregion

        public ListView orderDrinkList;
        public ListView orderFoodList;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Order;
    }
}