using System;
using System.Windows.Forms;

namespace Laboratorio12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la velocidad y el tiempo desde los TextBox
                double velocidad = double.Parse(textBox1.Text);
                double tiempo = double.Parse(textBox2.Text);

                // Calcular la distancia
                double distancia = velocidad * tiempo;

                // Mostrar el resultado en textBox3
                textBox3.Text = distancia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para la velocidad y el tiempo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Uso para introducir los Valores de Velocidad (textBox1) y tiempo (textBox2)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este método puede permanecer vacío 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Este método puede permanecer vacío 
        }   

        // Mostramos el resultado del problema
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Este método puede permanecer vacío 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
