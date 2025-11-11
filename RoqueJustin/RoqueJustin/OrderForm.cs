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
        ProcessOrder processorder;
        public OrderForm()
        {
            InitializeComponent();
            processorder = new ProcessOrder();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            processorder.ShowDialog();
        }
    }
}
