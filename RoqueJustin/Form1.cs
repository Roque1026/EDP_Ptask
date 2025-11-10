namespace RoqueJustin
{
    public partial class Form1 : Form
    {
        public static int num1, num2;
        public static string fname = "", lname = "";

        getValue<string> Fullname;
        getValue<int> Sum;
        getValue<int> Difference;
        getValue<int> Product;
        getValue<int> Quotient;
        public Form1()
        {
            InitializeComponent();
            Fullname = new getValue<string>(getData.getName);
            Sum = new getValue<int>(getData.Add);
            Difference = new getValue<int>(getData.Subtract);
            Product = new getValue<int>(getData.Multiply);
            Quotient = new getValue<int>(getData.Divide);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(firstNumber.Text);
            num2 = Int32.Parse(secondNumber.Text);
            fname = firstName.Text;
            lname = lastName.Text;

            MessageBox.Show("Hi ! " + Fullname(lname, fname) + "\nSum : " + Sum(num1, num2), "OUTPUT");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(firstNumber.Text);
            num2 = Int32.Parse(secondNumber.Text);
            fname = firstName.Text;
            lname = lastName.Text;

            MessageBox.Show("Hi ! " + Fullname(lname, fname) + "\nDifference : " + Difference(num1, num2), "OUTPUT");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(firstNumber.Text);
            num2 = Int32.Parse(secondNumber.Text);
            fname = firstName.Text;
            lname = lastName.Text;

            MessageBox.Show("Hi ! " + Fullname(lname, fname) + "\nProduct : " + Product(num1, num2), "OUTPUT");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(firstNumber.Text);
            num2 = Int32.Parse(secondNumber.Text);
            fname = firstName.Text;
            lname = lastName.Text;

            MessageBox.Show("Hi ! " + Fullname(lname, fname) + "\nQuotient : " + Quotient(num1, num2), "OUTPUT");
        }

        public delegate genericData getValue<genericData>(genericData value1, genericData value2);

        public class getData
        {
            public static int Total;
            public static string FullName = "";

            public static int Add(int a, int b)
            {
                Total = a + b;
                return Total;
            }
            public static int Subtract(int a, int b)
            {
                Total = a - b;
                return Total;
            }
            public static int Multiply(int a, int b)
            {
                Total = a * b;
                return Total;
            }
            public static int Divide(int a, int b)
            {
                Total = a / b;
                return Total;
            }
            public static string getName(string a, string b)
            {
                FullName = a + ", " + b;
                return FullName;
            }
        }

        
    }
}
