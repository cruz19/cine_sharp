using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (!ruta_imagen.Equals("") && !txtNamePelicula.Text.Equals("") && !txtNamePelicula.Text.Equals("Nombre de la película",StringComparison.OrdinalIgnoreCase) && !txtDescripcionPeli.Text.Equals("") && !txtDescripcionPeli.Text.Equals("Descripción",StringComparison.OrdinalIgnoreCase))
            {
                String name = txtNamePelicula.Text.Trim().ToLower();
                String descripcion = txtDescripcionPeli.Text.Trim();
                
                if (!Pelicula.exists(name))
                {

                    List<String> request = new List<String>();
                    request.Add(name);
                    request.Add(descripcion);
                    request.Add(ruta_imagen);

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
                //Vaciar ruta de la imagen seleccionada
                ruta_imagen = "";
                pictureBox1.Image = null;


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
    }
}
