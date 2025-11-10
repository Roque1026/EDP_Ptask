namespace RoqueJustin
{
    partial class ViewProductList
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
            label2 = new Label();
            label3 = new Label();
            foodList = new ListView();
            drinksList = new ListView();
            addFood = new Button();
            removeFood = new Button();
            removeDrinks = new Button();
            addDrinks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(487, 63);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(176, 46);
            label2.TabIndex = 1;
            label2.Text = "FOODS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 88);
            label3.Name = "label3";
            label3.Size = new Size(176, 46);
            label3.TabIndex = 2;
            label3.Text = "DRINKS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodList
            // 
            foodList.Location = new Point(38, 147);
            foodList.Name = "foodList";
            foodList.Size = new Size(180, 204);
            foodList.TabIndex = 3;
            foodList.UseCompatibleStateImageBehavior = false;
            foodList.View = View.List;
            // 
            // drinksList
            // 
            drinksList.Location = new Point(291, 147);
            drinksList.Name = "drinksList";
            drinksList.Size = new Size(176, 204);
            drinksList.TabIndex = 4;
            drinksList.UseCompatibleStateImageBehavior = false;
            drinksList.View = View.List;
            // 
            // addFood
            // 
            addFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addFood.Location = new Point(12, 377);
            addFood.Name = "addFood";
            addFood.Size = new Size(108, 33);
            addFood.TabIndex = 5;
            addFood.Text = "ADD";
            addFood.UseVisualStyleBackColor = true;
            addFood.Click += addFood_Click;
            // 
            // removeFood
            // 
            removeFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeFood.Location = new Point(136, 377);
            removeFood.Name = "removeFood";
            removeFood.Size = new Size(108, 33);
            removeFood.TabIndex = 6;
            removeFood.Text = "REMOVE";
            removeFood.UseVisualStyleBackColor = true;
            removeFood.Click += removeFood_Click;
            // 
            // removeDrinks
            // 
            removeDrinks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeDrinks.Location = new Point(391, 377);
            removeDrinks.Name = "removeDrinks";
            removeDrinks.Size = new Size(108, 33);
            removeDrinks.TabIndex = 8;
            removeDrinks.Text = "REMOVE";
            removeDrinks.UseVisualStyleBackColor = true;
            removeDrinks.Click += removeDrinks_Click;
            // 
            // addDrinks
            // 
            addDrinks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDrinks.Location = new Point(267, 377);
            addDrinks.Name = "addDrinks";
            addDrinks.Size = new Size(108, 33);
            addDrinks.TabIndex = 7;
            addDrinks.Text = "ADD";
            addDrinks.UseVisualStyleBackColor = true;
            addDrinks.Click += addDrinks_Click;
            // 
            // ViewProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(removeDrinks);
            Controls.Add(addDrinks);
            Controls.Add(removeFood);
            Controls.Add(addFood);
            Controls.Add(drinksList);
            Controls.Add(foodList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewProductList";
            Text = "Product Lists";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button addFood;
        private Button removeFood;
        private Button removeDrinks;
        private Button addDrinks;
        public ListView foodList;
        public ListView drinksList;
    }
}