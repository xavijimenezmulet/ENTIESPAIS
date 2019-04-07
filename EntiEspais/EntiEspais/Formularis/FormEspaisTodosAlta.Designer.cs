namespace EntiEspais.Formularis
{
    partial class FormEspaisTodosAlta
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
            this.comboBoxTipus = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPreu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInstalacio = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalacions = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipus
            // 
            this.comboBoxTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipus.FormattingEnabled = true;
            this.comboBoxTipus.Items.AddRange(new object[] {
            "Interior",
            "Exterior"});
            this.comboBoxTipus.Location = new System.Drawing.Point(107, 133);
            this.comboBoxTipus.Name = "comboBoxTipus";
            this.comboBoxTipus.Size = new System.Drawing.Size(390, 21);
            this.comboBoxTipus.TabIndex = 71;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Snow;
            this.buttonCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancelar.Location = new System.Drawing.Point(337, 173);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(160, 23);
            this.buttonCancelar.TabIndex = 70;
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
            this.buttonAceptar.Location = new System.Drawing.Point(171, 173);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(160, 23);
            this.buttonAceptar.TabIndex = 69;
            this.buttonAceptar.Text = "Acceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 68;
            this.label4.Text = "Tipus";
            // 
            // textBoxPreu
            // 
            this.textBoxPreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPreu.Location = new System.Drawing.Point(107, 93);
            this.textBoxPreu.Name = "textBoxPreu";
            this.textBoxPreu.Size = new System.Drawing.Size(390, 20);
            this.textBoxPreu.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Preu";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNom.Location = new System.Drawing.Point(107, 56);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(390, 20);
            this.textBoxNom.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nom";
            // 
            // comboBoxInstalacio
            // 
            this.comboBoxInstalacio.DataSource = this.bindingSourceInstalacions;
            this.comboBoxInstalacio.DisplayMember = "nom";
            this.comboBoxInstalacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalacio.FormattingEnabled = true;
            this.comboBoxInstalacio.Location = new System.Drawing.Point(107, 12);
            this.comboBoxInstalacio.Name = "comboBoxInstalacio";
            this.comboBoxInstalacio.Size = new System.Drawing.Size(390, 21);
            this.comboBoxInstalacio.TabIndex = 73;
            this.comboBoxInstalacio.ValueMember = "id";
            // 
            // bindingSourceInstalacions
            // 
            this.bindingSourceInstalacions.DataSource = typeof(EntiEspais.INSTALACIONS);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(26, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "INSTALACIÓ";
            // 
            // FormEspaisTodosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.ClientSize = new System.Drawing.Size(533, 220);
            this.Controls.Add(this.comboBoxInstalacio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipus);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPreu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormEspaisTodosAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEspaisTodosAlta";
            this.Load += new System.EventHandler(this.FormEspaisTodosAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipus;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPreu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInstalacio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSourceInstalacions;
    }
}