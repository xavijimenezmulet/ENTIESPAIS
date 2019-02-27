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
            if (verdadero)
            {
                bindingSourceFaqsAndroid.DataSource = FaqsAndroidORM.SelectAllFaqs();
                verdadero = false;
            }
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
    }
}
