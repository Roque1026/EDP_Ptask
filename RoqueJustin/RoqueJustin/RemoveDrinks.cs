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
    public partial class RemoveDrinks : Form
    {
        ViewProductList productList;
        public RemoveDrinks(ViewProductList productList)
        {
            InitializeComponent();
            this.productList = productList;
        }

        private void delete_Beverage_Click(object sender, EventArgs e)
        {
            string name = delBeverage.Text;

            if (!String.IsNullOrWhiteSpace(delBeverage.Text))
            {
                if (productList.food_List.ContainsKey(name))
                {
                    productList.food_List.Remove(name);
                    delRemarks.Text = name + " is removed from the list !!!";
                }
                else { delRemarks.Text = name + " doesn't exist in the list..."; }
            }
            else
            {
                delBeverage.Focus();
                delBeverage.BackColor = Color.MistyRose;
                delRemarks.Text = "Textfields are Empty..";
            }
        }
    }
}
