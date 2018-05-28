using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

namespace Controllers
{
    public class PeliculaController
    {

        public static void create(List<String> request)
        {
            Pelicula pelicula = new Pelicula();
                //Recolectar datos
            pelicula.Name = request.ElementAt(0);
            pelicula.Descripcion = request.ElementAt(1);
            pelicula.Image = request.ElementAt(2);
            pelicula.Created = getFechaActual();
                //Almacenar la pelicula
            pelicula.save(); 
        }

        public static Boolean exists(String name)
        {

        } 

        private static String getFechaActual()
        {
            DateTime fecha = DateTime.Today;
            return fecha.ToString("yyyy-MM-dd");
        }



    }
}
