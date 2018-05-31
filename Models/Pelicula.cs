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
        private int duracion;
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
            duracion = Convert.ToInt32(request.ElementAt(3));
            created = obtenerFechaActual();
        }

        public String getFormatDuracion()
        {
            int horas = (duracion / 60);
            String cad_horas = horas <= 9 ? "0" + horas.ToString() : horas.ToString();
            int minutos = (duracion % 60);
            String cad_minutos = minutos <= 9 ? "0" + minutos.ToString() : minutos.ToString();

            return cad_horas + ":" +cad_minutos;
        }

        //Methods para la base de datos

        public static List<Pelicula> all() //Obtener todas las peliculas existenetes en la base de datos
        {
            List<Pelicula> peliculas = new List<Pelicula>();

            try
            {
                query = new MySqlCommand("SELECT * FROM PELICULAS", Conexion.obtenerConexion());
                statement = query.ExecuteReader();

                while (statement.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.Id = statement.GetInt32(0);
                    pelicula.Name = statement.GetString(1);
                    pelicula.Descripcion = statement.GetString(2);
                    pelicula.Image = statement.GetString(3);
                    pelicula.Duracion = statement.GetInt32(4);
                    pelicula.Created = statement.GetString(5);

                    peliculas.Add(pelicula);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return peliculas;

        }

        public static Pelicula find(String search_pelicula)
        {

            Pelicula pelicula = new Pelicula();

            try
            {

                query = new MySqlCommand(String.Format("SELECT * FROM PELICULAS WHERE NAME='{0}'",search_pelicula) , Conexion.obtenerConexion());
                statement = query.ExecuteReader();
                statement.Read();

                //Crear nuevo objeto de tipo Pelicula
                pelicula.Id = statement.GetInt32(0);
                pelicula.Name = statement.GetString(1);
                pelicula.Descripcion = statement.GetString(2);
                pelicula.Image = statement.GetString(3);
                pelicula.Duracion = statement.GetInt32(4);
                pelicula.Created = statement.GetString(5);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return pelicula;

        }

        public void save()
        {
            String consulta = String.Format("INSERT INTO PELICULAS(NAME,DESCRIPCION,RUTA_IMAGE,DURACION,CREATED) VALUES ('{0}','{1}','{2}',{3},'{4}')",name,descripcion,image,duracion,created);

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

        private String obtenerFechaActual()
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
        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
        public String Created
        {
            set { created = value; }
            get { return created; }
        }
    }
}
