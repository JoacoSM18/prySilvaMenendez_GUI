namespace prySilvaMenendez_GUI
{
    partial class frmControles
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
            this.btnBotonera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotonera
            // 
            this.btnBotonera.Location = new System.Drawing.Point(163, 187);
            this.btnBotonera.Name = "btnBotonera";
            this.btnBotonera.Size = new System.Drawing.Size(142, 58);
            this.btnBotonera.TabIndex = 0;
            this.btnBotonera.Text = "Abrir Botonera";
            this.btnBotonera.UseVisualStyleBackColor = true;
            // 
            // frmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnBotonera);
            this.Name = "frmControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles de Interfaz Grafica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotonera;
    }
}

