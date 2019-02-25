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
    public partial class FormAdministradors : Form
    {
        public static Boolean verdadero;

        public FormAdministradors()
        {
            InitializeComponent();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormAdministradors_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox7.Select();
            bindingSourceAdministradors.DataSource = AdministradorsORM.SelectAllAdministradors();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void afegirUsuariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void toolStripButtonSortir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonMain_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormPrincipal();
        }

        private void toolStripButtonUsuaris_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }

        private void toolStripButtonAltres_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqsAndroid();
        }

        private void categoriaEdatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEdats();
        }

        private void categoriaEquipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEquips();
        }

        private void sexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormSexes();
        }

        private void competicionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCompeticions();
        }

        private void telefonsEntitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormTelefonsEntitats();
        }

        private void telefonsInstalacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormTelefonsInstalacions();
        }

        private void fAQsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqsAndroid();
        }

        private void dataGridViewAdministradors_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String missatge = "";
            DialogResult resultat = MessageBox.Show( "Estàs segur de borrar l'usuari?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if ( resultat == DialogResult.Yes )
            {

                missatge = AdministradorsORM.DeleteByAdministrador((ADMINISTRADORS)dataGridViewAdministradors.SelectedRows[0].DataBoundItem );
                if ( !missatge.Equals( "" ) )
                {
                    MessageBox.Show( missatge, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error );
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradorModificar((ADMINISTRADORS)dataGridViewAdministradors.SelectedRows[0].DataBoundItem);
        }

        private void FormAdministradors_Activated(object sender, EventArgs e)
        {
            if ( verdadero )
            {
                bindingSourceAdministradors.DataSource = AdministradorsORM.SelectAllAdministradors();
                verdadero = false;
            }
        }

        private void dataGridViewAdministradors_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradorModificar((ADMINISTRADORS)dataGridViewAdministradors.SelectedRows[0].DataBoundItem);
        }
    }
}
