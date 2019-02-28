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
    public partial class FormAdministrador : Form
    {
        public ADMINISTRADORS admin;
        public FormAdministrador()
        {
            this.Text = "NOU ADMINISTRADOR";
            this.admin = new ADMINISTRADORS();
            FormAdministradors.verdadero = true;
            InitializeComponent();
        }

        public FormAdministrador(ADMINISTRADORS administrador)
        {
            this.Text = "MODIFICAR ADMINISTRADOR";
            this.admin = administrador;
            FormAdministradors.verdadero = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            if( this.Text.Equals( "MODIFICAR ADMINISTRADOR" ))
            {
                textBoxId.Text      = admin.id.ToString();
                textBoxNom.Text     = admin.nom.ToString();
                textBoxCognoms.Text = admin.cognoms.ToString();
                textBoxDni.Text     = admin.dni.ToString();
                textBoxEmail.Text   = admin.email.ToString();
            }
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if ( textBoxNom.Text.Equals( "" ) )
            {
                MessageBox.Show( "Nom buit!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                textBoxNom.Select();
            }
            else if ( textBoxCognoms.Text.Equals( "" ) )
            {
                MessageBox.Show("Cognoms buits!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxCognoms.Select();
            }
            else if ( textBoxDni.Text.Equals( "" ) )
            {
                MessageBox.Show("DNI buit!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxDni.Select();
            }
            else if ( textBoxEmail.Text.Equals( "" ) )
            {
                MessageBox.Show(" Email buit!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                textBoxEmail.Select();
            }
            else if (!Utilitats.isAnEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Email mal escrit!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxEmail.Select();
            }
            else if( this.Text.Equals( "NOU ADMINISTRADOR" ) )
            {
                String missatge = "";
                this.admin.nom          = textBoxNom.Text.ToString();
                this.admin.cognoms      = textBoxCognoms.Text.ToString();
                this.admin.dni          = textBoxDni.Text.ToString();
                this.admin.email        = textBoxEmail.Text.ToString();
                this.admin.contrasenya  = Utilitats.encriptarContrassenyaAdmins();  //ens encripta la contrasenya bàsica d'un admin

                missatge = AdministradorsORM.InsertAdministrador(this.admin);

                if ( missatge != "" )
                {
                    MessageBox.Show( missatge, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                else
                {
                    MessageBox.Show( "Introduït perfectament!", "INFORMACIÓ", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                this.Close();

            }
            else if ( this.Text.Equals( "MODIFICAR ADMINISTRADOR" ) )
            {
                String missatge = "";
                this.admin.nom = textBoxNom.Text.ToString();
                this.admin.cognoms = textBoxCognoms.Text.ToString();
                this.admin.dni = textBoxDni.Text.ToString();
                this.admin.email = textBoxEmail.Text.ToString();

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
