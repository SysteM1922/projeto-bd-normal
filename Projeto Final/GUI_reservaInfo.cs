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
    public partial class Gui_reservaInfo : Form
    {
        private int id;
        //public GUI_reservaInfo(int idReserva)
        public Gui_reservaInfo(int id)
        {
            InitializeComponent();
            this.id = id;
            //atualizar a label automaticammente de acordo com o ID da viagem passada
            //label1.Text = label1.Text + idReserva + "]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_historicoReservas(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_historicoReservas(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void reservaInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
