namespace PIA
{
    partial class Pia_Ventana1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pia_Ventana1));
            this.txtBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBienvenido
            // 
            resources.ApplyResources(this.txtBienvenido, "txtBienvenido");
            this.txtBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.txtBienvenido.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtBienvenido.Name = "txtBienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PIA.Properties.Resources.logoBolegrama;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.LightCyan;
            this.btnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesion.DialogResult = System.Windows.Forms.DialogResult.Yes;
            resources.ApplyResources(this.btnSesion, "btnSesion");
            this.btnSesion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            resources.ApplyResources(this.btnRegistrar, "btnRegistrar");
            this.btnRegistrar.ForeColor = System.Drawing.Color.Violet;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Name = "txtNombre";
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtContra, "txtContra");
            this.txtContra.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContra.Name = "txtContra";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreo.Name = "txtCorreo";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtCelular, "txtCelular");
            this.txtCelular.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCelular.Name = "txtCelular";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmpresa, "txtEmpresa");
            this.txtEmpresa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpresa.Name = "txtEmpresa";
            // 
            // txtRFC
            // 
            this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRFC, "txtRFC");
            this.txtRFC.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRFC.Name = "txtRFC";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEdad, "txtEdad");
            this.txtEdad.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEdad.Name = "txtEdad";
            // 
            // Pia_Ventana1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIA.Properties.Resources.fondo1;
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBienvenido);
            this.Name = "Pia_Ventana1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtEdad;
    }
}

