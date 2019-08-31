using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_desde_la_web
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Boton6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Boton7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Boton8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Boton9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Botondecimal_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

        private void Botonmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Botonmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Botonmult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Botondiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
        private void Botonporciento_Click(object sender, EventArgs e)
        {

        }

        private void Botonigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            switch(operador)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "%":
                    MessageBox.Show("error 404");  
                    break;
            }
        }

        private void Botonce_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Botonc_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

    
    }
}
