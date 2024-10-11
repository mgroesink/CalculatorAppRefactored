namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculate_Clicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            char operation = (sender as Button)!.Text.TrimStart().TrimEnd()[0];
            try
            {
                var result = Calculator.Calculate(number1, number2, operation);
                if (operation == '/')
                {
                    ResultLabel.Text = result.ToString("F2");
                }
                else
                {
                    ResultLabel.Text = result.ToString("F0");
                }
            }
            catch (DivideByZeroException ex)
            {
                ResultLabel.Text = ex.Message;
            }
            catch (InvalidOperationException ex)
            {
                ResultLabel.Text = ex.Message;
            }

        }

        private void OnCalculateResults_Clicked(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Input1.Text);
            int number2 = Convert.ToInt32(Input2.Text);
            Calculator.Calculate(number1, number2, out double sum, out double difference, out double product, out double quotient, out double remainder);
            var results = $"Sum: {sum}\nDifference: {difference}\nProduct: {product}\nQuotient: {quotient}\nRemainder: {remainder}";
            DisplayAlert("Results", results, "OK");
        }
    }

}
