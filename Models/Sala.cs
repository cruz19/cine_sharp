using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sala
    {

        private int id;
        private String name;
        private int num_asientos;
        private String created;

        public Sala()
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
