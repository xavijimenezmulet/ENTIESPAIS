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
    public partial class FormInstalacions : Form
    {
        public FormInstalacions()
        {
            InitializeComponent();
        }

        //Load
        private void FormInstalacions_Load(object sender, EventArgs e)
        {
            bindingSourceInstalacio.DataSource = ORM.InstalacionsORM.selectInstalacions();
        }

        //Activated
        private void FormInstalacions_Activated(object sender, EventArgs e)
        {
            bindingSourceInstalacio.DataSource = ORM.InstalacionsORM.selectInstalacions();
        }

        //Botón añadir
        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormInstalacioAlta();
        }

        //Botón eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desitja esborrar aquesta instalació?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                ORM.InstalacionsORM.eliminarInstalacio((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
                MessageBox.Show("ESBORRAT");
            }
            else
            {
                MessageBox.Show("ACCIÓ CANCELADA");
            }

        }

        //Botón modificar
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormInstalacioModificar((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
        }

        //Buton espais
        //Le pasaremos la instalación para mostrar sus espacios
        private void buttonEspais_Click(object sender, EventArgs e)
        {
            Classes.ObridorFormulari.obrirFormEspais((INSTALACIONS)dataGridViewInstalacions.SelectedRows[0].DataBoundItem);
        }
    }
}
