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
    public partial class FormSexes : Form
    {
        public static Boolean verdadero;
        public FormSexes()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormSexe();
        }

        private void FormSexes_Load(object sender, EventArgs e)
        {
            bindingSourceSexes.DataSource = SexesORM.SelectAllSexes();
        }

        private void FormSexes_Activated(object sender, EventArgs e)
        {
            if (verdadero)
            {
                bindingSourceSexes.DataSource = SexesORM.SelectAllSexes();
                verdadero = false;
            }
        }
    }
}
