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
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }

        

        private void frmControles_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmBotonera ventanaBotonera = new frmBotonera();
            ventanaBotonera.Show();
            ventanaBotonera.vecNombres[0] = "Joaquin";
            ventanaBotonera.Show();
            int indiceVectorNombres = 0;
            while (indiceVectorNombres < ventanaBotonera.vecNombres.Length)
            {
                lstNombresArray.Items.Add(ventanaBotonera.vecNombres[indiceVectorNombres]);
                indiceVectorNombres++;
            }
        }
    }
}
