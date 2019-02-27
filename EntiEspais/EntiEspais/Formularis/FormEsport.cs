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
    public partial class FormEsport : Form
    {
        public ESPORTS e;
        public FormEsport()
        {
            this.Text = "NOU ESPORT";
            e = new ESPORTS();
            InitializeComponent();
        }

        public FormEsport(ESPORTS esport)
        {
            this.Text = "MODIFICAR ESPORT";
            e = esport;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEsport_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR ESPORT"))
            {
                textBoxNom.Text = this.e.nom.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Esport buid!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOU ESPORT"))
            {
                String missatge = "";

                this.e.nom = textBoxNom.Text.ToString();

                missatge = EsportsORM.InsertEsport(this.e);

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
            else if (this.Text.Equals("MODIFICAR ESPORT"))
            {
                String missatge = "";

                this.e.nom = textBoxNom.Text.ToString();

                missatge = EsportsORM.UpdateEsport(this.e);

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
