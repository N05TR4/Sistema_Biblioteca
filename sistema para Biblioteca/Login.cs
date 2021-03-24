using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_para_Biblioteca
{
    public partial class Login : Form
    {


         public Login()
        {
            InitializeComponent();

         }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = localhost; database= biblioteca; Uid= root; pwd=;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from login where usuario = '"+txtusuario.Text+"' and password = '"+txtcontraseña.Text+"' ");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                this.Hide();
                new sistema().Show();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }

            conectar.Close();







            //if (txtcontraseña.Text == "1234" && txtusuario.Text == "nelfin")
            //{
                 //this.Hide();
                 //new sistema().Show();

            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
