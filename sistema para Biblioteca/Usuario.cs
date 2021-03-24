using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_para_Biblioteca.Clases;
using MySql.Data.MySqlClient;


namespace sistema_para_Biblioteca
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

      

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string telefono = txtTelefono.Text;
            string id_usuario = txtidusuario.Text;
            string direccion = txtdireccion.Text;
            string tipo_usuario = txtTipo_usuario.Text;

            string sql = "INSERT INTO registro_usuario(id, nombre, apellido, telefono, id_usuario, direccion,tipo_usuario)VALUES(NULL,'" + nombre + "', '" + apellido + "','" + telefono + "','" + id_usuario + "','" + direccion + "','" + tipo_usuario + "')";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO GURARDADO");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR!: " + ex.Message);
            }

            finally
            {
                conexionBD.Close();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            txtnombre.Clear();
            txtapellido.Clear();
            txtdireccion.Clear();
            txtidusuario.Clear();
            txtTelefono.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
