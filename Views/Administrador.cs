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

namespace Views
{
    public partial class Administrador : Form
    {

        private Boolean togglePeliculas;
        private Boolean toggleSalas;
        private Boolean toggleFunciones;

        public Administrador()
        {
            InitializeComponent();
            myInitComponents();
        }

        public void myInitComponents(){
            togglePeliculas = true;
            toggleSalas = true;
            toggleFunciones = true;

        }

        public void changeForm(Object form)
        {

            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }

            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(newForm);
            this.panelContenedor.Tag = newForm;

            newForm.Show();
            
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            panelPeliculas.Visible = togglePeliculas;
            togglePeliculas = !togglePeliculas;
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            panelSalas.Visible = toggleSalas;
            toggleSalas = !toggleSalas;
        }

        private void btnVerPeliculas_Click(object sender, EventArgs e)
        {
            //changeForm();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            panelFunciones.Visible = toggleFunciones;
            toggleFunciones = !toggleFunciones;
        }

        private void btnAddPeliculas_Click(object sender, EventArgs e)
        {
            changeForm(new agregarPelicula());
        }

        private void btnAddSalas_Click(object sender, EventArgs e)
        {
            changeForm( new agregarSala() );
        }

        private void btnAddFunciones_Click(object sender, EventArgs e)
        {
            changeForm(new agregarFuncion());
        }

        private void btnCerarSesionAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Hasta luego, Admin");
            FormLogin formLogin = new FormLogin();
            formLogin.Visible = true;
        }
    }
}
