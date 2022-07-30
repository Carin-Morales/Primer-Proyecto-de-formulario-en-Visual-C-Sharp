using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana2_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre1.Text = "Carin Sanchez";
            nombre2.Text = "Xiomara Machado";
            nombre3.Text = "Patricia Hernandez";
            nombre4.Text = "Elias Gevarra";
            nombre5.Text = " Isaac Nolasco";
            nombre6.Text = " Cindy Romero ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombre1.Text = " ";
            nombre2.Text = " ";
            nombre3.Text = " ";
            nombre4.Text = " ";
            nombre5.Text = " ";
            nombre6.Text = " ";
        }
    }
}
