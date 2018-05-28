using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Models
{
    public class Pelicula
    {
        //Atributtes
        private int id;
        private String name;
        private String descripcion;
        private String image;
        private String created;

        //Conexion
        private static MySqlCommand query;
        private static MySqlDataReader statement;

        public Pelicula()
        {

        }

        public Pelicula(List<String> request)
        {
            name = request.ElementAt(0);
            descripcion = request.ElementAt(1);
            image = request.ElementAt(2);
            created = obtenerFechaActual();
        }

        //Methods para la base de datos
        public void save()
        {
            String consulta = String.Format("INSERT INTO PELICULAS(NAME,DESCRIPCION,RUTA_IMAGE,CREATED) VALUES ('{0}','{1}','{2}','{3}')",name,descripcion,image,created);

            try
            {
                query = new MySqlCommand(consulta, Conexion.obtenerConexion());
                query.ExecuteNonQuery();
                MessageBox.Show("Pelicula almacenada exitosamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Message");
            }
        }

        public static Boolean exists(String search_pelicula)
        {

            try
            {
                query = new MySqlCommand(String.Format("SELECT * FROM PELICULAS WHERE NAME='{0}'", search_pelicula), Conexion.obtenerConexion());
                statement = query.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Message");
            }

            return statement.HasRows ? true : false;
        }

        public String obtenerFechaActual()
        {
            DateTime fecha = DateTime.Today;
            return fecha.ToString("yyyy-MM-dd");
        }


        //Get and Set methods
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public String Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public String Image
        {
            set { image = value; }
            get { return image; }
        }
        public String Created
        {
            set { created = value; }
            get { return created; }
        }
    }
}
