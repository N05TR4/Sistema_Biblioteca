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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }
        
        private void Libros_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }
        //metodo para listar los datos de la tabla libros
        public void datagrip(DataGridView data)
        {

            MySqlConnection conectar = new MySqlConnection("server = localhost; database= biblioteca; Uid= root; pwd=;");
            conectar.Open();
            string autor = txtAutor.Text;
            string materia = txtMateria.Text;
            string tipo_libro = txtTipo_libro.Text;
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("SELECT id, materia, autor, tipo_libro FROM libros WHERE autor= '" + autor + "' AND materia= '" + materia + "' ");
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            //mandando a llamar los datos junto al boton y visualizarlo.
            datagrip(tablaLibro);
        }
    }
}
