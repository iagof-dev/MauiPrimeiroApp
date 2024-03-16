namespace MauiAppTeste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnCalcular_Clicked_1(object sender, EventArgs e)
        {

          

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double A = Double.Parse(num1.Text);
            double B = Double.Parse(num2.Text);
            double C = Double.Parse(num3.Text);
            double delta = (B * B) - (4 * A * C);

            double r1 = ((-1 * B) + Math.Sqrt(delta)) / (2 * A);
            double r2 = ((-1 * B) - Math.Sqrt(delta)) / (2 * A); ;

            DisplayAlert("Resultado", "Resultado é: " + r1 + " e " + r2, "Ok");
        }
    }

}
