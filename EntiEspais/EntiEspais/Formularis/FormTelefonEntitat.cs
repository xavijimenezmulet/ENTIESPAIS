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
    public partial class FormTelefonEntitat : Form
    {
        public TELEFONS_ENTITATS tEntitat;
        public FormTelefonEntitat()
        {
            this.Text = "NOU TELÈFON ENTITAT";
            tEntitat = new TELEFONS_ENTITATS();
            InitializeComponent();
        }

        public FormTelefonEntitat(TELEFONS_ENTITATS tEntitat)
        {
            this.Text = "MODIFICAR TELÈFON ENTITAT";
            this.tEntitat = tEntitat;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTelefonEntitat_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR TELÈFON ENTITAT"))
            {
                textBoxNom.Text = this.tEntitat.numero.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Telèfon buid!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOU TELÈFON ENTITAT"))
            {
                String missatge = "";

                this.tEntitat.numero = textBoxNom.Text.ToString();

                missatge = TelefonsEntitatsORM.InsertTelefon(this.tEntitat);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }
            else if (this.Text.Equals("MODIFICAR TELÈFON ENTITAT"))
            {
                String missatge = "";

                this.tEntitat.numero = textBoxNom.Text.ToString();

                missatge = TelefonsEntitatsORM.UpdateTelefon(this.tEntitat);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
    }
}
