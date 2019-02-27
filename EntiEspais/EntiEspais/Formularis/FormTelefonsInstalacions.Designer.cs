namespace EntiEspais.Formularis
{
    partial class FormTelefonsInstalacions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelefonsInstalacions));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.dataGridViewTelefonsInstalacions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinstalacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALACIONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceTelefonsInstalacions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonsInstalacions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefonsInstalacions)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Snow;
            this.buttonEliminar.Location = new System.Drawing.Point(362, 187);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(160, 23);
            this.buttonEliminar.TabIndex = 29;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.Snow;
            this.buttonModificar.Location = new System.Drawing.Point(362, 124);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(160, 23);
            this.buttonModificar.TabIndex = 28;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfegir.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonAfegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfegir.ForeColor = System.Drawing.Color.Snow;
            this.buttonAfegir.Location = new System.Drawing.Point(362, 54);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(160, 23);
            this.buttonAfegir.TabIndex = 27;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // dataGridViewTelefonsInstalacions
            // 
            this.dataGridViewTelefonsInstalacions.AllowUserToAddRows = false;
            this.dataGridViewTelefonsInstalacions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTelefonsInstalacions.AutoGenerateColumns = false;
            this.dataGridViewTelefonsInstalacions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewTelefonsInstalacions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelefonsInstalacions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTelefonsInstalacions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefonsInstalacions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.idinstalacioDataGridViewTextBoxColumn,
            this.iNSTALACIONSDataGridViewTextBoxColumn});
            this.dataGridViewTelefonsInstalacions.DataSource = this.bindingSourceTelefonsInstalacions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTelefonsInstalacions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTelefonsInstalacions.EnableHeadersVisualStyles = false;
            this.dataGridViewTelefonsInstalacions.GridColor = System.Drawing.Color.White;
            this.dataGridViewTelefonsInstalacions.Location = new System.Drawing.Point(9, 29);
            this.dataGridViewTelefonsInstalacions.MultiSelect = false;
            this.dataGridViewTelefonsInstalacions.Name = "dataGridViewTelefonsInstalacions";
            this.dataGridViewTelefonsInstalacions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTelefonsInstalacions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTelefonsInstalacions.RowHeadersVisible = false;
            this.dataGridViewTelefonsInstalacions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelefonsInstalacions.Size = new System.Drawing.Size(333, 214);
            this.dataGridViewTelefonsInstalacions.TabIndex = 26;
            this.dataGridViewTelefonsInstalacions.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewTelefonsInstalacions_UserDeletingRow);
            this.dataGridViewTelefonsInstalacions.DoubleClick += new System.EventHandler(this.dataGridViewTelefonsInstalacions_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idinstalacioDataGridViewTextBoxColumn
            // 
            this.idinstalacioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idinstalacioDataGridViewTextBoxColumn.DataPropertyName = "id_instalacio";
            this.idinstalacioDataGridViewTextBoxColumn.HeaderText = "id_instalacio";
            this.idinstalacioDataGridViewTextBoxColumn.Name = "idinstalacioDataGridViewTextBoxColumn";
            this.idinstalacioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSTALACIONSDataGridViewTextBoxColumn
            // 
            this.iNSTALACIONSDataGridViewTextBoxColumn.DataPropertyName = "INSTALACIONS";
            this.iNSTALACIONSDataGridViewTextBoxColumn.HeaderText = "INSTALACIONS";
            this.iNSTALACIONSDataGridViewTextBoxColumn.Name = "iNSTALACIONSDataGridViewTextBoxColumn";
            this.iNSTALACIONSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSTALACIONSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceTelefonsInstalacions
            // 
            this.bindingSourceTelefonsInstalacions.DataSource = typeof(EntiEspais.TELEFONS_INSTALACIONS);
            // 
            // FormTelefonsInstalacions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.dataGridViewTelefonsInstalacions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTelefonsInstalacions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELÈFONS INSTAL·LACIONS";
            this.Activated += new System.EventHandler(this.FormTelefonsInstalacions_Activated);
            this.Load += new System.EventHandler(this.FormTelefonsInstalacions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonsInstalacions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefonsInstalacions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.DataGridView dataGridViewTelefonsInstalacions;
        private System.Windows.Forms.BindingSource bindingSourceTelefonsInstalacions;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstalacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALACIONSDataGridViewTextBoxColumn;
    }
}