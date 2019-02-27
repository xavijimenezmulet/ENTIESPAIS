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
    public partial class FormSexe : Form
    {
        public SEXE s;
        public FormSexe()
        {
            this.Text = "NOU SEXE";
            s = new SEXE();
            InitializeComponent();
        }
        public FormSexe(SEXE sexe)
        {
            this.Text = "MODIFICAR SEXE";
            s = sexe;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
