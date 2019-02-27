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
    public partial class FormDiesSemana : Form
    {
        public static Boolean verdadero;
        public FormDiesSemana()
        {
            InitializeComponent();
        }

        private void FormDiesSemana_Load(object sender, EventArgs e)
        {
            bindingSourceDiesSemana.DataSource = DiesSemanaORM.SelectAllDiesSemana();
        }

        private void FormDiesSemana_Activated(object sender, EventArgs e)
        {
            bindingSourceDiesSemana.DataSource = DiesSemanaORM.SelectAllDiesSemana();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            if(dataGridViewDiesSemana.RowCount == 7)
            {
                MessageBox.Show("Ja hi han introduïts els 7 dies de la semana", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ObridorFormulari.obrirFormDiaSemana();
            }
            
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borrar el dia?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = DiesSemanaORM.DeleteByDia((DIA_SEMANA)dataGridViewDiesSemana.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewDiesSemana_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceDiesSemana.DataSource = DiesSemanaORM.SelectAllDiesSemana();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDiaSemana((DIA_SEMANA)dataGridViewDiesSemana.SelectedRows[0].DataBoundItem);
        }

        private void dataGridViewDiesSemana_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDiaSemana((DIA_SEMANA)dataGridViewDiesSemana.SelectedRows[0].DataBoundItem);
        }
    }
}
