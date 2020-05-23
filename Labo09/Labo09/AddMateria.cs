using System;
using System.Windows.Forms;

namespace Labo09
{
    public partial class AddMateria : UserControl
    {
        public AddMateria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar casillas en blanco");
            }
            else
            {
                try
                {
                    ConnectionBDD.ExecuteNonQuery($"INSERT INTO MATERIA(nombre) VALUES ('{textBox1.Text}')");
                    MessageBox.Show("Se ha agregado la materia.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error.");

                }
            }
        }
    }
}