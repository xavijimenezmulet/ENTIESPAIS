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
    public partial class FormFaqsAndroid : Form
    {
        public static Boolean verdadero;
        public FormFaqsAndroid()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqAndroid();
        }

        private void FormFaqsAndroid_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            bindingSourceFaqsAndroid.DataSource = FaqsAndroidORM.SelectAllFaqs();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormFaqsAndroid_Activated(object sender, EventArgs e)
        {
            bindingSourceFaqsAndroid.DataSource = FaqsAndroidORM.SelectAllFaqs();
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borra el FAQ?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = FaqsAndroidORM.DeleteByFaq((FAQS)dataGridViewFaqsAndroid.SelectedRows[0].DataBoundItem);
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

        private void dataGridViewFaqsAndroid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
            bindingSourceFaqsAndroid.DataSource = FaqsAndroidORM.SelectAllFaqs();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqAndroid((FAQS)dataGridViewFaqsAndroid.SelectedRows[0].DataBoundItem);
        }

        private void dataGridViewFaqsAndroid_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqAndroid((FAQS)dataGridViewFaqsAndroid.SelectedRows[0].DataBoundItem);
        }

        private void iniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llistaEntitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
            this.Close();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquips();
            this.Close();
        }

        private void llistatInstallacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacions();
            this.Close();
        }

        private void llistatEspaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEspais();
            this.Close();
        }

        private void llistatActivitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormActivitats();
            this.Close();
        }

        private void llistatUsuarisToolStripAdministradors_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
            this.Close();
        }

        private void toolStripButtonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonEntitats_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
            this.Close();
        }
    }
}
