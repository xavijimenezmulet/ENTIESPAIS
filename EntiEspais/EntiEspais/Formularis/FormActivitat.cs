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
    public partial class FormActivitat : Form
    {
        ACTIVITATS activitat = null;
        public FormActivitat()
        {
            this.Text = "NOVA ACTIVITAT";
            InitializeComponent();
        }

        public FormActivitat(ACTIVITATS activitat)
        {
            this.activitat = activitat;
            this.Text = "VEURE ACTIVITAT";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormActivitat_Load(object sender, EventArgs e)
        {   
         
            if(activitat != null)
            {
                DEMANDA_ACT demanda = DemandaActORM.SelectDemandaActById(activitat.id_demanda_act).First();
                EQUIPS equip = EquipsORM.SelectAllEquipByid(demanda.id_equip).First();
                HORES hora = HoresORM.SelectHoresByid(demanda.id_interval_hores).First();
                ESPAIS espai = EspaisORM.selectEspaisById(demanda.id_espai).First();
                INSTALACIONS inst = InstalacionsORM.selectInstalacioById(espai.id_instalacio).First();
                ADMINISTRADORS admin = AdministradorsORM.SelectAdministradorById(activitat.id_admin).First();
                ENTITATS entitat = EntitatsORM.SelectEntitiesByIdiTemp(equip.id_entitat, equip.temporada).First();
                textBoxId.Text = activitat.id.ToString();
                textBoxNom.Text = activitat.nom;
                TextBoxEquip.Text = equip.nom;
                listBoxDies.DataSource = DiesSemanaORM.SelectAllDiesSemana();
                listBoxDies.ValueMember = "id";
                listBoxDies.DisplayMember = "nom";//o dia
                listBoxDies.SelectedItems.Clear();
                foreach (DIA_SEMANA dia in demanda.DIA_SEMANA)
                {
                    listBoxDies.SelectedItems.Add(dia);
                }
                textBoxHinici.Text = hora.inici.ToString();
                textBoxHfi.Text = hora.fi.ToString();
                textBoxEspai.Text = espai.nom;
                textBoxInst.Text = inst.nom;
                textBoxAdmin.Text = admin.email;
            }
        }
    }
}
