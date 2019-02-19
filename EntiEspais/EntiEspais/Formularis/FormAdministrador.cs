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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            this.Text = "NOU ADMINISTRADOR";
            InitializeComponent();
        }

        public FormAdministrador(ADMINISTRADORS administrador)
        {
            this.Text = "MODIFICAR ADMINISTRADOR";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
