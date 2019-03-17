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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
/*
            if (textBoxNom.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("Nom obligatori!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNom.Focus();
            }
            else if (textBoxContra.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("Contrasenya obligatoria!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContra.Focus();
            }
            else if(textBoxDir.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("Direcció obligatoria!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDir.Focus();
            }
            else if (textBoxNif.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("NIF obligatori!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNif.Focus();
            }
            else if (textBoxEmail.Text == "")
            {
                DialogResult mensaje = MessageBox.Show("Email obligatoria!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
            }
            else if (textBoxAlt.Text == "")
            {
                //provisional, posar mapa
                DialogResult mensaje = MessageBox.Show("Coordenades obligatories!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAlt.Focus();
            }
            else if (textBoxLat.Text == "")
            {
                //provisional, posar mapa
                DialogResult mensaje = MessageBox.Show("Coordenades obligatories!", "ATENCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLat.Focus();
            }
            else
            {
                if (entitat != null)
                {
                    EntitatsORM.UpdateEntitat(int.Parse(textBoxId.Text),
                    Utilitats.tempActual(),
                    textBoxNom.Text,
                    textBoxContra.Text,
                    textBoxDir.Text,
                    textBoxNif.Text,
                    textBoxEmail.Text,
                    textBoxImg.Text,
                    textBoxVid.Text,
                    float.Parse(textBoxAlt.Text, CultureInfo.InvariantCulture.NumberFormat),
                    float.Parse(textBoxLat.Text, CultureInfo.InvariantCulture.NumberFormat));

                    DialogResult mensaje = MessageBox.Show("Entitat modificada correctament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    EntitatsORM.InsertEntitat(/*int.Parse(textBoxId.Text),*/
/*
                    Utilitats.tempActual(),
                    textBoxNom.Text,
                    textBoxContra.Text,
                    textBoxDir.Text,
                    textBoxNif.Text,
                    textBoxEmail.Text,
                    textBoxImg.Text,
                    textBoxVid.Text,
                    float.Parse(textBoxAlt.Text, CultureInfo.InvariantCulture.NumberFormat),
                    float.Parse(textBoxLat.Text, CultureInfo.InvariantCulture.NumberFormat));

                    DialogResult mensaje = MessageBox.Show("Entitat afegida correctament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
*/
        }
    }
}
