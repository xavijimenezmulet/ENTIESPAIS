using EntiEspais.Classes;
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
    public partial class FormEspaisTodos : Form
    {
        public FormEspaisTodos()
        {
            InitializeComponent();
        }


        //Load
        private void FormEspaisTodos_Load(object sender, EventArgs e)
        {
            bindingSourceEspais.DataSource = ORM.EspaisORM.selectEspais();
        }

        //Activated
        private void FormEspaisTodos_Activated(object sender, EventArgs e)
        {
            bindingSourceEspais.DataSource = ORM.EspaisORM.selectEspais();
        }

        //Añadir
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosAlta();
        }

        //Modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
        }

        //Eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ESBORRAT");
                    }

                }
                else
                {
                    MessageBox.Show("ACCIÓ CANCELADA");
                }
            }
        }

        //Modificar al doble click
        private void dataGridViewEspais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
        }

        //Eliminar al supr
        private void dataGridViewEspais_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ESBORRAT");
                    }

                }
                else
                {
                    MessageBox.Show("ACCIÓ CANCELADA");
                    e.Cancel = true;
                }
            }
        }

        #region Buttons

        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquips();
        }

        private void llistatUsuarisToolStripAdministradors_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }

        private void afegirUsuariToolStripAdministrador_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void toolStripButtonUsuaris_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }

        private void toolStripButtonMain_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonEntitats_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
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

        private void toolStripButtonAltres_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormFaqsAndroid();
        }

        private void afegirEquipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerAfegir();
        }

        private void diaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDiesSemana();
        }

        private void horesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormHores();
        }

        private void llistaEntitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
        }

        private void afegirEntitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitat();
        }

        private void llistatActivitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormActivitats();
        }

        private void afegirActivitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDemandes();
        }

        private void toolStripButtonActivitats_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormActivitats();
        }

        private void afegirInstallacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacioAlta();
        }

        private void llistatInstallacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacions();
        }

        private void llistatEspaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEspaisTots();
        }

        private void afegirEspaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.FormEspaisTodosAlta();
        }

        private void llistatInstallacionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacions();
        }

        private void afegirInstallacióToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacioAlta();
        }

        private void llistatEspaisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEspaisTots();
        }

        private void afegirEspaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ObridorFormulari.FormEspaisTodosAlta();
        }

        private void toolStripButtonInstalacions_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacions();
        }

        private void toolStripButtonEspais_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEspaisTots();
        }

        #endregion
    }
}
