using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Collections;
using Controllers;
using Models;

namespace Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            /*                                         Solo estamos usando el login pero esta seria la manera de crear usuarios
            List<String> request = new List<String>();
            request.Add("Miguel");
            request.Add("gantz19");
            request.Add("01010");

            UserController.create(request);
             */
             

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO") //Simulate el placeholder
            {
                txtUser.Text = ""; 
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") //Simulate el placeholder
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUser.Text.Equals("") && !txtUser.Text.Equals("USUARIO"))
            {

                if (!txtPass.Text.Equals("") && !txtPass.Text.Equals("CONTRASEÑA"))
                {
                    String nickname = txtUser.Text.Trim();
                    String password = txtPass.Text.Trim();

                    //Obtenemos el usuario con todos sus atributos
                    User usuario = UserController.login(nickname, password);

                    if (usuario != null) //Si NO esta vacio (si existe)
                    {

                        if (usuario.Nickname.Equals("admin19") && usuario.Password.Equals("00000"))
                        {
                            this.Visible = false;
                            Administrador admin = new Administrador();
                            MessageBox.Show(null,"Bienvenido administrador: "+usuario.Name,"Message");
                            admin.Visible = true;
                        }
                        else
                        {
                            
                            MessageBox.Show("Hola usuario "+usuario.Name);

                            //return vista de usuarios o sea la taquilla


                        }

                    }
                    else
                    {
                        MessageBox.Show(null,"Las credenciales ingresadas NO existen en la base de datos","Message");
                        txtPass.Text = "CONTRASEÑA";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Text = "USUARIO";
                    }

                }
                else
                {
                    MessageBox.Show("Ingresa tu contraseeña");
                }



            }
            else
            {
                MessageBox.Show("Ingresa tu nickname");
            }
        }


    }
}
