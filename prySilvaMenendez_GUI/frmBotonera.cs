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
        int indice = -1; 

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Luca";
            vecNombres[1] = "Josefina";
            vecNombres[2] = "Pablo";
            btnAtras.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++; 

            if (indice < vecNombres.Length) 
            {
                lblDatos.Text = vecNombres[indice];
                btnAtras.Enabled = true; 
            }

            if (indice == vecNombres.Length - 1)
            {
                btnSiguiente.Enabled = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;

            if (indice >= 0)
            {
                lblDatos.Text = vecNombres[indice];
                btnSiguiente.Enabled = true;
            }
            else
            {
                // Volviste al "estado inicial"
                lblDatos.Text = "Nombres:";
                btnAtras.Enabled = false;
            }
        }
    }
}
