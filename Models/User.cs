using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Models
{
    public class User
    {
        //Atributtes
        private int id;
        private String name;
        private String nickname;
        private String password;
        private String fechaNac;

        //Conexion
        private static MySqlCommand query;
        private static MySqlDataReader statement;

        public User()
        {

        }

        public User(List<String> request)
        {
            name = request.ElementAt(0);
            nickname = request.ElementAt(1);
            password = request.ElementAt(2);
            fechaNac = obtenerFechaActual();
           
        }

        //Methods base de datos

            //Guardar usuarios
        public void save()
        {
            String consulta = String.Format("INSERT INTO USUARIOS(NAME,NICKNAME,PASSWORD,FECHA_NAC) VALUES ('{0}','{1}','{2}','{3}')" ,name,nickname,password,fechaNac);
            query = new MySqlCommand(consulta,Conexion.obtenerConexion());
            query.ExecuteNonQuery();
            MessageBox.Show("Usuario registrado exitosamente");

        }

        public String obtenerFechaActual()
        {
            DateTime fecha = DateTime.Today;
            return fecha.ToString("yyyy-MM-dd");
        }

            //Busqueda de usuarios
        public static User find(String search_nick,String search_pass)
        {
            String consulta = String.Format("SELECT * FROM USUARIOS WHERE NICKNAME='{0}' AND PASSWORD='{1}'", search_nick, search_pass);
            query = new MySqlCommand(consulta , Conexion.obtenerConexion() );
            statement = query.ExecuteReader();

            User usuario;
            if (statement.HasRows) //Si el registro existe
            {
                usuario = new User();
                statement.Read(); //Leer 
                usuario.Id = statement.GetInt32(0);
                usuario.Name = statement.GetString(1);
                usuario.Nickname = statement.GetString(2);
                usuario.Password = statement.GetString(3);
                usuario.FechaNac = statement.GetString(4);
            }
            else
            {
                usuario = null; //No existe en la base de datos
            }

            return usuario;
        } 

        //Get and Set methods

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public String Nickname
        {
            set { nickname = value; }
            get { return nickname; }

        }
        public String Password
        {
            set { password = value; }
            get { return password; }
        }
        public String FechaNac
        {
            set { fechaNac = value; }
            get { return fechaNac; }
        }


    }
}
