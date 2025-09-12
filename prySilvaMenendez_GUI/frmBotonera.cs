using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_GUI
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            
        }

        string[] vecNombres = new string[3];
        int indice = 0; 

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Luca";
            vecNombres[1] = "Josefina";
            vecNombres[2] = "Pablo";


            lblDatos.Text = vecNombres[0];

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (vecNombres.Length > indice)
            {
                lblDatos.Text = vecNombres[indice];
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (vecNombres.Length > 0)
            {
                indice--;
                lblDatos.Text = vecNombres[indice];
            }
            else
            {
                btnAtras.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
