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
            FormEspaiAlta formEspaiAlta = new FormEspaiAlta(_instalacio.id);
            formEspaiAlta.ShowDialog();
        }

        //Buton modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormEspaiAlta formEspaiAlta = new FormEspaiAlta((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
            formEspaiAlta.Text = "MODIFICAR ESPAI";
            formEspaiAlta.ShowDialog();
        }

        //Buton eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desitja esborrar aquest espai?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
                MessageBox.Show("ESBORRAT");
            }
            else
            {
                MessageBox.Show("ACCIÓ CANCELADA");
            }
        }

        //Refrescar grid
        private void refrescarGrid()
        {
            bindingSourceEspais.DataSource = _instalacio.ESPAIS.ToList();
        }
    }
}
