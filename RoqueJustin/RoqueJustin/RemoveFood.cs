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
    public partial class RemoveFood : Form
    {
        ViewProductList viewlist;
        public RemoveFood(ViewProductList viewlist )
        {
            InitializeComponent();
            this.viewlist = viewlist;
        }

        private void delete_Food_Click(object sender, EventArgs e)
        {
            string name = delFood.Text;

            if (!String.IsNullOrWhiteSpace(delFood.Text))
            {
                if (viewlist.food_List.ContainsKey(name))
                {
                    viewlist.food_List.Remove(name);
                    delRemarks.Text = name + " is removed from the list !!!";
                }
                else { delRemarks.Text = name + " doesn't exist in the list..."; }
            }
            else {
                delFood.Focus();
                delFood.BackColor = Color.MistyRose;
                delRemarks.Text = "Textfields are Empty..";
            }
        }
    }
}
