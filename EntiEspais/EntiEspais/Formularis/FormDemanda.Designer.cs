namespace EntiEspais.Formularis
{
    partial class FormDemanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemanda));
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelDuracio = new System.Windows.Forms.Label();
            this.textBoxDuracio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHinici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHfi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxEspai = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxDies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInst = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalacions = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxCalDies = new System.Windows.Forms.ListBox();
            this.dataGridViewHorari = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHoras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDias = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            resources.ApplyResources(this.textBoxId, "textBoxId");
            this.textBoxId.Name = "textBoxId";
            // 
            // labelId
            // 
            resources.ApplyResources(this.labelId, "labelId");
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Name = "labelId";
            // 
            // labelTemp
            // 
            resources.ApplyResources(this.labelTemp, "labelTemp");
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Name = "labelTemp";
            // 
            // textBoxNom
            // 
            resources.ApplyResources(this.textBoxNom, "textBoxNom");
            this.textBoxNom.Name = "textBoxNom";
            // 
            // buttonAceptar
            // 
            resources.ApplyResources(this.buttonAceptar, "buttonAceptar");
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAceptar.ForeColor = System.Drawing.Color.Snow;
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            resources.ApplyResources(this.buttonCancelar, "buttonCancelar");
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Snow;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDuracio
            // 
            resources.ApplyResources(this.labelDuracio, "labelDuracio");
            this.labelDuracio.BackColor = System.Drawing.Color.Transparent;
            this.labelDuracio.ForeColor = System.Drawing.Color.White;
            this.labelDuracio.Name = "labelDuracio";
            // 
            // textBoxDuracio
            // 
            resources.ApplyResources(this.textBoxDuracio, "textBoxDuracio");
            this.textBoxDuracio.Name = "textBoxDuracio";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonNo
            // 
            resources.ApplyResources(this.radioButtonNo, "radioButtonNo");
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            resources.ApplyResources(this.radioButtonSi, "radioButtonSi");
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // textBoxEquip
            // 
            resources.ApplyResources(this.textBoxEquip, "textBoxEquip");
            this.textBoxEquip.Name = "textBoxEquip";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // textBoxHinici
            // 
            resources.ApplyResources(this.textBoxHinici, "textBoxHinici");
            this.textBoxHinici.Name = "textBoxHinici";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // textBoxHfi
            // 
            resources.ApplyResources(this.textBoxHfi, "textBoxHfi");
            this.textBoxHfi.Name = "textBoxHfi";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // listBoxEspai
            // 
            this.listBoxEspai.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxEspai, "listBoxEspai");
            this.listBoxEspai.Name = "listBoxEspai";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // listBoxDies
            // 
            resources.ApplyResources(this.listBoxDies, "listBoxDies");
            this.listBoxDies.FormattingEnabled = true;
            this.listBoxDies.Name = "listBoxDies";
            this.listBoxDies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // comboBoxInst
            // 
            this.comboBoxInst.DataSource = this.bindingSourceInstalacions;
            this.comboBoxInst.DisplayMember = "nom";
            this.comboBoxInst.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxInst, "comboBoxInst");
            this.comboBoxInst.Name = "comboBoxInst";
            this.comboBoxInst.SelectedIndexChanged += new System.EventHandler(this.comboBoxInst_SelectedIndexChanged);
            // 
            // bindingSourceInstalacions
            // 
            this.bindingSourceInstalacions.DataSource = typeof(EntiEspais.INSTALACIONS);
            // 
            // listBoxCalDies
            // 
            this.listBoxCalDies.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxCalDies, "listBoxCalDies");
            this.listBoxCalDies.Name = "listBoxCalDies";
            // 
            // dataGridViewHorari
            // 
            this.dataGridViewHorari.AllowUserToDeleteRows = false;
            this.dataGridViewHorari.AutoGenerateColumns = false;
            this.dataGridViewHorari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iniciDataGridViewTextBoxColumn,
            this.fiDataGridViewTextBoxColumn});
            this.dataGridViewHorari.DataSource = this.bindingSourceHoras;
            resources.ApplyResources(this.dataGridViewHorari, "dataGridViewHorari");
            this.dataGridViewHorari.Name = "dataGridViewHorari";
            this.dataGridViewHorari.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iniciDataGridViewTextBoxColumn
            // 
            this.iniciDataGridViewTextBoxColumn.DataPropertyName = "inici";
            resources.ApplyResources(this.iniciDataGridViewTextBoxColumn, "iniciDataGridViewTextBoxColumn");
            this.iniciDataGridViewTextBoxColumn.Name = "iniciDataGridViewTextBoxColumn";
            this.iniciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiDataGridViewTextBoxColumn
            // 
            this.fiDataGridViewTextBoxColumn.DataPropertyName = "fi";
            resources.ApplyResources(this.fiDataGridViewTextBoxColumn, "fiDataGridViewTextBoxColumn");
            this.fiDataGridViewTextBoxColumn.Name = "fiDataGridViewTextBoxColumn";
            this.fiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceHoras
            // 
            this.bindingSourceHoras.DataSource = typeof(EntiEspais.HORES);
            // 
            // bindingSourceDias
            // 
            this.bindingSourceDias.DataSource = typeof(EntiEspais.DIA_SEMANA);
            // 
            // FormDemanda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.Controls.Add(this.dataGridViewHorari);
            this.Controls.Add(this.listBoxCalDies);
            this.Controls.Add(this.comboBoxInst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxEspai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHfi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHinici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEquip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDuracio);
            this.Controls.Add(this.labelDuracio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDemanda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FormDemanda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalacions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelDuracio;
        private System.Windows.Forms.TextBox textBoxDuracio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEquip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHinici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHfi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxEspai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxDies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInst;
        private System.Windows.Forms.BindingSource bindingSourceDias;
        private System.Windows.Forms.ListBox listBoxCalDies;
        private System.Windows.Forms.DataGridView dataGridViewHorari;
        private System.Windows.Forms.BindingSource bindingSourceHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceInstalacions;
    }
}