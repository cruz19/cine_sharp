using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //Add sala
            }
            else
            {
                MessageBox.Show(null,"Debes completar todos los campos","Message");
            }
        }
    }
}
