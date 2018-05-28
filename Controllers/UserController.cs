using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Models;

namespace Controllers
{
    public class UserController
    {

        public static void create(List<String> request)
        {
            User usuario = new User();
            //Recoleccion de atributos
            usuario.Name = request.ElementAt(0);
            usuario.Nickname = request.ElementAt(1);
            usuario.Password = request.ElementAt(2); 
            usuario.FechaNac = obtenerFechaActual(); //deberia ir la fecha de nacimiento
            //Almacenamiento
            usuario.save();

        }

        private static String obtenerFechaActual()
        {
            DateTime fecha = DateTime.Today;
            return fecha.ToString("yyyy-MM-dd");
        }

        public static User login(String nickname,String password)
        {
            User usuario = User.find(nickname,password);
            return usuario;
        }



    }
}
