namespace RoqueJustin
{
    partial class ProcessOrder
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
            label2 = new Label();
            orderName = new TextBox();
            addOrder = new Button();
            removeOrder = new Button();
            orderList = new ListView();
            label1 = new Label();
            totalAmount = new Label();
            label4 = new Label();
            label5 = new Label();
            change = new Label();
            textBox1 = new TextBox();
            pay = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 18);
            label2.Name = "label2";
            label2.Size = new Size(487, 63);
            label2.TabIndex = 6;
            label2.Text = " PROCESS ORDER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderName
            // 
            orderName.Location = new Point(29, 84);
            orderName.Multiline = true;
            orderName.Name = "orderName";
            orderName.Size = new Size(310, 37);
            orderName.TabIndex = 7;
            // 
            // addOrder
            // 
            addOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addOrder.Location = new Point(361, 84);
            addOrder.Name = "addOrder";
            addOrder.Size = new Size(94, 37);
            addOrder.TabIndex = 8;
            addOrder.Text = "add";
            addOrder.UseVisualStyleBackColor = true;
            addOrder.Click += addOrder_Click;
            // 
            // removeOrder
            // 
            removeOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeOrder.Location = new Point(480, 84);
            removeOrder.Name = "removeOrder";
            removeOrder.Size = new Size(94, 37);
            removeOrder.TabIndex = 9;
            removeOrder.Text = "remove";
            removeOrder.UseVisualStyleBackColor = true;
            // 
            // orderList
            // 
            orderList.Location = new Point(76, 137);
            orderList.Name = "orderList";
            orderList.Size = new Size(250, 291);
            orderList.TabIndex = 10;
            orderList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.Location = new Point(346, 171);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 11;
            label1.Text = "Total :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalAmount
            // 
            totalAmount.Location = new Point(464, 171);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(82, 32);
            totalAmount.TabIndex = 12;
            totalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(346, 227);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 13;
            label4.Text = "Payment :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(346, 327);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 14;
            label5.Text = "Change :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // change
            // 
            change.Location = new Point(464, 327);
            change.Name = "change";
            change.Size = new Size(82, 32);
            change.TabIndex = 15;
            change.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 16;
            // 
            // pay
            // 
            pay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay.Location = new Point(480, 277);
            pay.Name = "pay";
            pay.Size = new Size(94, 37);
            pay.TabIndex = 17;
            pay.Text = "Pay";
            pay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(480, 466);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 18;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = true;
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 552);
            Controls.Add(button1);
            Controls.Add(pay);
            Controls.Add(textBox1);
            Controls.Add(change);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(totalAmount);
            Controls.Add(label1);
            Controls.Add(orderList);
            Controls.Add(removeOrder);
            Controls.Add(addOrder);
            Controls.Add(orderName);
            Controls.Add(label2);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox orderName;
        private Button addOrder;
        private Button removeOrder;
        private ListView orderList;
        private Label label1;
        private Label totalAmount;
        private Label label4;
        private Label label5;
        private Label change;
        private TextBox textBox1;
        private Button pay;
        private Button button1;
    }
}