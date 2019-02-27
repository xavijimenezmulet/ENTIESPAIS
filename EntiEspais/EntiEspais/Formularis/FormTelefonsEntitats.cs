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
    public partial class FormTelefonsEntitats : Form
    {
        public static Boolean verdadero;
        public FormTelefonsEntitats()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormTelefonEntitat();
        }

        private void FormTelefonsEntitats_Load(object sender, EventArgs e)
        {
            bindingSourceTelefonsEntitats.DataSource = TelefonsEntitatsORM.SelectAllTelefons();
        }

        private void FormTelefonsEntitats_Activated(object sender, EventArgs e)
        {
            bindingSourceTelefonsEntitats.DataSource = TelefonsEntitatsORM.SelectAllTelefons();
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borrar el telèfon?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = TelefonsEntitatsORM.DeleteByTelefon((TELEFONS_ENTITATS)dataGridViewTelefonEntitats.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewTelefonEntitats_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceTelefonsEntitats.DataSource = TelefonsEntitatsORM.SelectAllTelefons();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormTelefonEntitat((TELEFONS_ENTITATS)dataGridViewTelefonEntitats.SelectedRows[0].DataBoundItem);
        }

        private void dataGridViewTelefonEntitats_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormTelefonEntitat((TELEFONS_ENTITATS)dataGridViewTelefonEntitats.SelectedRows[0].DataBoundItem);
        }
    }
}
