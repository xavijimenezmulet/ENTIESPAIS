using EntiEspais.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * PROJECTE PER L'AJUNTAMENT DE SANT CUGAT DEL VALLÈS I OMET PER GESTIONAR
 * ELS CENTRES ESPORTIUS I LES SEVES INSTAL·LACIONS
 * @creadors JOEL GALIMANY, LUÍS PEREA, DAVID GUTIÉRREZ I XAVI JIMÉNEZ
 * @company  CEP Launcher
 * @date     06/02/2019
 * @latest   14/02/2019
 **/
/**
 * FORMULARI PRINCIPAL (MAIN)
 **/
namespace EntiEspais
{
    public partial class FormPrincipal : Form
    {
        //contador (per la galeria d'imatges)
        public static int contador;
        public FormPrincipal()
        {
            contador = 1;
            InitializeComponent();
        }

        /**
         * TIMER IMATGES A CADA VOLTA ENS MOTRA UNA IMATGE DIFERENT
         **/
        private void timerImagenes_Tick(object sender, EventArgs e)
        {
            contador++;
            switch (contador)
            {
                case 1:
                    pictureBoxImagenPrincipal.Image = pictureBox1.Image;
                    break;
                case 2:
                    pictureBoxImagenPrincipal.Image = pictureBox2.Image;
                    break;
                case 3:
                    pictureBoxImagenPrincipal.Image = pictureBox3.Image;
                    break;
                case 4:
                    pictureBoxImagenPrincipal.Image = pictureBox4.Image;
                    break;
                case 5:
                    pictureBoxImagenPrincipal.Image = pictureBox5.Image;
                    break;
                case 6:
                    pictureBoxImagenPrincipal.Image = pictureBox6.Image;
                    contador = 0;
                    break;
            }
        }

        /**
         * LOAD ENS CARREGA AL PRIMER COP QUE ENTREM TOT EL CONTINGUT
         **/
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            pictureBoxImagenPrincipal.Image = pictureBox1.Image;
            Reloj.Start();  //incia el rellotge
            pictureBoxImagenPrincipal.Select(); //seleccionem imatge perque no es seleccioni ninguna grid

            
        }

        /**
         * ENS ENVIA A LA PÀGINA PRINCIPAL DEL AJUNTAMENT DE SANT CUGAT
         **/
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.santcugat.cat/");
        }

        /**
         * VINCULEM LA HORA ACTUAL A LA LABEL
         **/
        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = Utilitats.ponerHoraMenu();
        }

        /**
         * AL CLICAR AL ICONA SORTIR ES TANCA EL FORMULARI 
         **/
        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llistaEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void llistatUsuarisToolStripAdministradors_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }

        private void afegirUsuariToolStripAdministrador_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministrador();
        }

        private void toolStripButtonUsuaris_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormAdministradors();
        }
    }
}
