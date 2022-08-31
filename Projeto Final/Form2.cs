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
using ProjetoBDFINAL;

namespace Projeto_Final
{
    public partial class Form2 : Form
    {

        private SqlConnection cn;

        public Form2()
        {
            
            InitializeComponent();
            this.cn=getSGBDConnection();
            if (!verifySGBDConnection())
                return;
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
            String email = textBox1.Text;
            SqlCommand sqlCommand = new SqlCommand("CheckEmail", this.cn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@email", SqlDbType.Text).Value = email;

            var rtn = sqlCommand.Parameters.Add("@temp", SqlDbType.Int);
            rtn.Direction = ParameterDirection.ReturnValue;

            sqlCommand.ExecuteNonQuery();
            int check = Int32.Parse(rtn.Value.ToString());

            if (check == 0){
                MessageBox.Show("Erro! Email inválido!");
            }
            else
            {
                Form form = new GUI_areaCliente(check);
                form.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form form = new pagInicial();
            form.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
