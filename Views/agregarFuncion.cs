using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Models;

namespace Views
{
    public partial class agregarFuncion : Form
    {

        private Boolean changePeliculas;
        private Boolean changeSalas;
        private InfoPelicula infoPeli;

        public agregarFuncion()
        {
            InitializeComponent();
            myInitComponents();
        }

        public void myInitComponents()
        {
            infoPeli = null;
            changePeliculas = false;
            changeSalas = false;
            refreshPeliculas();
            refreshSalas();
           
        }

        private void refreshPeliculas()
        {
            ArrayList peliculas = new ArrayList( Pelicula.all() );

            foreach (Pelicula pelicula in peliculas)
            {
                cbPeliculasBD.Items.Add(capitalize(pelicula.Name));
            }
        }

        private void refreshSalas()
        {
            ArrayList salas = new ArrayList( Sala.all() );

            foreach (Sala sala in salas)
            {
                cbSalasBD.Items.Add(capitalize(sala.Name));
            }

        }

        private String capitalize(String value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
        }

        private void btnInfoPelicula_Click(object sender, EventArgs e)
        {
                //Cerrar ventana de info posiblemente abierta
            if (infoPeli != null && infoPeli.Visible)
            {
                infoPeli.Visible = false;
            }

                //nueva ventana de info

            if (cbPeliculasBD.Items.Count > 0)
            {
                if (changePeliculas)
                {
                    String name_pelicula = cbPeliculasBD.Text.ToString().ToLower();

                    if (Pelicula.exists(name_pelicula))
                    {
                        Pelicula pelicula = Pelicula.find(name_pelicula); //Pelicula con los atributos de la pelicula seleccionada

                        infoPeli = new InfoPelicula(pelicula);
                        infoPeli.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona una de las peliculas existentes");
                        cbPeliculasBD.Text = "Películas";
                    }

                }
                else
                {
                    MessageBox.Show("Debes seleccionar una película para ver su información");
                }
            }
            else
            {
                MessageBox.Show("No hay peliculas registradas por el momento");
            }
           

        }

        private void cbPeliculasBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePeliculas = true;

                //Cuando cambie de pelicula del comboBox cerrar la ventana info abierta
            if (infoPeli != null && infoPeli.Visible)
                infoPeli.Visible = false;
        }

        private void btnInfoSala_Click(object sender, EventArgs e)
        {

            if (cbSalasBD.Items.Count > 0)
            {

                if (changeSalas)
                {

                    String name_sala = cbSalasBD.Text.ToString().ToLower();

                    if (Sala.exists(name_sala))
                    {
                        Sala sala = Sala.find(name_sala);

                        //Mensaje con los datos de la sala seleccionada
                        String datos_sala = String.Format("Sala {0}\nNombre: {1}\nNúmero de asientos: {2}\nCreada: {3}", sala.Id, capitalize(sala.Name), sala.Num_asientos, sala.Created.Substring(0, sala.Created.IndexOf(" ")));
                        MessageBox.Show(null, datos_sala, "Message");
                    }
                    else
                    {
                        MessageBox.Show("Selecciona una de las salas existentes");
                        cbSalasBD.Text = "Salas";
                    }

                }
                else
                {
                    MessageBox.Show("Debes seleccionar una sala para ver su información");
                }


            }
            else
            {
                MessageBox.Show("No hay salas registradas por el momento");
            }


        }

        private void cbSalasBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSalas = true;
        }

        private void btnAddPelicula_Click(object sender, EventArgs e)
        {

            String name_pelicula = cbPeliculasBD.Text.ToLower();

            if (changePeliculas && Pelicula.exists(name_pelicula))
            {

                String name_sala = cbSalasBD.Text.ToLower();

                if (changeSalas && Sala.exists(name_sala))
                {


                    Horario horario_inicio = new Horario(Convert.ToInt32(spHora.Value), Convert.ToInt32(spMinutos.Value));
                    Pelicula pelicula = Pelicula.find(name_pelicula);
                    Sala sala = Sala.find(name_sala);
                    Funcion funcion = new Funcion(pelicula,horario_inicio,sala);

                    if (funcion.avalible())
                    {
                        funcion.save();
                    }
                    else
                    {
                        MessageBox.Show("La sala estará trasmitiendo una función en el trascuros de este horario, ten en cuenta la duracion de esta película");
                    }


                }
                else
                {
                    MessageBox.Show("Para agregar la función debes seleccionar una sala existente");
                    cbSalasBD.Text = "Salas";
                }


            }
            else
            {
                MessageBox.Show("Para agregar la función debes seleccionar una película existente");
                cbPeliculasBD.Text = "Películas";
            }


        }



    }
}
