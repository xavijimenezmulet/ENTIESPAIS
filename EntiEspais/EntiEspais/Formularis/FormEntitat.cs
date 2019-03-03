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
    public partial class FormEntitat : Form
    {
        ENTITATS entitat = null;
        public FormEntitat()
        {
            this.Text = "NOVA ENTITAT";
            InitializeComponent();
        }

        public FormEntitat(ENTITATS entitat)
        {
            this.entitat = entitat;
            this.Text = "MODIFICAR ENTITAT";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEntitat_Load(object sender, EventArgs e)
        {            
            if(entitat != null)
            {
                textBoxId.Text = entitat.id.ToString();
                textBoxTemp.Text = entitat.temporada;
                textBoxNom.Text = entitat.nom;
                textBoxContra.Text = entitat.contrasenya;
                textBoxDir.Text = entitat.adresa;
                textBoxNif.Text = entitat.nif;
                textBoxEmail.Text = entitat.email;
                textBoxImg.Text = entitat.ruta_imagen;
                textBoxAlt.Text = entitat.altitud.ToString();
                textBoxLat.Text = entitat.latitud.ToString();
                textBoxVid.Text = entitat.ruta_video;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
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
        }
    }
}
