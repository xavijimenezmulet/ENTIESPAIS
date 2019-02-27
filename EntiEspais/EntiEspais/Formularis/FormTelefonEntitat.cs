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
    public partial class FormTelefonEntitat : Form
    {
        public TELEFONS_ENTITATS tEntitat;
        public FormTelefonEntitat()
        {
            this.Text = "NOU TELÈFON ENTITAT";
            tEntitat = new TELEFONS_ENTITATS();
            InitializeComponent();
        }

        public FormTelefonEntitat(TELEFONS_ENTITATS tEntitat)
        {
            this.Text = "MODIFICAR TELÈFON ENTITAT";
            this.tEntitat = tEntitat;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
