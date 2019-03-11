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
        GMapControl gcontrol;
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
            else
            {
                bindingSourceDillunsInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDillunsFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDimartsInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDimartsFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDimecresInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDimecresFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDijousInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDijousFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDivendresInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDivendresFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDissabteInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDissabteFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();
                bindingSourceDiumengeInici.DataSource = ORM.HoresORM.SelectIntervalHores();
                bindingSourceDiumengeFinal.DataSource = ORM.HoresORM.SelectIntervalHoresFi();

            }

            gestionMapa();
        }

        //Añadir una instalación o modificarla
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Comprobar que la hora final no sea menor que la hora inicial
            bool error = comprobarIntervaloHoras();
            int id_instalacion = 0;

            if (!error)
            {
                //Añadir intervalo horas en caso que no existan
                List<int> idHoras = anadirIntervaloHoras();

                //Añadir
                if (!modificar)
                {

                    String mensaje = ORM.InstalacionsORM.altaInstalacio(textBoxNom.Text, textBoxContrasenya.Text, textBoxAdresa.Text,
                         comboBoxTipus.Text, textBoxEmail.Text, textBoxRutaImatge.Text, float.Parse(textBoxAltitud.Text), float.Parse(textBoxLatitud.Text), ref id_instalacion);

                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje, "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("AGREGAT");
                    }

                    //Añadir HORARIO_INSTALACION lunes
                    String lunes = ORM.HorariInstalacio.insertHorariInstalacio(1, idHoras[0], id_instalacion);

                    //Añadir HORARIO_INSTALACION martes
                    String martes = ORM.HorariInstalacio.insertHorariInstalacio(2, idHoras[1], id_instalacion);

                    //Añadir HORARIO_INSTALACION miercoles
                    String miercoles = ORM.HorariInstalacio.insertHorariInstalacio(3, idHoras[2], id_instalacion);

                    //Añadir HORARIO_INSTALACION jueves
                    String jueves = ORM.HorariInstalacio.insertHorariInstalacio(4, idHoras[3], id_instalacion);

                    //Añadir HORARIO_INSTALACION viernes
                    String viernes = ORM.HorariInstalacio.insertHorariInstalacio(5, idHoras[4], id_instalacion);

                    //Añadir HORARIO_INSTALACION sabado
                    String sabado = ORM.HorariInstalacio.insertHorariInstalacio(6, idHoras[5], id_instalacion);

                    //Añadir HORARIO_INSTALACION domingo
                    String domingo = ORM.HorariInstalacio.insertHorariInstalacio(7, idHoras[6], id_instalacion);

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

                    //Modificar HORARIO_INSTALACION lunes
                    String lunes = ORM.HorariInstalacio.modificarHorariInstalacio(1, idHoras[0], _instalacio.id);

                    //Modificar HORARIO_INSTALACION martes
                    String martes = ORM.HorariInstalacio.modificarHorariInstalacio(2, idHoras[1], _instalacio.id);

                    //Modificar HORARIO_INSTALACION miercoles
                    String miercoles = ORM.HorariInstalacio.modificarHorariInstalacio(3, idHoras[2], _instalacio.id);

                    //Modificar HORARIO_INSTALACION jueves
                    String jueves = ORM.HorariInstalacio.modificarHorariInstalacio(4, idHoras[3], _instalacio.id);

                    //Modificar HORARIO_INSTALACION viernes
                    String viernes = ORM.HorariInstalacio.modificarHorariInstalacio(5, idHoras[4], _instalacio.id);

                    //Modificar HORARIO_INSTALACION sabado
                    String sabado = ORM.HorariInstalacio.modificarHorariInstalacio(6, idHoras[5], _instalacio.id);

                    //Modificar HORARIO_INSTALACION domingo
                    String domingo = ORM.HorariInstalacio.modificarHorariInstalacio(7, idHoras[6], _instalacio.id);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Comprueba el intervalo de horas introducidas", "ACCIÓ CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Comprobar intervalo horas
        private bool comprobarIntervaloHoras()
        {
            bool error = false;

            //Lunes
            if (TimeSpan.Parse(comboBoxDillunsInici.Text) > TimeSpan.Parse(comboBoxDillunsFinal.Text))
            {
                error = true;
            }

            //Martes
            if (TimeSpan.Parse(comboBoxDimartsInici.Text) > TimeSpan.Parse(comboBoxDimartsFinal.Text))
            {
                error = true;
            }

            //Miercoles
            if (TimeSpan.Parse(comboBoxDimecresInici.Text) > TimeSpan.Parse(comboBoxDimecresFinal.Text))
            {
                error = true;
            }

            //Jueves
            if (TimeSpan.Parse(comboBoxDijousInici.Text) > TimeSpan.Parse(comboBoxDijousFinal.Text))
            {
                error = true;
            }

            //Viernes
            if (TimeSpan.Parse(comboBoxDivendresInici.Text) > TimeSpan.Parse(comboBoxDivendresFinal.Text))
            {
                error = true;
            }

            //Sábado
            if (TimeSpan.Parse(comboBoxDissabteInici.Text) > TimeSpan.Parse(comboBoxDissabteFinal.Text))
            {
                error = true;
            }

            //Domingo
            if (TimeSpan.Parse(comboBoxDiumengeInici.Text) > TimeSpan.Parse(comboBoxDiumengeFinal.Text))
            {
                error = true;
            }

            return error;
        }

        //Añadir nuevo intervalo de horas
        private List<int> anadirIntervaloHoras()
        {
            List<int> ids = new List<int>();

            //Lunes
            if (comboBoxDillunsInici.SelectedValue != comboBoxDillunsFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDillunsInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDillunsFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDillunsInici.SelectedValue);
            }

            //Martes
            if (comboBoxDimartsInici.SelectedValue != comboBoxDimartsFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDimartsInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDimartsFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDimartsInici.SelectedValue);
            }

            //Miercoles
            if (comboBoxDimecresInici.SelectedValue != comboBoxDimecresFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDimecresInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDimecresFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDimecresInici.SelectedValue);
            }

            //Jueves
            if (comboBoxDijousInici.SelectedValue != comboBoxDijousFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDijousInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDijousFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDijousInici.SelectedValue);
            }

            //Viernes
            if (comboBoxDivendresInici.SelectedValue != comboBoxDivendresFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDivendresInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDivendresFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDivendresInici.SelectedValue);
            }

            //Sábado
            if (comboBoxDissabteInici.SelectedValue != comboBoxDissabteFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDissabteInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDissabteFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDissabteInici.SelectedValue);
            }

            //Domingo
            if (comboBoxDiumengeInici.SelectedValue != comboBoxDiumengeFinal.SelectedValue)
            {
                HORES hora = new HORES();
                hora.inici = TimeSpan.Parse(comboBoxDiumengeInici.Text);
                hora.fi = TimeSpan.Parse(comboBoxDiumengeFinal.Text);

                String msg = ORM.HoresORM.InsertHora(hora);
                ids.Add(hora.id);
            }
            else
            {
                ids.Add((int)comboBoxDiumengeInici.SelectedValue);
            }

            return ids;
        }

        #region DESACTIVAR

        //Desactivar Lunes
        private void buttonDeleteDilluns_Click(object sender, EventArgs e)
        {
            comboBoxDillunsInici.Enabled = !comboBoxDillunsInici.Enabled;
            comboBoxDillunsInici.SelectedValue = 14;

            comboBoxDillunsFinal.Enabled = !comboBoxDillunsFinal.Enabled;
            comboBoxDillunsFinal.SelectedValue = 14;

        }

        //Desactivar Martes
        private void buttonDeleteDimarts_Click(object sender, EventArgs e)
        {
            comboBoxDimartsInici.Enabled = !comboBoxDimartsInici.Enabled;
            comboBoxDimartsInici.SelectedValue = 14;

            comboBoxDimartsFinal.Enabled = !comboBoxDimartsFinal.Enabled;
            comboBoxDimartsFinal.SelectedValue = 14;
        }

        //Desactivar Miercoles
        private void buttonDeleteDimecres_Click(object sender, EventArgs e)
        {
            comboBoxDimecresInici.Enabled = !comboBoxDimecresInici.Enabled;
            comboBoxDimecresInici.SelectedValue = 14;

            comboBoxDimecresFinal.Enabled = !comboBoxDimecresFinal.Enabled;
            comboBoxDimecresFinal.SelectedValue = 14;
        }

        //Desactivar Jueves
        private void buttonDeleteDijous_Click(object sender, EventArgs e)
        {
            comboBoxDijousInici.Enabled = !comboBoxDijousInici.Enabled;
            comboBoxDijousInici.SelectedValue = 14;

            comboBoxDijousFinal.Enabled = !comboBoxDijousFinal.Enabled;
            comboBoxDijousFinal.SelectedValue = 14;
        }

        //Desactivar Viernes
        private void buttonDeleteDivendres_Click(object sender, EventArgs e)
        {
            comboBoxDivendresInici.Enabled = !comboBoxDivendresInici.Enabled;
            comboBoxDivendresInici.SelectedValue = 14;

            comboBoxDivendresFinal.Enabled = !comboBoxDivendresFinal.Enabled;
            comboBoxDivendresFinal.SelectedValue = 14;
        }

        //Desactivar Sabado
        private void buttonDeleteDissabte_Click(object sender, EventArgs e)
        {
            comboBoxDissabteInici.Enabled = !comboBoxDissabteInici.Enabled;
            comboBoxDissabteInici.SelectedValue = 14;

            comboBoxDissabteFinal.Enabled = !comboBoxDissabteFinal.Enabled;
            comboBoxDissabteFinal.SelectedValue = 14;
        }

        //Desactivar Domingo
        private void buttonDeleteDiumenge_Click(object sender, EventArgs e)
        {
            comboBoxDiumengeInici.Enabled = !comboBoxDiumengeInici.Enabled;
            comboBoxDiumengeInici.SelectedValue = 14;

            comboBoxDiumengeFinal.Enabled = !comboBoxDiumengeFinal.Enabled;
            comboBoxDiumengeFinal.SelectedValue = 14;
        }

        #endregion

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
            gcontrol = new GMapControl();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true; //Permite hacer drag
            //gMapControl1.MapProvider = GoogleMapProvider.Instance; //Usar google maps
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MaxZoom = 20;
            gMapControl1.MinZoom = 0;
            gMapControl1.ShowCenter = false;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            markerGoogle = new GMarkerGoogle(new PointLatLng(latInicial, lonInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(markerGoogle);


            textBoxLatitud.Text = latInicial.ToString();
            textBoxAltitud.Text = lonInicial.ToString();

            markerGoogle.Position = new PointLatLng(latInicial, lonInicial);

            if (!modificar)
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
            //Obtenemos los datos de lat y lon del mapa donde el usuario presionó
            var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            double lat = point.Lat;
            double lon = point.Lng;

            //Rellenar TextBox con coordenadas
            textBoxLatitud.Text = lat.ToString();
            textBoxAltitud.Text = lon.ToString();

            //Mover marker a la posición
            markerGoogle.Position = new PointLatLng(lat, lon);

            var dir = gcontrol.GetPositionByKeywords("hello",out point);

        }

        //Buscar
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Dirección mediante letras
            gcontrol.SetPositionByKeywords(textBoxAdresa.Text);
            gMapControl1.Position = gcontrol.Position;

            //Transformamos en lat y lng
            double lat = gcontrol.Position.Lat;
            double lng = gcontrol.Position.Lng;

            //Rellenar TextBox con coordenadas
            textBoxLatitud.Text = lat.ToString();
            textBoxAltitud.Text = lng.ToString();

            //Mover marker a la posición
            markerGoogle.Position = new PointLatLng(lat, lng);
        }
    }
}
