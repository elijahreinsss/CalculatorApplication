namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        private CalculatorClass calc;
        private double num1, num2;

        public Form1()


        {

            InitializeComponent();
            calc = new CalculatorClass();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxInput1.Text, out num1) && double.TryParse(txtBoxInput2.Text, out num2))
            {
                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        calc.formula = calc.GetSum;
                        lblDisplayTotal.Text = calc.formula(num1, num2).ToString();
                        break;
                    case "-":
                        calc.formula = calc.Getdiff;
                        lblDisplayTotal.Text = calc.formula(num1, num2).ToString();
                        break;
                    case "*":
                        calc.formula = calc.GetMultiply;
                        lblDisplayTotal.Text = calc.formula(num1, num2).ToString();
                        break;
                    case "/":
                        calc.formula = calc.GetQuotient;
                        lblDisplayTotal.Text = calc.formula(num1, num2).ToString();
                        break;


                    default:
                        MessageBox.Show("Invalid operator selected.");
                        break;

                }
            }
        }
    }
}
        
   




