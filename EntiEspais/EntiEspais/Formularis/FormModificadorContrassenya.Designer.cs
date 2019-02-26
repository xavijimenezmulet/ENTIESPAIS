namespace EntiEspais.Formularis
{
    partial class FormModificadorContrassenya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificadorContrassenya));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxRepeticio = new System.Windows.Forms.TextBox();
            this.labelRepeticio = new System.Windows.Forms.Label();
            this.textBoxNova = new System.Windows.Forms.TextBox();
            this.labelNovaContrassenya = new System.Windows.Forms.Label();
            this.textBoxActual = new System.Windows.Forms.TextBox();
            this.labelContrassenyaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Snow;
            this.buttonCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancelar.Location = new System.Drawing.Point(321, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(160, 23);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "Cancel·lar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonAceptar.ForeColor = System.Drawing.Color.Snow;
            this.buttonAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAceptar.Location = new System.Drawing.Point(87, 224);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(160, 23);
            this.buttonAceptar.TabIndex = 31;
            this.buttonAceptar.Text = "Acceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxRepeticio
            // 
            this.textBoxRepeticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxRepeticio.Location = new System.Drawing.Point(179, 142);
            this.textBoxRepeticio.Name = "textBoxRepeticio";
            this.textBoxRepeticio.PasswordChar = '*';
            this.textBoxRepeticio.Size = new System.Drawing.Size(321, 20);
            this.textBoxRepeticio.TabIndex = 28;
            // 
            // labelRepeticio
            // 
            this.labelRepeticio.AutoSize = true;
            this.labelRepeticio.BackColor = System.Drawing.Color.Transparent;
            this.labelRepeticio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelRepeticio.ForeColor = System.Drawing.Color.White;
            this.labelRepeticio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRepeticio.Location = new System.Drawing.Point(37, 147);
            this.labelRepeticio.Name = "labelRepeticio";
            this.labelRepeticio.Size = new System.Drawing.Size(136, 15);
            this.labelRepeticio.TabIndex = 27;
            this.labelRepeticio.Text = "Repetició Contrassenya";
            // 
            // textBoxNova
            // 
            this.textBoxNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNova.Location = new System.Drawing.Point(179, 104);
            this.textBoxNova.Name = "textBoxNova";
            this.textBoxNova.PasswordChar = '*';
            this.textBoxNova.Size = new System.Drawing.Size(321, 20);
            this.textBoxNova.TabIndex = 26;
            // 
            // labelNovaContrassenya
            // 
            this.labelNovaContrassenya.AutoSize = true;
            this.labelNovaContrassenya.BackColor = System.Drawing.Color.Transparent;
            this.labelNovaContrassenya.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNovaContrassenya.ForeColor = System.Drawing.Color.White;
            this.labelNovaContrassenya.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNovaContrassenya.Location = new System.Drawing.Point(37, 109);
            this.labelNovaContrassenya.Name = "labelNovaContrassenya";
            this.labelNovaContrassenya.Size = new System.Drawing.Size(112, 15);
            this.labelNovaContrassenya.TabIndex = 25;
            this.labelNovaContrassenya.Text = "Nova Contrassenya";
            // 
            // textBoxActual
            // 
            this.textBoxActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxActual.Location = new System.Drawing.Point(179, 67);
            this.textBoxActual.Name = "textBoxActual";
            this.textBoxActual.PasswordChar = '*';
            this.textBoxActual.Size = new System.Drawing.Size(321, 20);
            this.textBoxActual.TabIndex = 24;
            // 
            // labelContrassenyaActual
            // 
            this.labelContrassenyaActual.AutoSize = true;
            this.labelContrassenyaActual.BackColor = System.Drawing.Color.Transparent;
            this.labelContrassenyaActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelContrassenyaActual.ForeColor = System.Drawing.Color.White;
            this.labelContrassenyaActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelContrassenyaActual.Location = new System.Drawing.Point(37, 72);
            this.labelContrassenyaActual.Name = "labelContrassenyaActual";
            this.labelContrassenyaActual.Size = new System.Drawing.Size(118, 15);
            this.labelContrassenyaActual.TabIndex = 23;
            this.labelContrassenyaActual.Text = "Contrassenya Actual";
            // 
            // FormModificadorContrassenya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxRepeticio);
            this.Controls.Add(this.labelRepeticio);
            this.Controls.Add(this.textBoxNova);
            this.Controls.Add(this.labelNovaContrassenya);
            this.Controls.Add(this.textBoxActual);
            this.Controls.Add(this.labelContrassenyaActual);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormModificadorContrassenya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxRepeticio;
        private System.Windows.Forms.Label labelRepeticio;
        private System.Windows.Forms.TextBox textBoxNova;
        private System.Windows.Forms.Label labelNovaContrassenya;
        private System.Windows.Forms.TextBox textBoxActual;
        private System.Windows.Forms.Label labelContrassenyaActual;
    }
}