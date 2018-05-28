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
    public partial class agregarSala : Form
    {
        public agregarSala()
        {
            InitializeComponent();
        }

        private void txtNameSala_Enter(object sender, EventArgs e)
        {
            if (txtNameSala.Text.Equals("Nombre de la sala", StringComparison.OrdinalIgnoreCase))
            {
                txtNameSala.Text = "";
                txtNameSala.ForeColor = Color.LightGray;
            }
        }

        private void txtNameSala_Leave(object sender, EventArgs e)
        {
            if (txtNameSala.Text.Equals(""))
            {
                txtNameSala.Text = "Nombre de la sala";
                txtNameSala.ForeColor = Color.DimGray;
            }
        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            if (!txtNameSala.Text.Equals("") && !txtNameSala.Text.Equals("Nombre de la sala", StringComparison.OrdinalIgnoreCase))
            {

                if (spAsientos.Value > 9)
                {

                    String name = txtNameSala.Text.Trim().ToLower();

                    if (!Sala.exists(name))
                    {

                        int num_asientos = Convert.ToInt32(spAsientos.Value);

                        List<String> request = new List<string>();
                        request.Add(name);
                        request.Add(num_asientos.ToString());

                        //Crear y guardar sala
                        Sala sala = new Sala(request);
                        sala.save();
                    }
                    else
                    {
                        MessageBox.Show("La sala ya existe en la base de datos");
                    }

                    txtNameSala.Text = "Nombre de la sala";
                    txtNameSala.ForeColor = Color.DimGray;
                    spAsientos.Value = 10;


                }
                else
                {
                    MessageBox.Show("La sala debe contener minimo 10 asientos");
                }


            }
            else
            {
                MessageBox.Show(null,"Debes completar todos los campos","Message");
            }
        }
    }
}
