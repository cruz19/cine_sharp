using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Sala
    {
        //Atributes
        private int id;
        private String name;
        private int num_asientos;
        private String created;

        //Conexion
        private static MySqlCommand query;
        private static MySqlDataReader statement;

        public Sala()
        {

        }

        public Sala(List<String> request)
        {
            name = request.ElementAt(0);
            num_asientos = Convert.ToInt32(request.ElementAt(1));
            created = obtenerFechaActual();

        }



            //Methods para la base de datos

        public void save()
        {
            String consulta = String.Format("INSERT INTO SALAS(NAME,NUM_ASIENTOS,CREATED) VALUES('{0}',{1},'{2}')", name, num_asientos, created);
            try
            {
                query = new MySqlCommand(consulta,Conexion.obtenerConexion());
                query.ExecuteNonQuery();
                MessageBox.Show("Sala almacenada exitosamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Message");
            }
        }

        public static Boolean exists(String search_sala)
        {
            try
            {
                query = new MySqlCommand(String.Format("SELECT * FROM SALAS WHERE NAME='{0}'",search_sala) , Conexion.obtenerConexion());
                statement = query.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Message");
            }

            return statement.HasRows ? true : false;

        }


        //---------------------------------



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
        public int Num_asientos
        {
            set { num_asientos = value; }
            get { return num_asientos; }
        }
        public String Created
        {
            set { created = value; }
            get { return created; }
        }

    }
}
