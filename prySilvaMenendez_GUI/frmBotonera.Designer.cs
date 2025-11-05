namespace prySilvaMenendez_GUI
{
    partial class frmBotonera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotonera));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lstNombres = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lblTuBotonera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Linen;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(368, 218);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(160, 54);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente ->";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatos.Location = new System.Drawing.Point(200, 108);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(352, 51);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Nombres:";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstNombres
            // 
            this.lstNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Items.AddRange(new object[] {
            "Luca",
            "Josefina",
            "Pablo"});
            this.lstNombres.Location = new System.Drawing.Point(278, 358);
            this.lstNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(200, 28);
            this.lstNombres.TabIndex = 3;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Linen;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(214, 218);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(144, 54);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "<- Anterior";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Linen;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(594, 218);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(136, 54);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.Text = "Último -->";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.Linen;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(4, 218);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(150, 58);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "<-- Primero";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // lblTuBotonera
            // 
            this.lblTuBotonera.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTuBotonera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuBotonera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTuBotonera.Location = new System.Drawing.Point(237, 14);
            this.lblTuBotonera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuBotonera.Name = "lblTuBotonera";
            this.lblTuBotonera.Size = new System.Drawing.Size(268, 51);
            this.lblTuBotonera.TabIndex = 6;
            this.lblTuBotonera.Text = "Tu Botonera";
            this.lblTuBotonera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBotonera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(735, 472);
            this.Controls.Add(this.lblTuBotonera);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBotonera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles de Interfaz Grafica";
            this.Load += new System.EventHandler(this.frmBotonera_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.ComboBox lstNombres;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblTuBotonera;
    }
}

