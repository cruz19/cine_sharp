using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pelicula
    {

        private int id;
        private String name;
        private String descripcion;
        private String image;
        private String created;

        public Pelicula()
        {

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
