using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Conexion
    {

        public Conexion()
        {

        }

        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion.ConnectionString = "server=localhost; database=cine_sharp; Uid=root; pwd=;";
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return conexion;
        }

    }
}
