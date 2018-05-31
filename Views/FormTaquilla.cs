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
    public partial class FormTaquilla : Form
    {
        public FormTaquilla()
        {
            InitializeComponent();
            myInitComponents();
        }

        private void myInitComponents()
        {
            this.Size = new Size(452,535);
            btnEscogerAsiento.Location = new Point(83,444);
            btnEscogerAsiento.Visible = false;
            panelHorarios.Visible = false;
            panelSalas.Visible = false;
            panelPeliculas.Dock = DockStyle.None;
            panelPeliculas.Location = new Point(83,45);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnSelectedPelicula_Click(object sender, EventArgs e)
        {
            panelPeliculas.Visible = false;
            panelHorarios.Dock = DockStyle.None;
            panelHorarios.Location = new Point(83,45);
            panelHorarios.Visible = true;
        }

        private void btnSelectedHorario_Click(object sender, EventArgs e)
        {
            panelHorarios.Visible = false;
            panelSalas.Dock = DockStyle.None;
            panelSalas.Location = new Point(83,45);
            panelSalas.Visible = true;
        }

        private void btnCerarSesionUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Regresa pronto");
            FormLogin formLogin = new FormLogin();
            formLogin.Visible = true;
        }
    }
}
