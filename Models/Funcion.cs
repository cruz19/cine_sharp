using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcion
    {

        private int id;
        private Pelicula pelicula;
        private Horario horario;
        private Sala sala;

        public Funcion()
        {

        }

        //Get and Set methods
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public Pelicula Pelicula
        {
            set { pelicula = value; }
            get { return pelicula; }
        }
        public Horario Horario
        {
            set { horario = value; }
            get { return horario; }
        }
        public Sala Sala
        {
            set { sala = value; }
            get { return sala; }
        }
    }
}
