using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Models;

namespace Views
{
    public partial class InfoPelicula : Form
    {

        private Pelicula pelicula;

        public InfoPelicula(Pelicula pelicula)
        {
            this.pelicula = pelicula;
            InitializeComponent();
            myInitComponents();
        }

        public void myInitComponents()
        {
            lblNombrePelicula.Text = capitalize(pelicula.Name);
            lblDescripcionPelicula.Text = capitalize(pelicula.Descripcion)+".";
            lblFechaPelicula.Text = pelicula.Created.Substring(0,pelicula.Created.IndexOf(" "));
            lblDuracion.Text = pelicula.getFormatDuracion();
            imagePelicula.Image = Image.FromFile(pelicula.Image);
        }

        public String capitalize(String value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


            //Mover la ventana cuando eliminador el formStyle predeterminado
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InfoPelicula_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
