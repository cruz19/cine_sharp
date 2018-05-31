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
using Models;

namespace Views
{
    public partial class VerResultados : Form
    {

        private MySqlDataAdapter stmt_adapter;
        private DataTable stmt_table; 

        public VerResultados(String consulta)
        {
            InitializeComponent();
            stmt_adapter = new MySqlDataAdapter(consulta, Conexion.obtenerConexion());
            lblTitulo.Text = consulta.Contains("PELICULAS")? "Listado de películas" : consulta.Contains("SALAS")? "Listado de salas" :  "Listado de funciones";
            myInitComponents();
        }

        public void myInitComponents()
        {
            stmt_table = new DataTable();
            refreshDataGridView();
        }

        public void refreshDataGridView()
        {
           stmt_adapter.Fill(stmt_table);
           dataGridView1.DataSource = stmt_table;
        }

    }
}
