using EntiEspais.Classes;
using System;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormEquips : Form
    {
        static bool algo2;
        public FormEquips()
        {
            algo2 = false;
            InitializeComponent();
            algo2 = true;
        }

        //Omple la GridView amb tots els equips que hi hagi a la base de dades.
        private void RefrescarEquips()
        {
            bindingSourceEquips.DataSource = ORM.EquipsORM.SelectAllEquips();

            bindingSourceEquipsEntitat.DataSource = ORM.EntitatsORM.SelectAllEntities();
            bindingSourceEquipsCompeticio.DataSource = ORM.CompeticionsORM.SelectAllCompeticions();
            bindingSourceCategoriaEdatEquips.DataSource = ORM.CategoriaPerEdatORM.SelectAllCategoriesPerEdat();
            bindingSourceCategoriaEquips.DataSource = ORM.CategoriaPerEquipORM.SelectAllCategoriesPerEquip();
            bindingSourceSexeEquips.DataSource = ORM.SexesORM.SelectAllSexes();
            bindingSourceEquipsEsport.DataSource = ORM.EsportsORM.SelectAllEsports();
        }

        //Cada tick del rellotge posa l'hora en una label.
        private void Reloj_Tick_1(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormEquips_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox7.Select();
            RefrescarEquips();

        }

        private void buttonAfegirEquipo_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerAfegir();
        }

        private void FormEquips_Activated(object sender, EventArgs e)
        {
            RefrescarEquips();
        }

        private void buttonModificarEquipo_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerModificar((EQUIPS)dataGridViewEquips.SelectedRows[0].DataBoundItem);
            //identitatDataGridViewTextBoxColumn
        }

        private void buttonEliminarEquipo_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            DialogResult resultado = MessageBox.Show("Segur que vols eliminar aquest equip?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                mensaje = ORM.EquipsORM.DeleteEquip((EQUIPS)dataGridViewEquips.SelectedRows[0].DataBoundItem);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    RefrescarEquips();
                }
            }
            else
            {

            }
        }

        private void dataGridViewEquips_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerModificar((EQUIPS)dataGridViewEquips.CurrentRow.DataBoundItem);
        }

        private void dataGridViewEquips_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String mensaje = "";
            DialogResult resultado = MessageBox.Show("Segur que vols eliminar aquest equip?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                mensaje = ORM.EquipsORM.DeleteEquip((EQUIPS)dataGridViewEquips.SelectedRows[0].DataBoundItem);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormPrincipal();
        }

        private void llistaEntitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
            this.Close();
        }

        private void afegirEntitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitat();
            this.Close();
        }

        private void dataGridViewEquips_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Modificació feta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void algo(object sender, DataGridViewCellEventArgs e)
        {
            //Falta comprobar que el nombre del equipo no sea vacío.

            if (algo2)
            {
                if (dataGridViewEquips.SelectedRows[0].Cells[1].Value == null)
                {
                    if (dataGridViewEquips.SelectedRows[0].Cells[1].Value.ToString().Length == 0)
                    {
                        MessageBox.Show("CAMPOS VACIOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ORM.EquipsORM.UpdateEquip((EQUIPS)dataGridViewEquips.CurrentRow.DataBoundItem); //funciona
                    MessageBox.Show("Equip modificat.", "CANVI", MessageBoxButtons.OK, MessageBoxIcon.Information); //funciona
                }
            }

        }
    }
}
