using System;
using System.Windows.Forms;

namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You might want to handle text changed events if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // You might want to handle text changed events if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // You might want to handle text changed events if needed
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // You might want to handle text changed events if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las notas desde los TextBox
                double nota1 = double.Parse(textBox1.Text);
                double nota2 = double.Parse(textBox2.Text);
                double nota3 = double.Parse(textBox3.Text);

                // Calcular el promedio
                double promedio = (nota1 + nota2 + nota3) / 3;

                // Mostrar el resultado en textBox4
                textBox4.Text = promedio.ToString("F2"); // Formato a 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para las notas.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}

