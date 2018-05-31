using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;

namespace Views
{
    public partial class agregarPelicula : Form
    {

        private String ruta_imagen;

        public agregarPelicula()
        {
            InitializeComponent();
            ruta_imagen = "";
        }

        private void txtNamePelicula_Enter(object sender, EventArgs e)
        {
            if (txtNamePelicula.Text.Equals("Nombre de la película",StringComparison.OrdinalIgnoreCase))
            {
                txtNamePelicula.Text = "";
                txtNamePelicula.ForeColor = Color.LightGray;
            }
        }

        private void txtNamePelicula_Leave(object sender, EventArgs e)
        {
            if (txtNamePelicula.Text.Equals(""))
            {
                txtNamePelicula.Text = "Nombre de la película";
                txtNamePelicula.ForeColor = Color.DimGray;
            }
        }

        private void txtDescripcionPeli_Enter(object sender, EventArgs e)
        {
            if (txtDescripcionPeli.Text.Equals("Descripción", StringComparison.OrdinalIgnoreCase))
            {
                txtDescripcionPeli.Text = "";
                txtDescripcionPeli.ForeColor = Color.LightGray;
            }
        }

        private void txtDescripcionPeli_Leave(object sender, EventArgs e)
        {
            if (txtDescripcionPeli.Text.Equals(""))
            {
                txtDescripcionPeli.Text = "Descripción";
                txtDescripcionPeli.ForeColor = Color.DimGray;
            }
        }

        private void btnAddPelicula_Click(object sender, EventArgs e)
        {
            if (!ruta_imagen.Equals("") && !txtNamePelicula.Text.Equals("") && !txtNamePelicula.Text.Equals("Nombre de la película",StringComparison.OrdinalIgnoreCase) && !txtDescripcionPeli.Text.Equals("") && !txtDescripcionPeli.Text.Equals("Descripción",StringComparison.OrdinalIgnoreCase) && !txtDuracion.Text.Equals("") && !txtDuracion.Text.Equals("Duración de la película",StringComparison.OrdinalIgnoreCase))
            {
                String name = txtNamePelicula.Text.Trim().ToLower();
                String descripcion = txtDescripcionPeli.Text.Trim();
                int duracion = Convert.ToInt32(txtDuracion.Text);

                if (duracion <= 150 && duracion >= 60)
                {
                    if (!Pelicula.exists(name))
                    {

                        List<String> request = new List<String>();
                        request.Add(name);
                        request.Add(descripcion);
                        request.Add(ruta_imagen);
                        request.Add(duracion.ToString());

                        //Crear y guardar nueva pelicula
                        Pelicula pelicula = new Pelicula(request);
                        pelicula.save();

                    }
                    else
                    {
                        MessageBox.Show("La pelicula ya existe en la base de datos");
                    }

                    //Limpiar los TextBox y variable de la rutaImage
                    txtNamePelicula.Text = "Nombre de la película";
                    txtNamePelicula.ForeColor = Color.DimGray;
                    txtDescripcionPeli.Text = "Descripción";
                    txtDescripcionPeli.ForeColor = Color.DimGray;
                    txtDuracion.Text = "Duración de la película";
                    txtDuracion.ForeColor = Color.DimGray;
                    //Vaciar ruta de la imagen seleccionada
                    ruta_imagen = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("La duración de la película es demasiado larga o demasiado corta (Rango=> 60 minutos Limite 150 minutos)");
                    txtDuracion.Text = "";
                }


            }
            else
            {
                MessageBox.Show(null,"Debes completar todos los campos","Message");
            }
        }

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Si selecciono alguna imagen
            {
                ruta_imagen = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ruta_imagen);
                ruta_imagen = ruta_imagen.Replace(@"\","/");
            }
            else
            {
                MessageBox.Show("No seleccionasta ninguna imagen");
            }
        }

        private void txtDuracion_Enter(object sender, EventArgs e)
        {
            if (txtDuracion.Text.Equals("Duración de la película",StringComparison.OrdinalIgnoreCase))
            {
                txtDuracion.Text = "";
                txtDuracion.ForeColor = Color.LightGray;
            }
        }

        private void txtDuracion_Leave(object sender, EventArgs e)
        {
            if (txtDuracion.Text.Equals(""))
            {
                txtDuracion.Text = "Duración de la película";
                txtDuracion.ForeColor = Color.DimGray;
            }
        }

        private void txtDuracion_KeyUp(object sender, KeyEventArgs e)
        {
            String val_pulsado = e.KeyCode.ToString();

            Regex regex = new Regex("[0-9]");
            Match match = regex.Match(val_pulsado);

            if (!match.Success && e.KeyCode!=Keys.Back)
            {
                MessageBox.Show("La duración es un valor númerico");
                txtDuracion.Text = "";
            }
        }


        /*
        private void txtDuracion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            String val_pulsado = e.KeyCode.ToString();
           
            Regex regex = new Regex("[0-9]");
            Match match = regex.Match(val_pulsado);

            if (!match.Success)
            {
                MessageBox.Show("La duración es un valor númerico");
            }

        }
         */





    }
}
