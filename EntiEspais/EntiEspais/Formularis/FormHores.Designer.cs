﻿namespace EntiEspais.Formularis
{
    partial class FormHores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHores));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.dataGridViewHores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEMANDAACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORARIACTIVITATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORARIINSTALACIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHores = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHores)).BeginInit();
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
            // dataGridViewHores
            // 
            this.dataGridViewHores.AllowUserToAddRows = false;
            this.dataGridViewHores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHores.AutoGenerateColumns = false;
            this.dataGridViewHores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewHores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iniciDataGridViewTextBoxColumn,
            this.fiDataGridViewTextBoxColumn,
            this.dEMANDAACTDataGridViewTextBoxColumn,
            this.hORARIACTIVITATDataGridViewTextBoxColumn,
            this.hORARIINSTALACIODataGridViewTextBoxColumn});
            this.dataGridViewHores.DataSource = this.bindingSourceHores;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHores.EnableHeadersVisualStyles = false;
            this.dataGridViewHores.GridColor = System.Drawing.Color.White;
            this.dataGridViewHores.Location = new System.Drawing.Point(9, 29);
            this.dataGridViewHores.MultiSelect = false;
            this.dataGridViewHores.Name = "dataGridViewHores";
            this.dataGridViewHores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHores.RowHeadersVisible = false;
            this.dataGridViewHores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHores.Size = new System.Drawing.Size(333, 214);
            this.dataGridViewHores.TabIndex = 26;
            this.dataGridViewHores.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHores_UserDeletingRow);
            this.dataGridViewHores.DoubleClick += new System.EventHandler(this.dataGridViewHores_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iniciDataGridViewTextBoxColumn
            // 
            this.iniciDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iniciDataGridViewTextBoxColumn.DataPropertyName = "inici";
            this.iniciDataGridViewTextBoxColumn.HeaderText = "inici";
            this.iniciDataGridViewTextBoxColumn.Name = "iniciDataGridViewTextBoxColumn";
            this.iniciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiDataGridViewTextBoxColumn
            // 
            this.fiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fiDataGridViewTextBoxColumn.DataPropertyName = "fi";
            this.fiDataGridViewTextBoxColumn.HeaderText = "fi";
            this.fiDataGridViewTextBoxColumn.Name = "fiDataGridViewTextBoxColumn";
            this.fiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEMANDAACTDataGridViewTextBoxColumn
            // 
            this.dEMANDAACTDataGridViewTextBoxColumn.DataPropertyName = "DEMANDA_ACT";
            this.dEMANDAACTDataGridViewTextBoxColumn.HeaderText = "DEMANDA_ACT";
            this.dEMANDAACTDataGridViewTextBoxColumn.Name = "dEMANDAACTDataGridViewTextBoxColumn";
            this.dEMANDAACTDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEMANDAACTDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORARIACTIVITATDataGridViewTextBoxColumn
            // 
            this.hORARIACTIVITATDataGridViewTextBoxColumn.DataPropertyName = "HORARI_ACTIVITAT";
            this.hORARIACTIVITATDataGridViewTextBoxColumn.HeaderText = "HORARI_ACTIVITAT";
            this.hORARIACTIVITATDataGridViewTextBoxColumn.Name = "hORARIACTIVITATDataGridViewTextBoxColumn";
            this.hORARIACTIVITATDataGridViewTextBoxColumn.ReadOnly = true;
            this.hORARIACTIVITATDataGridViewTextBoxColumn.Visible = false;
            // 
            // hORARIINSTALACIODataGridViewTextBoxColumn
            // 
            this.hORARIINSTALACIODataGridViewTextBoxColumn.DataPropertyName = "HORARI_INSTALACIO";
            this.hORARIINSTALACIODataGridViewTextBoxColumn.HeaderText = "HORARI_INSTALACIO";
            this.hORARIINSTALACIODataGridViewTextBoxColumn.Name = "hORARIINSTALACIODataGridViewTextBoxColumn";
            this.hORARIINSTALACIODataGridViewTextBoxColumn.ReadOnly = true;
            this.hORARIINSTALACIODataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceHores
            // 
            this.bindingSourceHores.DataSource = typeof(EntiEspais.HORES);
            // 
            // FormHores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntiEspais.Properties.Resources.fondoescritorioopa_copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.dataGridViewHores);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERVAL D\'HORES";
            this.Activated += new System.EventHandler(this.FormHores_Activated);
            this.Load += new System.EventHandler(this.FormHores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.DataGridView dataGridViewHores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEMANDAACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORARIACTIVITATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORARIINSTALACIODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceHores;
    }
}