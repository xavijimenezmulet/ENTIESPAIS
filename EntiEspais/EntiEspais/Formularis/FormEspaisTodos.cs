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
    public partial class FormEspaisTodos : Form
    {
        public FormEspaisTodos()
        {
            InitializeComponent();
        }

        //Load
        private void FormEspaisTodos_Load(object sender, EventArgs e)
        {
            bindingSourceEspais.DataSource = ORM.EspaisORM.selectEspais();
        }

        //Activated
        private void FormEspaisTodos_Activated(object sender, EventArgs e)
        {
            bindingSourceEspais.DataSource = ORM.EspaisORM.selectEspais();
        }

        //Añadir
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosAlta();
        }

        //Modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
        }

        //Eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ESBORRAT");
                    }

                }
                else
                {
                    MessageBox.Show("ACCIÓ CANCELADA");
                }
            }
        }

        //Modificar al doble click
        private void dataGridViewEspais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.ObridorFormulari.FormEspaisTodosModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
        }

        //Eliminar al supr
        private void dataGridViewEspais_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    String mensaje = ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ESBORRAT");
                    }

                }
                else
                {
                    MessageBox.Show("ACCIÓ CANCELADA");
                    e.Cancel = true;
                }
            }
        }
    }
}
