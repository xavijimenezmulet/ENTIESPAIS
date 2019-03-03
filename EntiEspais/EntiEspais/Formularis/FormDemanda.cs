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
            bindingSourceHoras.DataSource = HoresORM.SelectAllHores();
            //bindingSourceInstalacions.DataSource = Insta
            List<DIA_SEMANA> dies = new List<DIA_SEMANA>();
            foreach (DIA_SEMANA dia in demanda.DIA_SEMANA)
            {
                dies.Add(dia);
            }
            listBoxCalDies.DataSource = dies;
            listBoxCalDies.DisplayMember = "nom";
            listBoxCalDies.ValueMember = "id";
            textBoxId.Text = demanda.id.ToString();
            textBoxNom.Text = demanda.nom;
            textBoxDuracio.Text = demanda.duracio.ToString();
            //textBoxEspais.Text = demanda.num_espais.ToString();
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
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
