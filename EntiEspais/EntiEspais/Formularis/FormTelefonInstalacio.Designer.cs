namespace EntiEspais.Formularis
{
    partial class FormTelefonInstalacio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelefonInstalacio));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInstalacio = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalacio = new System.Windows.Forms.BindingSource(this.components);
            this.labelInstalacio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacio)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Snow;
            this.buttonCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancelar.Location = new System.Drawing.Point(150, 76);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(93, 23);
            this.buttonCancelar.TabIndex = 33;
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
            this.buttonAceptar.Location = new System.Drawing.Point(38, 76);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(93, 23);
            this.buttonAceptar.TabIndex = 32;
            this.buttonAceptar.Text = "Acceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNom.Location = new System.Drawing.Point(87, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(185, 20);
            this.textBoxNom.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tel.";
            // 
            // comboBoxInstalacio
            // 
            this.comboBoxInstalacio.DataSource = this.bindingSourceInstalacio;
            this.comboBoxInstalacio.DisplayMember = "nom";
            this.comboBoxInstalacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalacio.FormattingEnabled = true;
            this.comboBoxInstalacio.Location = new System.Drawing.Point(87, 23);
            this.comboBoxInstalacio.Name = "comboBoxInstalacio";
            this.comboBoxInstalacio.Size = new System.Drawing.Size(185, 21);
            this.comboBoxInstalacio.TabIndex = 35;
            this.comboBoxInstalacio.ValueMember = "id";
            // 
            // bindingSourceInstalacio
            // 
            this.bindingSourceInstalacio.DataSource = typeof(EntiEspais.INSTALACIONS);
            // 
            // labelInstalacio
            // 
            this.labelInstalacio.AutoSize = true;
            this.labelInstalacio.BackColor = System.Drawing.Color.Transparent;
            this.labelInstalacio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelInstalacio.ForeColor = System.Drawing.Color.White;
            this.labelInstalacio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInstalacio.Location = new System.Drawing.Point(16, 30);
            this.labelInstalacio.Name = "labelInstalacio";
            this.labelInstalacio.Size = new System.Drawing.Size(65, 15);
            this.labelInstalacio.TabIndex = 34;
            this.labelInstalacio.Text = "Instal·lació";
            // 
            // FormTelefonInstalacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.comboBoxInstalacio);
            this.Controls.Add(this.labelInstalacio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTelefonInstalacio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTelefonInstalacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInstalacio;
        private System.Windows.Forms.BindingSource bindingSourceInstalacio;
        private System.Windows.Forms.Label labelInstalacio;
    }
}