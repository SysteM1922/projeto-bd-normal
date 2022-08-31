using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBDFINAL
{
    public partial class GUI_dadosPessoais : Form
    {
        private int id;
        public GUI_dadosPessoais(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_areaCliente(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_editarDados(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
