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
    public partial class ProcessOrder : Form
    {
        ViewProductList list;

        static int total = 0;
        public ProcessOrder()
        {
            InitializeComponent();
            list = new ViewProductList();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            string name;

            name = orderName.Text;
            if (list.food_List.ContainsKey(name) || list.drink_List.ContainsKey(name)) {
                orderList.Items.Add(name +" - "+ list.food_List[name]);
                total += (int)list.food_List[name];
                
            }

            totalAmount.Text = "₱" + total;
        }
    }
}
