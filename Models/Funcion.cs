using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Funcion
    {

        //Attributes
        private int id;
        private Pelicula pelicula;
        private Horario horario_inicio;
        private Horario horario_final;
        private Sala sala;
        private String created; 
        //Conexion
        private static MySqlDataReader statement;
        private static MySqlCommand query;


        public Funcion()
        {

        }

        public Funcion(Pelicula pelicula, Horario horario_inicio, Sala sala)
        {
            this.pelicula = pelicula;
            this.horario_inicio = horario_inicio;
                //Definir hora_final segun la duracion de la pelicula
            int[] hora_format = Horario.obtenerHorarioFinal(horario_inicio.Hora,horario_inicio.Minutos,pelicula.Duracion);
            this.horario_final = new Horario(hora_format[0],hora_format[1]);
            this.sala = sala;
            this.created = obtenerFechaActual();
        }

        //Methods para la base de datos

        public void save()
        {
            try
            {
                String consulta = String.Format("INSERT INTO FUNCIONES(PELICULA,HORA_INICIO,HORA_FINAL,SALA,CREATED) VALUES ('{0}','{1}','{2}','{3}','{4}')", pelicula.Name, horario_inicio.getHorario(), horario_final.getHorario(), sala.Name, created);
                query = new MySqlCommand(consulta, Conexion.obtenerConexion());
                query.ExecuteNonQuery();
                MessageBox.Show("Función creada exitosamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Boolean avalible()
        {

            Boolean avalible = true;

            try
            {

                String consulta = String.Format("SELECT * FROM FUNCIONES WHERE SALA='{0}' AND '{1}' BETWEEN HORA_INICIO AND HORA_FINAL",sala.Name,horario_inicio.getHorario());
                query = new MySqlCommand(consulta,Conexion.obtenerConexion());
                statement = query.ExecuteReader();

                if (!statement.HasRows)
                {
                    query = null;
                    statement = null;
                    consulta = "";
                    consulta = String.Format("SELECT * FROM FUNCIONES WHERE SALA='{0}' AND '{1}' BETWEEN HORA_INICIO AND HORA_FINAL", sala.Name, horario_final.getHorario());
                    query = new MySqlCommand(consulta,Conexion.obtenerConexion());
                    statement = query.ExecuteReader();

                    if (statement.HasRows)
                    {
                        avalible = false;
                        MessageBox.Show("2");
                    }

                }
                else
                {
                    avalible = false;
                    MessageBox.Show("1");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return avalible;
        }


        //-----------------------------------------
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
        public Pelicula Pelicula
        {
            set { pelicula = value; }
            get { return pelicula; }
        }
        public Horario Horario_inicio
        {
            set { horario_inicio = value; }
            get { return horario_inicio; }
        }
        public Horario Horario_final
        {
            set { horario_final = value; }
            get { return horario_final; }
        }
        public Sala Sala
        {
            set { sala = value; }
            get { return sala; }
        }
        public String Created
        {
            set { created = value; }
            get { return created; }
        }
    }
}
