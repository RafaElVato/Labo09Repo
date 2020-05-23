using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo09
{
    public partial class Form1 : Form
    {
        private UserControl current = null;
        
        public Form1()
        {
            InitializeComponent();
            current = resgister1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Resgister();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetRowSpan(current,4);
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AddMateria();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetRowSpan(current,4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Inscripcion();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetRowSpan(current,4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Question();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetRowSpan(current,4);
        }
        
    }
}