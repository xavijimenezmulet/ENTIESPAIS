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
    public partial class FormActivitats : Form
    {
        public string auxTemp = "";
        public FormActivitats()
        {
            InitializeComponent();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormActivitats_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox7.Select();
            //omplirComboTemp();
            bindingSourceActivitats.DataSource = ActivitatsORM.SelectAllActivitats();
            
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


        private void iniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquips();
            this.Close();
        }

        private void afegirEquipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquipPerAfegir();
        }

        private void afegirEntitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitat();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonEquips_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEquips();
            this.Close();
        }

        private void llistaEntitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitats();
            this.Close();
        }
        
        //METODE ELIMINAR ACTIVITAT
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            DialogResult res = MessageBox.Show("¿Segur que vols eliminar?", "ATENCIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                mensaje = ActivitatsORM.DeleteActivitat((ACTIVITATS)dataGridViewActivitats.SelectedRows[0].DataBoundItem);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //e.Cancel = true;
                }
            }
           /* else
            {
                e.Cancel = true;
            }*/

        }

        private void FormActivitats_Activated(object sender, EventArgs e)
        {
            bindingSourceActivitats.DataSource = ActivitatsORM.SelectAllActivitats();
        }
        private void afegirActivitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDemandes();
            this.Close();
        }

        //METODE VEURE ACTIVITAT
  
        private void buttonVeure_Click(object sender, EventArgs e)
        {
            ACTIVITATS activitat = (ACTIVITATS)dataGridViewActivitats.SelectedRows[0].DataBoundItem;
            ObridorFormulari.obrirFormActivitat(activitat);
        }

        private void dataGridViewActivitats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int fila;
            int idAct;
            ACTIVITATS a;
            DEMANDA_ACT d;
            EQUIPS equip;
            ESPAIS esp;
            INSTALACIONS inst;
            ENTITATS ent;
            if (e.ColumnIndex == 2)
            {
                fila = e.RowIndex;
                if (dataGridViewActivitats.Rows[fila].Cells[0].Value != null)
                {
                    idAct = (int)dataGridViewActivitats.Rows[fila].Cells[0].Value;
                    a = ActivitatsORM.SelectActivitatsById(idAct).First();
                    d = DemandaActORM.SelectDemandaActById(a.id_demanda_act).First();
                    equip = EquipsORM.SelectAllEquipByid(d.id_equip).First();
                    e.Value = equip.nom;
                }
            }
            else if (e.ColumnIndex == 4)
            {
                fila = e.RowIndex;
                if (dataGridViewActivitats.Rows[fila].Cells[0].Value != null)
                {
                    idAct = (int)dataGridViewActivitats.Rows[fila].Cells[0].Value;
                    a = ActivitatsORM.SelectActivitatsById(idAct).First();
                    d = DemandaActORM.SelectDemandaActById(a.id_demanda_act).First();
                    esp = EspaisORM.selectEspaisById(d.id_espai).First();
                    e.Value = esp.nom;
                }
            }
            else if (e.ColumnIndex == 3)
            {
                fila = e.RowIndex;
                if (dataGridViewActivitats.Rows[fila].Cells[0].Value != null)
                {
                    idAct = (int)dataGridViewActivitats.Rows[fila].Cells[0].Value;
                    a = ActivitatsORM.SelectActivitatsById(idAct).First();
                    d = DemandaActORM.SelectDemandaActById(a.id_demanda_act).First();
                    esp = EspaisORM.selectEspaisById(d.id_espai).First();
                    inst = InstalacionsORM.selectInstalacioById(esp.id_instalacio).First();
                    e.Value = inst.nom;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                fila = e.RowIndex;
                if (dataGridViewActivitats.Rows[fila].Cells[0].Value != null)
                {
                    idAct = (int)dataGridViewActivitats.Rows[fila].Cells[0].Value;
                    a = ActivitatsORM.SelectActivitatsById(idAct).First();
                    d = DemandaActORM.SelectDemandaActById(a.id_demanda_act).First();
                    equip = EquipsORM.SelectAllEquipByid(d.id_equip).First();
                    ent = EntitatsORM.SelectEntitiesByIdiTemp(equip.id_entitat, equip.temporada).First();
                    e.Value = ent.nom;
                }
            }
        }

        private void llistatUsuarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }

        private void llistatEspaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEspais();
        }

        private void afegirEspaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.FormEspaisTodosAlta();
        }

        private void llistatInstallacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacions();
        }

        private void afegirInstallacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormInstalacioAlta();
        }
    }
}
