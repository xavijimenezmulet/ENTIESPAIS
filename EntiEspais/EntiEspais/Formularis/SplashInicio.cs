using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * SPLASH (ENS MOSTRA EL LOGTIP AL PRINCIPI)
 **/
namespace EntiEspais
{
    public partial class SplashInicio : Form
    {
        //CONSTRUCTORS
        public SplashInicio()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 6000;
        }

        /**
         * RELLOTGE QUE CALCULA EL TEMPS QUE HA D'ESTAR ACTIU
         **/
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /**
         * ENS MOSTRARÀ TOT EN TRANSPARÈNCIA PERQUÈES VEGI NOMÉS EL LOGOTIP
         **/
        private void SplashInicio_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.Gray;
        }
    }
}
