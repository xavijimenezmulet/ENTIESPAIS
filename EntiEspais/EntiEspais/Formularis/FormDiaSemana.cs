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
    public partial class FormDiaSemana : Form
    {
        public DIA_SEMANA diaSemana;
        public FormDiaSemana()
        {
            this.Text = "NOU DIA SEMANA";
            diaSemana = new DIA_SEMANA();
            InitializeComponent();
        }

        public FormDiaSemana(DIA_SEMANA diaSemana)
        {
            this.Text = "MODIFICAR DIA SEMANA";
            this.diaSemana = diaSemana;
            InitializeComponent();
        }
    }
}
