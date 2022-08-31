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
    public partial class GUI_historicoReservas : Form
    {
        private int id;
        public GUI_historicoReservas(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // passar o id para ver detalhes
            Form mainpage = new Gui_reservaInfo(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_areaCliente(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
