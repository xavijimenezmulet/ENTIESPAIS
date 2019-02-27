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
    public partial class FormCategoriaEquip : Form
    {
        public CATEGORIA_EQUIP categoria;
        public FormCategoriaEquip()
        {
            categoria = new CATEGORIA_EQUIP();
            this.Text = "NOVA CATEGORIA EQUIP";
            InitializeComponent();
        }

        public FormCategoriaEquip(CATEGORIA_EQUIP categoria)
        {
            this.categoria = categoria;
            this.Text = "MODIFICAR CATEGORIA EQUIP";
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategoriaEquip_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("MODIFICAR CATEGORIA EQUIP"))
            {
                textBoxNom.Text = categoria.nom.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Equals(""))
            {
                MessageBox.Show("Categoria buida!", "ADVERTÈNCIA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNom.Select();
            }
            else if (this.Text.Equals("NOVA CATEGORIA EQUIP"))
            {
                String missatge = "";

                categoria.nom = textBoxNom.Text.ToString();

                missatge = CategoriaPerEquipORM.InsertCategoriaPerEquip(this.categoria);

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
            else if (this.Text.Equals("MODIFICAR CATEGORIA EQUIP"))
            {
                String missatge = "";

                this.categoria.nom = textBoxNom.Text.ToString();

                missatge = CategoriaPerEquipORM.UpdateCategoriaPerEquip(this.categoria);

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
