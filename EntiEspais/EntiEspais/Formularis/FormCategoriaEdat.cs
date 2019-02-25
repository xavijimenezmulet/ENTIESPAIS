﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormCategoriaEdat : Form
    {
        public FormCategoriaEdat()
        {
            this.Text = "NOVA CATEGORIA EDAT";
            FormCategoriaEdats.verdadero = true;
            InitializeComponent();
        }

        public FormCategoriaEdat(CATEGORIA_EDAT categoria)
        {
            this.Text = "MODIFICAR CATEGORIA EDAT";
            FormCategoriaEdats.verdadero = true;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
