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

        private void dataGridViewCategoriaEdats_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borrar la categoria?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {

                missatge = CategoriaPerEdatORM.DeleteByCategoriaPerEdat((CATEGORIA_EDAT)dataGridViewCategoriaEdats.SelectedRows[0].DataBoundItem);
                if (!missatge.Equals(""))
                {
                    MessageBox.Show(missatge, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    e.Cancel = true;
                }


            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewCategoriaEdats_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEdat((CATEGORIA_EDAT)dataGridViewCategoriaEdats.SelectedRows[0].DataBoundItem);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEdat((CATEGORIA_EDAT)dataGridViewCategoriaEdats.SelectedRows[0].DataBoundItem);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
