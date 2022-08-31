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
    public partial class confirmReserva : Form
    {
        private int id;
        public confirmReserva(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainpage = new resultadoPesquisa(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check stuff db
            MessageBox.Show("Reserva confirmada!");

            // vais ter q passar o id da reserva eventually
            Form mainpage = new Gui_reservaInfo(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirmReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
