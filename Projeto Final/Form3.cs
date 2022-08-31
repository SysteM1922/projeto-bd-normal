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

namespace Projeto_Final
{
    public partial class Form3 : Form
    {
        private SqlConnection cn;
        public Form3()
        {
            InitializeComponent();
            this.cn = getSGBDConnection();
            if (!verifySGBDConnection())
                return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
            String nome = textBox1.Text;
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int CC = Int32.Parse(textBox3.Text);
            String Email = textBox2.Text;
            int tel = Int32.Parse(textBox3.Text);

            SqlCommand sqlCmd = new SqlCommand("Registar", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@Nome", SqlDbType.Text).Value = nome;
            sqlCmd.Parameters.AddWithValue("@Data_Nascimento", SqlDbType.Date).Value = date;
            sqlCmd.Parameters.AddWithValue("@CC", SqlDbType.Int).Value = CC;
            sqlCmd.Parameters.AddWithValue("@Email", SqlDbType.Text).Value = Email;
            sqlCmd.Parameters.AddWithValue("@Telefone", SqlDbType.Int).Value = tel;

            var returnParameter = sqlCmd.Parameters.Add("@res", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            sqlCmd.ExecuteNonQuery();
            int result = Int32.Parse(returnParameter.Value.ToString());

            if(result == 0)
            {
                MessageBox.Show("Erro. Este email já está registado!");
            }
            else
            {
                MessageBox.Show("Sucesso");
                Form form = new Form2();
                form.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
