using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EntiEspais.Formularis
{
    public partial class FormInstalacioAlta : Form
    {
        INSTALACIONS _instalacio;
        bool modificar = false;

        GMarkerGoogle markerGoogle;
        GMapOverlay markerOverlay;
        double latInicial = 41.389129;
        double lonInicial = 2.173028;

        public FormInstalacioAlta()
        {
            InitializeComponent();
        }

        public FormInstalacioAlta(INSTALACIONS _instalacio)
        {
            InitializeComponent();
            this._instalacio = _instalacio;
            modificar = true;
        }

        //Load para cargar datos en caso de que sea para modificar
        private void FormInstalacioAlta_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                textBoxNom.Text = _instalacio.nom;
                textBoxContrasenya.Text = _instalacio.contrasenya;
                textBoxAdresa.Text = _instalacio.adresa;
                comboBoxTipus.SelectedItem = _instalacio.tipus;
                textBoxEmail.Text = _instalacio.email;
                textBoxRutaImatge.Text = _instalacio.ruta_imagen;
                textBoxAltitud.Text = _instalacio.altitut.ToString();
                textBoxLatitud.Text = _instalacio.latitut.ToString();
            }

            gestionMapa();
        }

        //Añadir una instalación o modificarla
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Añadir
            if (!modificar)
            {
                String mensaje = ORM.InstalacionsORM.altaInstalacio(textBoxNom.Text, textBoxContrasenya.Text, textBoxAdresa.Text,
                     comboBoxTipus.Text, textBoxEmail.Text, textBoxRutaImatge.Text, float.Parse(textBoxAltitud.Text), float.Parse(textBoxLatitud.Text));

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("AGREGAT");
                }
            }
            //Modificar
            else
            {
                String mensaje = ORM.InstalacionsORM.modificarinstalacio(_instalacio.id, textBoxNom.Text, textBoxContrasenya.Text, textBoxAdresa.Text,
                     comboBoxTipus.Text, textBoxEmail.Text, textBoxRutaImatge.Text, float.Parse(textBoxAltitud.Text), float.Parse(textBoxLatitud.Text));

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("MODIFICAT");
                }
            }

            this.Close();
        }

        //Botón cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Buscar la ruta de la imagen
        private void buttonRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRutaImatge.Text = openFileDialog.FileName;
            }
        }

        //Gestión mapa
        private void gestionMapa()
        {
            GMapControl gcontrol = new GMapControl();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true; //Permite hacer drag
            gMapControl1.MapProvider = GoogleMapProvider.Instance; //Usar google maps
            gMapControl1.MaxZoom = 20;
            gMapControl1.MinZoom = 0;
            gMapControl1.ShowCenter = false;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;


            gcontrol.SetPositionByKeywords("address");
            gMapControl1.Position = gcontrol.Position;


            if(!modificar)
            {
                gMapControl1.Position = new PointLatLng(41.389129, 2.173028);

                //Marcador
                markerOverlay = new GMapOverlay("Marcador");
                markerGoogle = new GMarkerGoogle(new PointLatLng(latInicial, lonInicial), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(markerGoogle);

                //Agregar mapa y marcador al MapControl
                gMapControl1.Overlays.Add(markerOverlay);
            }
            else
            {
                gMapControl1.Position = new PointLatLng(_instalacio.latitut, _instalacio.altitut);

                //Marcador
                markerOverlay = new GMapOverlay("Marcador");
                markerGoogle = new GMarkerGoogle(new PointLatLng(_instalacio.latitut, _instalacio.altitut), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(markerGoogle);

                //Agregar mapa y marcador al MapControl
                gMapControl1.Overlays.Add(markerOverlay);
            }

        }

        //Doble click sobre el mapa
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var p = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            double lat = 41.389129;
            double lon = 2.173028;

            String dir = "Barcelona";
            //gMapControl1.GetPositionByKeywords(dir, p);

            //Obtenemos los datos de lat y lon del mapa donde el usuario presionó
            var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            //double lat = point.Lat;
            //double lon = point.Lng;

            //Rellenar TextBox con coordenadas
            textBoxLatitud.Text = lat.ToString();
            textBoxAltitud.Text = lon.ToString();

            //Mover marker a la posición
            markerGoogle.Position = new PointLatLng(lat, lon);

            //Tomar dirección
            /*
             var adresses = GetAddress(point);

            if (adresses != null)
            {
                textBoxAdresa.Text = adresses[0];
            }
            else
            {
                textBoxAdresa.Text = "No se ha podido tomar la dirección";
            }
            */

        }

        //Tomar localización
        private List<String> GetAddress(PointLatLng point)
        {
        

      
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point,out placemarks);
            List<String> adresses = null;

            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                adresses = new List<string>();
                foreach (var placemark in placemarks)
                {
                    adresses.Add(placemark.Address);
                }

            }
            return adresses;
        }

        //Request 
    }
}
