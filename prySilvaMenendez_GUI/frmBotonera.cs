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

        public string[] vecNombres = new string[3];
        int indice = -1;
        int indiceCombo = 0;

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Luca";
            vecNombres[1] = "Josefina";
            vecNombres[2] = "Pablo";
            btnAtras.Enabled = false;
            lstNombres.Items.Clear();
            indiceCombo = 0;
            while (indiceCombo < vecNombres.Length)
            {
               lstNombres.Items.Add(vecNombres[indiceCombo++]);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++; 
            if (indice < vecNombres.Length) 
            {
                lblDatos.Text = vecNombres[indice];
                btnAtras.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (indice == vecNombres.Length - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            if (indice >= 0)
            {
                lblDatos.Text = vecNombres[indice];
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                lblDatos.Text = "Nombres:";
                btnAtras.Enabled = false;
            }
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            lblDatos.Text = vecNombres [0];
            indice = 0;
            btnSiguiente.Enabled = true;
            btnAtras.Enabled = false;
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lblDatos.Text = vecNombres[vecNombres.Length - 1];
            indice = 2;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = false;
        }
    }
}
