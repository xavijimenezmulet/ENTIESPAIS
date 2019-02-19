using EntiEspais.Classes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * FORMULARI LOGIN (ON L'ADMINISTRADOR ES LOGEJA)
 **/
namespace EntiEspais
{
    public partial class FormLogin : Form
    {

        //CONSTRUCTORS
        public FormLogin()
        {
            InitializeComponent();
        }

        /**
         * RELLTGE PER LA HORA ACTUAL
         **/
        private void Reloj_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        /**
         * LOAD ON CARREGUEM EL CONTINGUT PER PRIMER COP
         **/
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Reloj.Start();
            pictureBox1.Select();
        }

        
        /**
         * ENS OBRA EL FORMULARI PRINCIPAL UN COP SIGUIN ACCEPTADES LES DADES
         **/
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ObridorFormulari.obrirFormPrincipal();
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals("Email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
                
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxContrassenya_Enter(object sender, EventArgs e)
        {
            if (textBoxContrassenya.Text.Equals("Contrassenya"))
            {
                textBoxContrassenya.Text = "";
                textBoxContrassenya.ForeColor = Color.Black;
                textBoxContrassenya.PasswordChar = '*';
                
            }
        }

        private void textBoxContrassenya_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContrassenya.Text))
            {
                textBoxContrassenya.PasswordChar = '\0';
                textBoxContrassenya.Text = "Contrassenya";
                textBoxContrassenya.ForeColor = Color.Gray;
            }
        }


        /**
         * MAPA LOAD EN CARREGA LA UBICACIÓ DEL AJUNTAMENT DE SANT CUGAT DEL VALLÈS
         **/
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(41.470774, 2.085289);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 17;



            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(41.470774, 2.085289), GMarkerGoogleType.red_dot);
            GMapOverlay markersOverlay = new GMapOverlay("markers");


            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);
        }
    }
}
