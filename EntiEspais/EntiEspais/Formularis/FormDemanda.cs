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
        string[,] rows;

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
            rows = Utilitats.omplirMatriuCalendari(espai);

           

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
            int posicioInicial = Utilitats.trobarCela(rows, textBoxHinici.Text);
            dataGridViewHorari.CurrentCell = dataGridViewHorari.Rows[posicioInicial].Cells[0];
        }

        private void comboBoxInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEspai.DataSource = EspaisORM.selectEspaisInstalacio((INSTALACIONS)comboBoxInst.SelectedItem);
        }

        private void listBoxEspai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewHorari.Rows.Clear();
            //-------------CALENDARI----------------------
            ESPAIS espai = (ESPAIS)listBoxEspai.SelectedItem;
            rows = Utilitats.omplirMatriuCalendari(espai);

            //---------OMPLIR CALENDARI--------------------

            INSTALACIONS instalacio = (INSTALACIONS)comboBoxInst.SelectedItem;
            List<EQUIPS> equips = EquipsORM.SelectAllEquips();
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
            int posicioInicial = Utilitats.trobarCela(rows, textBoxHinici.Text);
            dataGridViewHorari.CurrentCell = dataGridViewHorari.Rows[posicioInicial].Cells[0];
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ESPAIS esp = (ESPAIS)listBoxEspai.SelectedItem;
            bool ocupat = Utilitats.comprobarHoresEspai(demanda, rows);
            if(ocupat == true)
            {
                DialogResult mensaje = MessageBox.Show("Espai ocupat!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                demanda.es_asignada = true;
                string missatge = ORM.DemandaActORM.UpdateAssignarDemanda(demanda);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Demanda assignada correctament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ACTIVITATS activitat = new ACTIVITATS();
                    activitat.id_demanda_act = demanda.id;
                    //activitat.id_admin = Utilitats.currentAdmin();
                    activitat.nom = demanda.nom;
                    activitat.id_espai = esp.id;
                    string missatgeAct = ORM.ActivitatsORM.InsertActivitat(activitat);
                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Activitat creada correctament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
        }
    }
}
