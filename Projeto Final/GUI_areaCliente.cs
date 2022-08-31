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
    public partial class GUI_areaCliente : Form
    {
        private int id;
        public GUI_areaCliente(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nova reserva
            Form mainpage = new GUI_novaReserva(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //historico reservas
            Form mainpage = new GUI_historicoReservas(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dados pessoais
            Form mainpage = new GUI_dadosPessoais(this.id);
            mainpage.Show();
            this.Hide();
        }
    }
}
