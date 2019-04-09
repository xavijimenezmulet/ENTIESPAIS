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
    public partial class FormInstalacions : Form
    {
        public FormInstalacions()
        {
            InitializeComponent();
        }

        //Load
        private void FormInstalacions_Load(object sender, EventArgs e)
        {
            dataGridViewInstalacions.ClearSelection();
            refrescarGrid();
        }

        //Activated
        private void FormInstalacions_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        //Botón añadir
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormInstalacioAlta();
        }

        //Botón eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstalacions.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.InstalacionsORM.eliminarInstalacio((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);

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

        //Botón modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstalacions.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                Classes.ObridorFormulari.obrirFormInstalacioModificar((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
            }
        }

        //Buton espais
        //Le pasaremos la instalación para mostrar sus espacios
        private void buttonEspais_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormEspais((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
        }

        //Refrescar DataGrid
        private void refrescarGrid()
        {
            bindingSourceInstalacio.DataSource = ORM.InstalacionsORM.selectInstalacions();
        }

        //Modificar al doble click
        private void dataGridViewInstalacions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInstalacions.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                Classes.ObridorFormulari.obrirFormInstalacioModificar((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
            }
        }

        //Eliminar al supr
        private void dataGridViewInstalacions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewInstalacions.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.InstalacionsORM.eliminarInstalacio((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
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
