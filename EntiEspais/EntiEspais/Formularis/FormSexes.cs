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

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borra el sexe?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = SexesORM.DeleteBySexe((SEXE)dataGridViewSexes.SelectedRows[0].DataBoundItem);
                if (!missatge.Equals(""))
                {
                    MessageBox.Show(missatge, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }
            }
            else
            {
                correcto = false;
            }

            return correcto;
        }

        private void dataGridViewSexes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Boolean correcto = eliminar();

            if (!correcto)
            {
                e.Cancel = true;
            }
            else
            {
                verdadero = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            verdadero = true;
            bindingSourceSexes.DataSource = SexesORM.SelectAllSexes();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormSexe((SEXE)dataGridViewSexes.SelectedRows[0].DataBoundItem);
        }

        private void dataGridViewSexes_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormSexe((SEXE)dataGridViewSexes.SelectedRows[0].DataBoundItem);
        }
    }
}
