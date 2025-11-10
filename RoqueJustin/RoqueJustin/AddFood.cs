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
    public partial class AddFood : Form
    {
        ViewProductList viewlist;
        public AddFood( ViewProductList prodList )
        {
            InitializeComponent();
            viewlist = prodList;
        }

        private void add_Food_Click(object sender, EventArgs e)
        {
            string name;
            string price;

            name = foodName.Text;
            price = foodPrice.Text;

            if (!String.IsNullOrWhiteSpace(foodName.Text) && !String.IsNullOrWhiteSpace(foodPrice.Text))
            {
                if (!viewlist.food_List.ContainsKey(name))
                {
                    viewlist.food_List.Add(name, Double.Parse(price));
                    addRemarks.Text = name + " = " + Double.Parse(price) + " is added to the list !";
                    viewlist.setData();
                }
                else
                {
                    addRemarks.Text = name + " = " + Double.Parse(price) + " already exist ...";
                }
            }
            else
            {
                addRemarks.Text = "Text Fields Are Empty !!!";
                if (String.IsNullOrWhiteSpace(foodName.Text))
                {
                    foodName.Focus();
                    foodName.BackColor = Color.MistyRose;
                }
                else if (String.IsNullOrWhiteSpace(foodPrice.Text))
                {
                    foodPrice.Focus();
                    foodPrice.BackColor = Color.MistyRose;
                }
                else
                {
                    foodName.Focus();
                    foodPrice.BackColor = Color.MistyRose;
                    foodPrice.BackColor = Color.MistyRose;
                }
            }
        }
    }
}
