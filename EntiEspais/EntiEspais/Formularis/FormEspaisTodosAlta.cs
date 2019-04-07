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
    public partial class FormEspaisTodosAlta : Form
    {
        ESPAIS _espai;
        bool modificar = false;

        public FormEspaisTodosAlta()
        {
            InitializeComponent();
        }

        //Modificar
        public FormEspaisTodosAlta(ESPAIS _espai)
        {
            InitializeComponent();
            this._espai = _espai;
            modificar = true;
        }

        //Load
        private void FormEspaisTodosAlta_Load(object sender, EventArgs e)
        {
            bindingSourceInstalacions.DataSource = ORM.InstalacionsORM.selectInstalacions();

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

                comboBoxInstalacio.Enabled = false;

            }
        }

        //Aceptar
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
                    String mensaje = ORM.EspaisORM.altaEspai(textBoxNom.Text, float.Parse(textBoxPreu.Text), exterior, (int)comboBoxInstalacio.SelectedValue);

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

        //Cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
