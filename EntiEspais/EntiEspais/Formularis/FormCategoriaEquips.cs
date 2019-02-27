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
    public partial class FormCategoriaEquips : Form
    {
        public static Boolean verdadero;

        public FormCategoriaEquips()
        {
            InitializeComponent();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEquip();
        }

        private void FormCategoriaEquips_Load(object sender, EventArgs e)
        {
            bindingSourceCategoriaEquips.DataSource = CategoriaPerEquipORM.SelectAllCategoriesPerEquip();
        }

        private void FormCategoriaEquips_Activated(object sender, EventArgs e)
        {
            if (verdadero)
            {
                bindingSourceCategoriaEquips.DataSource = CategoriaPerEquipORM.SelectAllCategoriesPerEquip();
                verdadero = false;
            }
        }

        private Boolean eliminar()
        {
            Boolean correcto = true;

            String missatge = "";
            DialogResult resultat = MessageBox.Show("Estàs segur de borrar la categoria?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                missatge = CategoriaPerEquipORM.DeleteByCategoriaPerEquip((CATEGORIA_EQUIP)dataGridViewCategoriaEquips.SelectedRows[0].DataBoundItem);
                if (!missatge.Equals(""))
                {
                    MessageBox.Show(missatge, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }
            }
            else
            {
                correcto = false;
            }

            return correcto;
        }

        private void dataGridViewCategoriaEquips_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Boolean correcto = eliminar();

            if (!correcto)
            {
                e.Cancel = true;
            }
            else
            {
                verdadero = true;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEquip((CATEGORIA_EQUIP)dataGridViewCategoriaEquips.SelectedRows[0].DataBoundItem);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            verdadero = true;
            bindingSourceCategoriaEquips.DataSource = CategoriaPerEquipORM.SelectAllCategoriesPerEquip();
        }

        private void dataGridViewCategoriaEquips_DoubleClick(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormCategoriaEquip((CATEGORIA_EQUIP)dataGridViewCategoriaEquips.SelectedRows[0].DataBoundItem);
        }
    }
}
