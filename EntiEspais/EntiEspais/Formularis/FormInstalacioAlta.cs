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
    public partial class FormInstalacioAlta : Form
    {
        INSTALACIONS _instalacio;
        bool modificar = false;

        public FormInstalacioAlta()
        {
            InitializeComponent();
        }

        public FormInstalacioAlta(INSTALACIONS _instalacio)
        {
            InitializeComponent();
            this._instalacio = _instalacio;
            modificar = true;
        }

        //Load para cargar datos en caso de que sea para modificar
        private void FormInstalacioAlta_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                textBoxNom.Text = _instalacio.nom;
                textBoxContrasenya.Text = _instalacio.contrasenya;
                textBoxAdresa.Text = _instalacio.adresa;
                comboBoxTipus.SelectedItem = _instalacio.tipus;
                textBoxEmail.Text = _instalacio.email;
                textBoxRutaImatge.Text = _instalacio.ruta_imagen;
                textBoxAltitud.Text = _instalacio.altitut.ToString();
                textBoxLatitud.Text = _instalacio.latitut.ToString();
            }
        }

        //Añadir una instalación o modificarla
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Añadir
            if (!modificar)
            {
                ORM.InstalacionsORM.altaInstalacio(textBoxNom.Text, textBoxContrasenya.Text, textBoxAdresa.Text,
                     comboBoxTipus.Text, textBoxEmail.Text, textBoxRutaImatge.Text, float.Parse(textBoxAltitud.Text), float.Parse(textBoxLatitud.Text));
            }
            //Modificar
            else
            {
                ORM.InstalacionsORM.modificarinstalacio(_instalacio.id, textBoxNom.Text, textBoxContrasenya.Text, textBoxAdresa.Text,
                     comboBoxTipus.Text, textBoxEmail.Text, textBoxRutaImatge.Text, float.Parse(textBoxAltitud.Text), float.Parse(textBoxLatitud.Text));
            }

            this.Close();
        }

        //Botón cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Buscar la ruta de la imagen
        private void buttonRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRutaImatge.Text = openFileDialog.FileName;
            }
        }
    }
}
