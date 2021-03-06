﻿using EntiEspais.Classes;
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
    public partial class FormEntitats : Form
    {
        public string auxTemp = "";
        public FormEntitats()
        {
            InitializeComponent();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormEntitats_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox7.Select();
            omplirComboTemp();
            bindingSourceEntitats.DataSource = EntitatsORM.SelectAllEntitiesByTemporadaActual(Utilitats.tempActual());
        }

        private void afegirUsuariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitat();
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
        //METODE AFEGIR ENTITAT
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormEntitat();
        }
        //METODE MODIFICAR ENTITAT
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ENTITATS entitat = (ENTITATS)dataGridViewEntitats.SelectedRows[0].DataBoundItem;
            FormEntitat fEntitat = new FormEntitat(entitat);
            fEntitat.ShowDialog();
        }
        //METODE ELIMINAR ENTITAT
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            DialogResult res = MessageBox.Show("¿Segur que vols eliminar?", "ATENCIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                mensaje = EntitatsORM.DeleteEntitat((ENTITATS)dataGridViewEntitats.SelectedRows[0].DataBoundItem);
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

        private void FormEntitats_Activated(object sender, EventArgs e)
        {
            bindingSourceEntitats.DataSource = EntitatsORM.SelectAllEntitiesByTemporadaActual(auxTemp);
        }

        public void omplirComboTemp()
        {
            List<ENTITATS> entitats = new List<ENTITATS>();
            entitats.AddRange(EntitatsORM.SelectAllEntities());
            List<string> temporadas = new List<string>();
            for (int i = 0; i < entitats.Count; i++)
            {
                if (!temporadas.Contains(entitats[i].temporada))
                {
                    temporadas.Add(entitats[i].temporada);
                }
            }
            comboBoxTemp.DataSource = temporadas;
            String tempActual = Utilitats.tempActual();
            comboBoxTemp.SelectedItem = tempActual;
        }

        private void comboBoxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxTemp = comboBoxTemp.SelectedValue.ToString();
            bindingSourceEntitats.DataSource = EntitatsORM.SelectAllEntitiesByTemporadaActual(auxTemp);
        }

        private void llistatActivitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormActivitats();
            this.Close();
        }

        private void afegirActivitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormDemandes();
            this.Close();
        }

        private void toolStripButtonActivitats_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormActivitats();
            this.Close();
        }
    }
}
