using System;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        { 

        }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { 

        }

        private void textBox5_TextChanged(object sender, EventArgs e) 
        {

        }

        // Calcular Semi-perímetro del triángulo con los TextBox 1, 2, 3
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las longitudes de los lados del triángulo
                double lado1 = double.Parse(textBox1.Text);
                double lado2 = double.Parse(textBox2.Text);
                double lado3 = double.Parse(textBox3.Text);

                // Calcular semi-perímetro
                double semiPerimetro = (lado1 + lado2 + lado3) / 2;

                // Mostrar el resultado en textBox4
                textBox4.Text = semiPerimetro.ToString("F2"); // Formato a 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados del triángulo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculamos el área del triángulo
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las longitudes de los lados del triángulo
                double lado1 = double.Parse(textBox1.Text);
                double lado2 = double.Parse(textBox2.Text);
                double lado3 = double.Parse(textBox3.Text);

                // Calcular semi-perímetro para el área
                double semiPerimetro = (lado1 + lado2 + lado3) / 2;

                // Usar la fórmula de Herón para calcular el área
                double area = Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));

                // Mostrar el resultado en textBox5
                textBox5.Text = area.ToString("F2"); // Formato a 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados del triángulo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("El área no puede ser calculada con los valores dados. Verifica que los lados formen un triángulo válido.", "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiamos la pantalla
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // Salimos del programa
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
