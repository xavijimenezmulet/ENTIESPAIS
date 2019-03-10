using EntiEspais.Classes;
using EntiEspais.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntiEspais.Formularis
{
    public partial class FormDemanda : Form
    {
        DEMANDA_ACT demanda = null;
        public FormDemanda()
        {
            this.Text = "DEMANDA";
            InitializeComponent();
        }

        public FormDemanda(DEMANDA_ACT demanda)
        {
            this.demanda = demanda;
            this.Text = "MODIFICAR ACTIVITAT";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDemanda_Load(object sender, EventArgs e)
        {
            
            bindingSourceInstalacions.DataSource = InstalacionsORM.selectInstalacions();
            listBoxEspai.DataSource = EspaisORM.selectEspaisInstalacio((INSTALACIONS)comboBoxInst.SelectedItem);
            listBoxEspai.DisplayMember = "nom";
            listBoxEspai.ValueMember = "id";
            textBoxId.Text = demanda.id.ToString();
            textBoxNom.Text = demanda.nom;
            textBoxDuracio.Text = demanda.duracio.ToString();
            if(demanda.es_asignada == true)
            {
                radioButtonSi.Checked = true;
            }
            else
            {
                radioButtonNo.Checked = true;
            }
            EQUIPS equip = EquipsORM.SelectAllEquipByid(demanda.id_equip).First();
            string nom = equip.nom;
            textBoxEquip.Text = nom;
            HORES hores = HoresORM.SelectHoresByid(demanda.HORES.id).First();
            textBoxHinici.Text = hores.inici.ToString();
            textBoxHfi.Text = hores.fi.ToString();
            listBoxDies.DataSource = DiesSemanaORM.SelectAllDiesSemana();
            listBoxDies.DisplayMember = "nom";
            listBoxDies.ValueMember = "id";
            foreach (DIA_SEMANA dia in demanda.DIA_SEMANA)
            {
                listBoxDies.SelectedItems.Add(dia);
            }
            dataGridViewHorari.Rows.Clear();
            //-------------CALENDARI----------------------

            ESPAIS espai = (ESPAIS)listBoxEspai.SelectedItem;
            string[,] rows = Utilitats.horesYdies(espai);

            
            /*List<DEMANDA_ACT> demandesAssignades = DemandaActORM.SelectAllDemandaActAssignades();
            for (int k = 0; k < demandesAssignades.Count; k++)
            {
                //ESPAIS espai = (ESPAIS)listBoxEspai.SelectedItem;
                if (demandesAssignades[k].id_espai == espai.id)
                {
                    EQUIPS equipDemanda = EquipsORM.SelectAllEquipByid(demandesAssignades[k].id_equip).First();
                    foreach (DIA_SEMANA dia in demandesAssignades[k].DIA_SEMANA)
                    {
                        List<int> intervals = Utilitats.comparaHores(demandesAssignades[k].id_interval_hores);
                        for (int m = 0; m < intervals.Count; m++)
                        {
                            rows[intervals[m], dia.id + 1] = equipDemanda.nom;
                        }
                    }
                }
            }*/



            //---------OMPLIR CALENDARI--------------------
            dataGridViewHorari.Rows.Clear();
            List<EQUIPS> equips = EquipsORM.SelectAllEquips();
            INSTALACIONS instalacio = (INSTALACIONS)comboBoxInst.SelectedItem;
            List<HORARI_INSTALACIO> horariInst = new List<HORARI_INSTALACIO>();
            horariInst.AddRange(instalacio.HORARI_INSTALACIO);
            
            
            
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }

                dataGridViewHorari.Rows.Add(row);
                foreach (DataGridViewRow fila in dataGridViewHorari.Rows)
                {
                    foreach (DataGridViewCell cela in fila.Cells)
                    {
                        if (cela.Value != null)
                        {
                            for (int j = 0; j < equips.Count; j++)
                            {
                                if (cela.Value.ToString() == equips[j].nom)
                                {
                                    cela.Style.BackColor = System.Drawing.Color.Red;
                                }
                            }
                        }
                    }
                }
            }
            //------------PINTAR EN GRIS HORES FORA D'HORARI INSTALACIO----------------
           
            List<int> diesObert = new List<int>();
            foreach (HORARI_INSTALACIO h in horariInst)
            {
                diesObert.Add(h.id_dia);
            }
            int contador = 0;
            for (int i = 1; i < 8; i++)
            {
                if (diesObert.Contains(i))
                {
                    List<int> intervals = Utilitats.comparaHoresExcluides(horariInst[contador].id_hores);
                    for (int j = 0; j < intervals.Count; j++)
                    {
                        dataGridViewHorari.Rows[intervals[j]].Cells[horariInst[contador].id_dia + 1].Style.BackColor = System.Drawing.Color.LightGray;
                    }
                    contador++;
                }
                else
                {
                    for (int j = 0; j < Utilitats.intervalsHores; j++)
                    {
                        dataGridViewHorari.Rows[j].Cells[i + 1].Style.BackColor = System.Drawing.Color.LightGray;
                    }
                }
            }

        }

       

        private void comboBoxInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEspai.DataSource = EspaisORM.selectEspaisInstalacio((INSTALACIONS)comboBoxInst.SelectedItem);
        }

        private void listBoxEspai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewHorari.Rows.Clear();
            //-------------CALENDARI----------------------
            string[,] rows = Utilitats.horesYdies();

            List<DEMANDA_ACT> demandesAssignades = DemandaActORM.SelectAllDemandaActAssignades();
            for (int k = 0; k < demandesAssignades.Count; k++)
            {
                ESPAIS espai = (ESPAIS) listBoxEspai.SelectedItem;
                if (demandesAssignades[k].id_espai == espai.id)
                {
                    EQUIPS equipDemanda = EquipsORM.SelectAllEquipByid(demandesAssignades[k].id_equip).First();
                    foreach (DIA_SEMANA dia in demandesAssignades[k].DIA_SEMANA)
                    {
                        List<int> intervals = Utilitats.comparaHores(demandesAssignades[k].id_interval_hores);
                        for (int m = 0; m < intervals.Count; m++)
                        {
                            rows[intervals[m], dia.id + 1] = equipDemanda.nom;
                        }
                    }
                }
            }

            //---------OMPLIR CALENDARI--------------------
            
            INSTALACIONS instalacio = (INSTALACIONS)comboBoxInst.SelectedItem;
            List<HORARI_INSTALACIO> horariInst = new List<HORARI_INSTALACIO>();
            horariInst.AddRange(instalacio.HORARI_INSTALACIO);
            
            
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                dataGridViewHorari.Rows.Add(row);
                foreach (DataGridViewRow fila in dataGridViewHorari.Rows)
                {
                    foreach (DataGridViewCell cela in fila.Cells)
                    {
                        if (cela.Value != null)
                        {
                            for (int j = 0; j < equips.Count; j++)
                            {
                                if (cela.Value.ToString() == equips[j].nom)
                                {
                                    cela.Style.BackColor = System.Drawing.Color.Red;
                                }
                            }
                        }
                    }
                }
            }
            //------------PINTAR EN GRIS HORES FORA D'HORARI INSTALACIO----------------

            List<int> diesObert = new List<int>();
            foreach (HORARI_INSTALACIO h in horariInst)
            {
                diesObert.Add(h.id_dia);
            }
            int contador = 0;
            for (int i = 1; i < 8; i++)
            {
                if (diesObert.Contains(i))
                {
                    List<int> intervals = Utilitats.comparaHoresExcluides(horariInst[contador].id_hores);
                    for (int j = 0; j < intervals.Count; j++)
                    {
                        dataGridViewHorari.Rows[intervals[j]].Cells[horariInst[contador].id_dia + 1].Style.BackColor = System.Drawing.Color.LightGray;
                    }
                    contador++;
                }
                else
                {
                    for (int j = 0; j < Utilitats.intervalsHores; j++)
                    {
                        dataGridViewHorari.Rows[j].Cells[i + 1].Style.BackColor = System.Drawing.Color.LightGray;
                    }
                }
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
