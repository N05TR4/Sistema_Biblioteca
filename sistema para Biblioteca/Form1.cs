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
using sistema_para_Biblioteca.Clases;

namespace sistema_para_Biblioteca
{
    public partial class sistema : Form
    {
        

        MySqlConnection conexion = new MySqlConnection("SERVER=localhost; DATABASE=biblioteca; UID=root; PASSWORD=;");

        public sistema()
        {
            InitializeComponent();

                         

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            new Usuario().Show();
        }

        private void btnprestamo_Click(object sender, EventArgs e)
        {
                        new prestamos().Show();

        }

        private void btnlibros_Click(object sender, EventArgs e)
        {
                        new Libros().Show();
                        
        }

        private void btninforme_Click(object sender, EventArgs e)
        {

        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void herramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show(); 
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void novelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void cuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void historiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void lenguaYLiteraturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void matematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void lgebraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void filosofiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void francesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void fisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void librosYObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void enciclopediasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void lapizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void cuadernoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void borradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void otrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new prestamos().Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ayuda().Show(); 
        }

        private void recordDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Record_de_libros().Show();
        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuario ().Show();
        }

       

        private void sistema_Load(object sender, EventArgs e)
        {

        }

       

       //private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
       // {
          //  try
           //{
              //  conexion.Open();
                //MessageBox.Show("Conectado");
                //conexion.Close();

            //}
            //catch (Exception)
           // {
                //MessageBox.Show("ERROR!");
 
            //}
        //}

        }
    }

