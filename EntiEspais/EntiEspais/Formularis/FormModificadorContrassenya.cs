using BlowFishCS;
using EntiEspais.Classes;
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
    public partial class FormModificadorContrassenya : Form
    {
        public ADMINISTRADORS admin;
        public FormModificadorContrassenya(ADMINISTRADORS admin)
        {
            this.Text = "CAMBIAR CONTRASSENYA DE " + admin.nom.ToUpper();
            this.admin = admin;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.textBoxActual.Text.Equals(""))
            {
                MessageBox.Show("Escriu una Contrassenya Actual!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxActual.Select();

            } else if (textBoxNova.Text.Equals(""))
            {
                MessageBox.Show("Escriu una Contrassenya Nova!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxActual.Select();
            } else if (textBoxRepeticio.Text.Equals(""))
            {
                MessageBox.Show("Escriu una Contrassenya Repetició!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxActual.Select();
            } else if (!AdministradorsORM.FindAdminByEmailAndPassword(this.admin.email, textBoxActual.Text.ToString()))
            {
                MessageBox.Show("La contrassenya actual no coincideix amb la del usuari!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxActual.Select();
            }
            else if (!textBoxNova.Text.Equals(textBoxRepeticio.Text))
            {
                MessageBox.Show("Les dos contrassenyes no coincideixen!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNova.Select();
            }
            else
            {
                String missatge = "";
                BlowFish b = new BlowFish("04B915BA43FEB5B6");
                this.admin.contrasenya = b.Encrypt_CBC(textBoxNova.Text);

                missatge = AdministradorsORM.UpdateAdministrador(this.admin);

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
