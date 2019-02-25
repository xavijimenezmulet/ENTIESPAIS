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
    public partial class FormCategoriaEdat : Form
    {
        public CATEGORIA_EDAT c;

        public FormCategoriaEdat()
        {
            this.Text = "NOVA CATEGORIA EDAT";
            FormCategoriaEdats.verdadero = true;
            c = new CATEGORIA_EDAT();
            InitializeComponent();
        }

        public FormCategoriaEdat(CATEGORIA_EDAT categoria)
        {
            this.Text = "MODIFICAR CATEGORIA EDAT";
            FormCategoriaEdats.verdadero = true;
            c = categoria;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategoriaEdat_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR CATEGORIA EDAT"))
            {
                textBoxNom.Text = c.nom.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Categoria buida!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOVA CATEGORIA EDAT"))
            {
                String missatge = "";

                c.nom = textBoxNom.Text.ToString();

                missatge = CategoriaPerEdatORM.InsertCategoriaPerEdat(this.c);

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
            else if (this.Text.Equals("MODIFICAR CATEGORIA EDAT"))
            {
                String missatge = "";

                this.c.nom = textBoxNom.Text.ToString();

                missatge = CategoriaPerEdatORM.UpdateCategoriaPerEdat(this.c);

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
