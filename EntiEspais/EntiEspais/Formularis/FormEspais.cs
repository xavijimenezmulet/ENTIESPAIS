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
    public partial class FormEspais : Form
    {
        INSTALACIONS _instalacio;

        public FormEspais()
        {
            InitializeComponent();
        }

        public FormEspais(INSTALACIONS _instalacio)
        {
            InitializeComponent();
            this._instalacio = _instalacio;
        }

        //Load
        private void FormEspais_Load(object sender, EventArgs e)
        {
            dataGridViewEspais.ClearSelection();
            refrescarGrid();
        }

        //Activated
        private void FormEspais_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        //Buton añadir
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormEspaisAlta(_instalacio.id);
        }

        //Buton modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                Classes.ObridorFormulari.obrirFormEspaisModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
            }
        }

        //Buton eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Desitja esborrar aquest espai?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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

        //Refrescar grid
        private void refrescarGrid()
        {
            bindingSourceEspais.DataSource = _instalacio.ESPAIS.ToList();
        }

        //Modificar al doble click
        private void dataGridViewEspais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEspais.RowCount == 0)
            {
                MessageBox.Show("SELECCIONA UN ELEMENT");
            }
            else
            {
                Classes.ObridorFormulari.obrirFormEspaisModificar((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
            }
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
                DialogResult dr = MessageBox.Show("Desitja esborrar aquest espai?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
