using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Labo09
{
    public partial class Inscripcion : UserControl
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            var subjects = ConnectionBDD.ExecuteQuery("SELECT nombre FROM MATERIA");
            var subjectsCombo = new List<string>();

            foreach (DataRow er in subjects.Rows)
            {
                subjectsCombo.Add(er[0].ToString());
            }

            comboBox1.DataSource = subjectsCombo;

            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar casillas en blanco");
            }
            else
            {
                try
                {
                    string Query =
                        $"SELECT idMateria FROM materia WHERE nombre = '{comboBox1.SelectedItem.ToString()}'";

                    var dt = ConnectionBDD.ExecuteQuery(Query);
                    var materiaid = Convert.ToInt32(dt.Rows[0]);

                    string nonQuery = $"INSERT INTO INSCRIPCION(idMateria, carnet,) VALUES(" +
                                      $"'{materiaid}')" +
                                      $"'{textBox1.Text}')";

                    ConnectionBDD.ExecuteNonQuery(nonQuery);
                    MessageBox.Show("Se ha inscrito la materia");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error.");

                }
            }
        }
    }
}