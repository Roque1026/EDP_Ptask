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
    public partial class OrderForm : Form
    {
        ViewProductList viewList;
        public OrderForm()
        {
            InitializeComponent();
            viewList = new ViewProductList();
            setOrderData();
        }
        public void setOrderData()
        {
            orderFoodList.Clear();
            orderDrinkList.Clear();
            viewList.productList = viewList.food_List.Keys;
            foreach (string key in viewList.productList)
            {
                orderFoodList.Items.Add(key + " = " + viewList.food_List[key].ToString());
            }
            viewList.productList = viewList.drink_List.Keys;
            foreach (string key in viewList.productList)
            {
                orderDrinkList.Items.Add(key + " = " + viewList.drink_List[key].ToString());
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {

        }
    }
}
