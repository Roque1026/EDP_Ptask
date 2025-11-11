using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RoqueJustin
{
    public partial class ViewProductList : Form
    {
        public Hashtable food_List;
        public Hashtable drink_List;
        public ICollection productList;

        AddFood addfood;
        RemoveFood removefood;
        AddDrinks adddrinks;
        RemoveDrinks removedrinks;
        OrderForm orderform;

        public ViewProductList()
        {
            InitializeComponent();
            addfood = new AddFood(this);
            adddrinks = new AddDrinks(this);
            removefood = new RemoveFood(this);
            removedrinks = new RemoveDrinks(this);
            food_List = new Hashtable();
            drink_List = new Hashtable();
            orderform = new OrderForm();
            setData();
        }
        public void setData()
        {
            foodList.Clear();
            drinksList.Clear();
            productList = food_List.Keys;
            foreach (string key in productList)
            {
                foodList.Items.Add(key + " = " + food_List[key].ToString());
                orderform.orderFoodList.Items.Add(key + " = " + food_List[key].ToString());
            }
            productList = drink_List.Keys;
            foreach (string key in productList)
            {
                drinksList.Items.Add(key + " = " + drink_List[key].ToString());
                orderform.orderDrinkList.Items.Add(key+ " = " + food_List[key].ToString());
            }
        }
        private void addFood_Click(object sender, EventArgs e)
        {
            addfood.ShowDialog();
        }

        private void addDrinks_Click(object sender, EventArgs e)
        {
            adddrinks.ShowDialog();
        }

        private void removeFood_Click(object sender, EventArgs e)
        {
            removefood.ShowDialog();
        }

        private void removeDrinks_Click(object sender, EventArgs e)
        {
            removedrinks.ShowDialog();
        }
    }
}
