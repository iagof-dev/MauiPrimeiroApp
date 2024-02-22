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
            Console.WriteLine("Calculando...");
            double resposta2 = 0;
            double resposta = (Math.Pow(A, 2) + 4 * B * C);
            resposta2 = (Math.Pow(A, 2) - 4 * B * C);


            DisplayAlert("Resultado", "Positivo: DELTA = " + A + "² + 4 * " + B + " * " + C + "\nResultado Positivo é: " + resposta + "\nResultado Negativo é: " + resposta2, "Ok");
        }
    }

}
