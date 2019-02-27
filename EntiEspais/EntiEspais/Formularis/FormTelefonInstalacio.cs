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
    public partial class FormTelefonInstalacio : Form
    {
        public TELEFONS_INSTALACIONS tInstalacio;
        public FormTelefonInstalacio()
        {
            this.Text = "NOU TELÈFON INSTAL·LACIÓ";
            tInstalacio = new TELEFONS_INSTALACIONS();
            InitializeComponent();
        }

        public FormTelefonInstalacio(TELEFONS_INSTALACIONS tInstalacio)
        {
            this.Text = "MODIFICAR TELÈFON INSTAL·LACIÓ";
            this.tInstalacio = tInstalacio;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTelefonInstalacio_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR TELÈFON"))
            {
                textBoxNom.Text = this.tInstalacio.telefon.ToString();
            }
        }
    }
}
