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
    public partial class FormHora : Form
    {
        public HORES intervalHores;
        public FormHora()
        {
            this.Text = "NOU INTERVAL D'HORES";
            intervalHores = new HORES();
            InitializeComponent();
        }

        public FormHora(HORES intervalHores)
        {
            this.Text = "MODIFICAR INTERVAL D'HORES";
            this.intervalHores = intervalHores;
            InitializeComponent();
        }

        private void FormHora_Load(object sender, EventArgs e)
        {
            bindingSourceInici.DataSource = HoresORM.SelectIntervalHores();
            bindingSourceFinal.DataSource = HoresORM.SelectIntervalHores();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            HORES inici = (HORES)comboBoxInici.SelectedItem;
            HORES final= (HORES)comboBoxFinal.SelectedItem;

            if (inici.inici == final.inici)
            {
                MessageBox.Show("Dos intervals no poden ser iguals!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxFinal.Select();
            }
            else if (inici.inici > final.inici)
            {
                MessageBox.Show("El interval inici no pot ser més petit que el final!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboBoxInici.Select();
            }
            else if (this.Text.Equals("NOU INTERVAL D'HORES"))
            {
                String missatge = "";

                this.intervalHores.inici = inici.inici;
                this.intervalHores.fi = final.inici;

                missatge = HoresORM.InsertHora(this.intervalHores);

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
            else if (this.Text.Equals("MODIFICAR INTERVAL D'HORES"))
            {
                String missatge = "";

                this.intervalHores.inici = inici.inici;
                this.intervalHores.fi = final.inici;

                missatge = HoresORM.UpdateHora(this.intervalHores);

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
