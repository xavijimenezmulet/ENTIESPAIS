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
    public partial class FormHora : Form
    {
        public HORES intervalHores;
        public FormHora()
        {
            this.Text = "NOU INTERVAL D'HORES";
            intervalHores = new HORES();
            InitializeComponent();
        }

        public FormHora(HORES intervalHores)
        {
            this.Text = "MODIFICAR INTERVAL D'HORES";
            this.intervalHores = intervalHores;
            InitializeComponent();
        }
    }
}
