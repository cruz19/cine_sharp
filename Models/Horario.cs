using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Horario
    {
        //Atributtes
        private int hora;
        private int minutos;

        //Constructores
        public Horario(int hora,int minutos)
        {
            this.hora = hora;
            this.minutos = minutos;
        }

        public Horario(String cadena_horario)
        {
            this.hora = Convert.ToInt32(cadena_horario.Substring(0, cadena_horario.IndexOf(":")));
            cadena_horario = cadena_horario.Substring(cadena_horario.IndexOf(":")+1);
            this.minutos = Convert.ToInt32(cadena_horario.Substring(0, cadena_horario.IndexOf(":")));

        }

        //------------------------------------------
        public String getHorario()
        {
            return hora + ":" + minutos + ":00";
        }

        public static int[] obtenerHorarioFinal(int hora,int minutos,int duracion)
        {

            int minutos_totales = (hora * 60) + minutos + duracion;
            int horas = minutos_totales/60!=24? minutos_totales/60 : 0;
            horas = horas>24? horas-24 : horas; 

            int[] hora_format = { (horas), (minutos_totales % 60) }; //horas[0] minutos[1]

            return hora_format;

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

    }
}
