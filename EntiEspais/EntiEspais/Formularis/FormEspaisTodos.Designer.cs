namespace EntiEspais.Formularis
{
    partial class FormEspaisTodos
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridViewEspais = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esexteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idinstalacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEspais = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Snow;
            this.buttonEliminar.Location = new System.Drawing.Point(597, 175);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(160, 23);
            this.buttonEliminar.TabIndex = 41;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.Snow;
            this.buttonModificar.Location = new System.Drawing.Point(597, 112);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(160, 23);
            this.buttonModificar.TabIndex = 40;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewEspais
            // 
            this.dataGridViewEspais.AllowUserToAddRows = false;
            this.dataGridViewEspais.AllowUserToDeleteRows = false;
            this.dataGridViewEspais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEspais.AutoGenerateColumns = false;
            this.dataGridViewEspais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewEspais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEspais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEspais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.preuDataGridViewTextBoxColumn,
            this.esexteriorDataGridViewCheckBoxColumn,
            this.idinstalacioDataGridViewTextBoxColumn});
            this.dataGridViewEspais.DataSource = this.bindingSourceEspais;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEspais.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEspais.EnableHeadersVisualStyles = false;
            this.dataGridViewEspais.GridColor = System.Drawing.Color.White;
            this.dataGridViewEspais.Location = new System.Drawing.Point(48, 34);
            this.dataGridViewEspais.MultiSelect = false;
            this.dataGridViewEspais.Name = "dataGridViewEspais";
            this.dataGridViewEspais.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEspais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEspais.RowHeadersVisible = false;
            this.dataGridViewEspais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEspais.Size = new System.Drawing.Size(507, 244);
            this.dataGridViewEspais.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preuDataGridViewTextBoxColumn
            // 
            this.preuDataGridViewTextBoxColumn.DataPropertyName = "preu";
            this.preuDataGridViewTextBoxColumn.HeaderText = "preu";
            this.preuDataGridViewTextBoxColumn.Name = "preuDataGridViewTextBoxColumn";
            this.preuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // esexteriorDataGridViewCheckBoxColumn
            // 
            this.esexteriorDataGridViewCheckBoxColumn.DataPropertyName = "es_exterior";
            this.esexteriorDataGridViewCheckBoxColumn.HeaderText = "es_exterior";
            this.esexteriorDataGridViewCheckBoxColumn.Name = "esexteriorDataGridViewCheckBoxColumn";
            this.esexteriorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idinstalacioDataGridViewTextBoxColumn
            // 
            this.idinstalacioDataGridViewTextBoxColumn.DataPropertyName = "id_instalacio";
            this.idinstalacioDataGridViewTextBoxColumn.HeaderText = "id_instalacio";
            this.idinstalacioDataGridViewTextBoxColumn.Name = "idinstalacioDataGridViewTextBoxColumn";
            this.idinstalacioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceEspais
            // 
            this.bindingSourceEspais.DataSource = typeof(EntiEspais.ESPAIS);
            // 
            // FormEspaisTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 388);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewEspais);
            this.DoubleBuffered = true;
            this.Name = "FormEspaisTodos";
            this.Text = "ESPAIS";
            this.Load += new System.EventHandler(this.FormEspaisTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewEspais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esexteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstalacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceEspais;
    }
}