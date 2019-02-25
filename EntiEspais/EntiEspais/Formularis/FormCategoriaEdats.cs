using EntiEspais.Classes;
using EntiEspais.ORM;
using System;
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
    public partial class FormCategoriaEdats : Form
    {
        public static Boolean verdadero;

        public FormCategoriaEdats()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEdat();
        }

        private void FormCategoriaEdats_Load(object sender, EventArgs e)
        {
            bindingSourceCategoriaEdats.DataSource = CategoriaPerEdatORM.SelectAllCategoriesPerEdat();
        }

        private void FormCategoriaEdats_Activated(object sender, EventArgs e)
        {
            if( verdadero)
            {
                bindingSourceCategoriaEdats.DataSource = CategoriaPerEdatORM.SelectAllCategoriesPerEdat();
                verdadero = false;
            }
        }
    }
}
