namespace RoqueJustin
{
    public partial class ProductOrder : Form
    {
        ViewProductList viewlist;
        public ProductOrder()
        {
            InitializeComponent();
            viewlist = new ViewProductList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            viewlist.ShowDialog();
        }
    }
}
