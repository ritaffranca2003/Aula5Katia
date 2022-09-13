using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5Katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Time obj = new Time();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Time timinho = new Time();
            //MessageBox.Show("Nome: " + timinho.Nome + "\tPais" + timinho.Pais + "\nEstado: " + timinho.Estado +
            //    "\nTitulo: " + timinho.Titulo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Nome = txtNome.Text;
            obj.Pais = txtPais.Text;
            obj.Estado = txtEstado.Text;
            obj.Titulo = Convert.ToInt32(txtTitulo.Text);

        }
    }
}
