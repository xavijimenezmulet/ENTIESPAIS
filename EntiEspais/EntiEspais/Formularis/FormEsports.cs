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
    public partial class FormEsports : Form
    {
        public static Boolean verdadero;
        public FormEsports()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEsport();
        }

        private void FormEsports_Load(object sender, EventArgs e)
        {
            bindingSourceEsports.DataSource = EsportsORM.SelectAllEsports();
        }

        private void FormEsports_Activated(object sender, EventArgs e)
        {
            if (verdadero)
            {
                bindingSourceEsports.DataSource = EsportsORM.SelectAllEsports();
                verdadero = false;
            }
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borra l'esport?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = EsportsORM.DeleteByEsport((ESPORTS)dataGridViewEsports.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewEsports_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceEsports.DataSource = EsportsORM.SelectAllEsports();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEsport((ESPORTS)dataGridViewEsports.SelectedRows[0].DataBoundItem);
        }
    }
}
