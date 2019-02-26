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
    public partial class FormCompeticions : Form
    {
        public static Boolean verdadero;
        public FormCompeticions()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCompeticio();
        }

        private void FormCompeticions_Load(object sender, EventArgs e)
        {
            bindingSourceCompeticions.DataSource = CompeticionsORM.SelectAllCompeticions();
        }

        private void FormCompeticions_Activated(object sender, EventArgs e)
        {
            if (verdadero)
            {
                bindingSourceCompeticions.DataSource = CompeticionsORM.SelectAllCompeticions();
                verdadero = false;
            }
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borrar la competició?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = CompeticionsORM.DeleteByCompeticio((COMPETICIONS)dataGridViewCompeticions.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewCompeticions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceCompeticions.DataSource = CompeticionsORM.SelectAllCompeticions();
        }
    }
}
