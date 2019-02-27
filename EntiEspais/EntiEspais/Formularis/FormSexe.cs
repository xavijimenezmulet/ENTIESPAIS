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
    public partial class FormSexe : Form
    {
        public SEXE s;
        public FormSexe()
        {
            this.Text = "NOU SEXE";
            s = new SEXE();
            InitializeComponent();
        }
        public FormSexe(SEXE sexe)
        {
            this.Text = "MODIFICAR SEXE";
            s = sexe;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSexe_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR SEXE"))
            {
                textBoxNom.Text = this.s.tipus.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Sexe buid!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOU SEXE"))
            {
                String missatge = "";

                this.s.tipus = textBoxNom.Text.ToString();

                missatge = SexesORM.InsertSexe(this.s);

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
            else if (this.Text.Equals("MODIFICAR SEXE"))
            {
                String missatge = "";

                this.s.tipus = textBoxNom.Text.ToString();

                missatge = SexesORM.UpdateSexe(this.s);

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
