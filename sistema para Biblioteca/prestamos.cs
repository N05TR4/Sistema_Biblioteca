using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_para_Biblioteca
{
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void Encargado(object sender, EventArgs e)
        {

        }

        private void En(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void prestamos_Load(object sender, EventArgs e)
        {

        }

        private void btnListra_Click(object sender, EventArgs e)
        {
            datagrip(tabla);
        }

        public void datagrip(DataGridView data)
        {
             MySqlConnection conectar = new MySqlConnection("server = localhost; database= biblioteca; Uid= root; pwd=;");
            conectar.Open();
            
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("SELECT * FROM prestamos");
            try
            {
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                seleccionar.Fill(datostabla);
                BindingSource formulario = new BindingSource();
                formulario.DataSource = datostabla;
                data.DataSource = formulario;
                seleccionar.Update(datostabla);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagrip1(tabla);
        }

        public void datagrip1(DataGridView data)
        {
            MySqlConnection conectar = new MySqlConnection("server = localhost; database= biblioteca; Uid= root; pwd=;");
            conectar.Open();
            string libro = txtlibro.Text;
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("SELECT * FROM prestamos WHERE libro= '" + libro + "'");
            try
            {
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                seleccionar.Fill(datostabla);
                BindingSource formulario = new BindingSource();
                formulario.DataSource = datostabla;
                data.DataSource = formulario;
                seleccionar.Update(datostabla);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtmatricula.Clear();
            txtcurso.Clear();
            txtresponsable.Clear();

        }

    }
}
