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
    public partial class FormEspaiAlta : Form
    {
        ESPAIS _espai;
        int id_instalacio;
        bool modificar = false;

        public FormEspaiAlta()
        {
            InitializeComponent();
        }

        //Alta
        public FormEspaiAlta(int id_instalacio)
        {
            InitializeComponent();
            this.id_instalacio = id_instalacio;
        }

        //Modificar
        public FormEspaiAlta(ESPAIS _espai)
        {
            InitializeComponent();
            this._espai = _espai;
            modificar = true;
        }

        //Load
        private void FormEspaiAlta_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                textBoxNom.Text = _espai.nom;
                textBoxPreu.Text = _espai.preu.ToString();
                if (_espai.es_exterior == false)
                {
                    comboBoxTipus.SelectedIndex = 0;
                }
                else
                {
                    comboBoxTipus.SelectedIndex = 1;
                }

            }
        }

        //Buton aceptar
        //Da de alta un espacio o modificarlo
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool exterior = false;

            if (comboBoxTipus.SelectedIndex == 0)
            {
                exterior = false;
            }
            else
            {
                exterior = true;
            }

            if (!modificar)
            {
                int parsedValue;
                if (!int.TryParse(textBoxPreu.Text, out parsedValue) || textBoxNom.Text == "")
                {
                    MessageBox.Show("Comprueba los datos introducidos");
                    return;
                }
                else
                {
                    String mensaje = ORM.EspaisORM.altaEspai(textBoxNom.Text, float.Parse(textBoxPreu.Text), exterior, id_instalacio);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("AGREGAT");
                    }
                }
            }
            else
            {
                String mensaje = ORM.EspaisORM.modificarEspai(_espai.id, textBoxNom.Text, float.Parse(textBoxPreu.Text), exterior);

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("MODIFICAT");
                }
            }

            this.Close();
        }

        //Buton cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
