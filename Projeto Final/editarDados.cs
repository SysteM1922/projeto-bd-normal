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
    public partial class GUI_editarDados : Form
    {
        private int id;
        public GUI_editarDados(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // confirm stuff

            //then enviar para a pagina dos dados pessoais
            Form mainpage = new GUI_dadosPessoais(this.id);
            mainpage.Show();
            this.Hide();
        }
    }
}
