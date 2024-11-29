using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_number(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResult.Text == "0")

                txtResult.Text = "";

            txtResult.Text += boton.Text;

        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtResult.Text);
            operador= Convert.ToChar(boton.Tag);

            txtResult.Text = "0";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            operador = '+';
        }

        private void btnrespuesta_Click(object sender, EventArgs e)
        {
            num2= Convert.ToDouble(txtResult.Text);
            if(operador == '+')
            {
                txtResult.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtResult.Text);
            }
        }
    }
}
