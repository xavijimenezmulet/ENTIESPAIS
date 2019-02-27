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
    public partial class FormCompeticio : Form
    {
        public COMPETICIONS c;
        public FormCompeticio()
        {
            this.Text = "NOVA COMPETICIÓ";
            c = new COMPETICIONS();
            InitializeComponent();
        }

        public FormCompeticio(COMPETICIONS c)
        {
            this.Text = "MODIFICAR COMPETICIÓ";
            this.c = c;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCompeticio_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR COMPETICIÓ"))
            {
                textBoxNom.Text = c.nom.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Competició buida!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOVA COMPETICIÓ"))
            {
                String missatge = "";

                c.nom = textBoxNom.Text.ToString();

                missatge = CompeticionsORM.InsertCompeticio(this.c);

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
            else if (this.Text.Equals("MODIFICAR COMPETICIÓ"))
            {
                String missatge = "";

                this.c.nom = textBoxNom.Text.ToString();

                missatge = CompeticionsORM.UpdateCompeticio(this.c);

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
