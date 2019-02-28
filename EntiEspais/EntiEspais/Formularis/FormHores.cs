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
    public partial class FormHores : Form
    {
        public static Boolean verdadero;
        public FormHores()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormHora();
        }

        private void FormHores_Load(object sender, EventArgs e)
        {
            bindingSourceHores.DataSource = HoresORM.SelectAllHores();
        }

        private void FormHores_Activated(object sender, EventArgs e)
        {
            bindingSourceHores.DataSource = HoresORM.SelectAllHores();
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borra el interval?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = HoresORM.DeleteByHora((HORES)dataGridViewHores.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewHores_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceHores.DataSource = HoresORM.SelectAllHores();
        }

        private void dataGridViewHores_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormHora((HORES)dataGridViewHores.SelectedRows[0].DataBoundItem);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormHora((HORES)dataGridViewHores.SelectedRows[0].DataBoundItem);
        }
    }
}
