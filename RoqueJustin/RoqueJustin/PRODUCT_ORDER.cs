namespace RoqueJustin
{
    public partial class ProductOrder : Form
    {
        ViewProductList viewlist;
        OrderForm orderform;
        public ProductOrder()
        {
            InitializeComponent();
            viewlist = new ViewProductList();
            orderform = new OrderForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            viewlist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderform.ShowDialog();
        }
    }
}
