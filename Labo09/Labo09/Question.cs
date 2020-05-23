using System;
using System.Windows.Forms;

namespace Labo09
{
    public partial class Question : UserControl
    {
        public Question()
        {
            InitializeComponent();
        }

        private void consultando_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar los campos vacios.");
            }
            else
            {
                try
                {
                    var pt = ConnectionBDD.ExecuteQuery($"SELECT mat.idMateria, mat.nombre" +
                                                        "FROM INSCRIPCION ins, MATERIA mat, ESTUDIANTE est" +
                                                        $"WHERE ins.idMateria = mat.idMateria " +
                                                        $"AND ins.carnet = {textBox1.Text}");

                    dataGridView1.DataSource = pt;
                    MessageBox.Show("Los datos han sido obtenidos exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}