using EntiEspais.Classes;
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
    public partial class FormAdministradors : Form
    {
        public FormAdministradors()
        {
            InitializeComponent();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        private void FormAdministradors_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox7.Select();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void afegirUsuariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void toolStripButtonSortir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
