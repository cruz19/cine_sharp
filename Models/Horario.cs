using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Horario
    {
        private int hora;
        private int minutos;
        private String format;

        public Horario(int hora,int minutos,String format)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.format = format;
        }


        //Get and set methods
        public int Hora
        {
            set { hora = value; }
            get { return hora; }
        }
        public int Minutos
        {
            set { minutos = value; }
            get { return minutos; }
        }
        public String Format
        {
            set { format = value; }
            get { return format; }
        }

    }
}
