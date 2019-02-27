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
    public partial class FormDiaSemana : Form
    {
        public DIA_SEMANA diaSemana;
        public FormDiaSemana()
        {
            this.Text = "NOU DIA SEMANA";
            diaSemana = new DIA_SEMANA();
            InitializeComponent();
        }

        public FormDiaSemana(DIA_SEMANA diaSemana)
        {
            this.Text = "MODIFICAR DIA SEMANA";
            this.diaSemana = diaSemana;
            InitializeComponent();
        }

        private void FormDiaSemana_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR DIA SEMANA"))
            {
                textBoxNom.Text = diaSemana.nom.ToString();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Dia buid!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOU DIA SEMANA"))
            {
                String missatge = "";

                diaSemana.nom = textBoxNom.Text.ToString();

                missatge = DiesSemanaORM.InsertDia(this.diaSemana);

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
            else if (this.Text.Equals("MODIFICAR DIA SEMANA"))
            {
                String missatge = "";

                this.diaSemana.nom = textBoxNom.Text.ToString();

                missatge = DiesSemanaORM.UpdateDia(this.diaSemana);

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
