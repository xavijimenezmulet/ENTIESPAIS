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
            ORM.EspaisORM.eliminarEspai((ESPAIS)dataGridViewEspais.SelectedRows[0].DataBoundItem);
        }
    }
}
