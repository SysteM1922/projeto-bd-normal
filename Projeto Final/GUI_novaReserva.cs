using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoBDFINAL
{
    public partial class GUI_novaReserva : Form
    {
        private int id;
        private SqlConnection cn;
        public GUI_novaReserva(int id)
        {
            this.id = id;
            InitializeComponent();
            this.cn = getSGBDConnection();
            if (!verifySGBDConnection())
                return;

        }

        private void GUI_novaReserva_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source = GUI\\SQLEXPRESS;integrated security=true;initial catalog=ProjetoFinal");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainpage = new GUI_areaCliente(this.id);
            mainpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String origem = textBox1.Text;
            String destino = textBox2.Text;

            SqlCommand sqlCmd = new SqlCommand("Search", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@Origem", SqlDbType.Text).Value = origem;
            sqlCmd.Parameters.AddWithValue("@Destino", SqlDbType.Text).Value = destino;

            var returnParameter = sqlCmd.Parameters.Add("@res", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            sqlCmd.ExecuteNonQuery();
            int result = Int32.Parse(returnParameter.Value.ToString());

            if (result == 1)
            {
                MessageBox.Show("Erro. Estação de Origem Inválida!");
            }
            else if (result == 2)
            {
                MessageBox.Show("Erro. Estação de Destino Inválida!");
            }
            else
            {
                String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                SqlCommand sqlCmd2 = new SqlCommand("Reserva", cn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd2.Parameters.AddWithValue("@Origem", SqlDbType.Text).Value = origem;
                sqlCmd2.Parameters.AddWithValue("@Destino", SqlDbType.Text).Value = destino;
                sqlCmd2.Parameters.AddWithValue("@Destino", SqlDbType.Date).Value = date;

                var returnParameter2 = sqlCmd.Parameters.Add("@res", SqlDbType.Int);
                returnParameter2.Direction = ParameterDirection.ReturnValue;

                sqlCmd.ExecuteNonQuery();
                int result2 = Int32.Parse(returnParameter2.Value.ToString());

                Form mainpage = new Gui_reservaInfo(this.id);
                mainpage.Show();
                this.Hide();
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
