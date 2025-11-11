using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoqueJustin
{
    public partial class AddDrinks : Form
    {
        ViewProductList productList;
        public AddDrinks(ViewProductList productList)
        {
            InitializeComponent();
            this.productList = productList;
        }

        private void add_Drinks_Click(object sender, EventArgs e)
        {
            string name;
            string price;

            name = bevName.Text;
            price = bevPrice.Text;

            if (!String.IsNullOrWhiteSpace(bevName.Text) && !String.IsNullOrWhiteSpace(bevPrice.Text))
            {
                if (!productList.drink_List.ContainsKey(name))
                {
                    productList.drink_List.Add(name, Double.Parse(price));
                    addRemarks.Text = name + " = " + Double.Parse(price) + " is added to the list !";
                    productList.setData();
                }
                else
                {
                    addRemarks.Text = name + " = " + Double.Parse(price) + " already exist ...";
                }
            }
            else
            {
                addRemarks.Text = "Text Fields Are Empty !!!";
                if (String.IsNullOrWhiteSpace(bevName.Text))
                {
                    bevName.Focus();
                    bevName.BackColor = Color.MistyRose;
                }
                else if (String.IsNullOrWhiteSpace(bevPrice.Text))
                {
                    bevPrice.Focus();
                    bevPrice.BackColor = Color.MistyRose;
                }
                else {
                    bevName.Focus();
                    bevName.BackColor = Color.MistyRose;
                    bevPrice.BackColor = Color.MistyRose;
                }
            }
        }
    }
}
