using EntiEspais.Formularis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * CLASS OBRIDOR FORMULARI (ENS SERVEIX PER REUTILITZAR CODI A LA HORA D'OBRIR QUALSEVOL FORMULARI)
 **/
namespace EntiEspais.Classes
{
    public static class ObridorFormulari
    {
        #region FORMULARIOS XAVI

        // ens obre un formulari login
        public static void obrirFormLogin()
        {
            FormLogin fLogin = new FormLogin();
            fLogin.ShowDialog();
        }

        //ens obre un formulari principal
        public static void obrirFormPrincipal()
        {
            FormPrincipal fPrincial = new FormPrincipal();
            fPrincial.ShowDialog();
        }

        //ens obre un formulari administradors
        public static void obrirFormAdministradors()
        {
            FormAdministradors fAdministradors = new FormAdministradors();
            fAdministradors.ShowDialog();
        }

        //ens obre un formulari administrador
        public static void obrirFormAdministrador()
        {
            FormAdministrador fAdministradors = new FormAdministrador();
            fAdministradors.ShowDialog();
        }

        //ens obre un formulari administrador per modificar
        public static void obrirFormAdministradorModificar(ADMINISTRADORS administrador)
        {
            FormAdministrador fAdministradors = new FormAdministrador(administrador);
            fAdministradors.ShowDialog();
        }

        //ens obre un formulari esports
        public static void obrirFormEsports()
        {
            FormEsports fEsports = new FormEsports();
            fEsports.ShowDialog();
        }

        //ens obre un formulari esport
        public static void obrirFormEsport()
        {
            FormEsport fEsport = new FormEsport();
            fEsport.ShowDialog();
        }

        //ens obre un formulari sexes
        public static void obrirFormSexes()
        {
            FormSexes fSexes = new FormSexes();
            fSexes.ShowDialog();
        }

        //ens obre un formulari sexe
        public static void obrirFormSexe()
        {
            FormSexe fSexe = new FormSexe();
            fSexe.ShowDialog();
        }

        //ens obre un formulari Categoria Edats
        public static void obrirFormCategoriaEdats()
        {
            FormCategoriaEdats fCategoriaEdats = new FormCategoriaEdats();
            fCategoriaEdats.ShowDialog();
        }

        //ens obre un formulari Categoria Edat
        public static void obrirFormCategoriaEdat()
        {
            FormCategoriaEdat fCategoriaEdat = new FormCategoriaEdat();
            fCategoriaEdat.ShowDialog();
        }

        //ens obre un formulari Categoria Equips
        public static void obrirFormCategoriaEquips()
        {
            FormCategoriaEquips fCategoriaEquips = new FormCategoriaEquips();
            fCategoriaEquips.ShowDialog();
        }

        //ens obre un formulari Categoria Equip
        public static void obrirFormCategoriaEquip()
        {
            FormCategoriaEquip fCategoriaEquip = new FormCategoriaEquip();
            fCategoriaEquip.ShowDialog();
        }

        //ens obre un formulari Competicions
        public static void obrirFormCompeticions()
        {
            FormCompeticions fCompeticions = new FormCompeticions();
            fCompeticions.ShowDialog();
        }

        //ens obre un formulari Competicio
        public static void obrirFormCompeticio()
        {
            FormCompeticio fCompeticio = new FormCompeticio();
            fCompeticio.ShowDialog();
        }

        //ens obre un formulari Telefons Entitats
        public static void obrirFormTelefonsEntitats()
        {
            FormTelefonsEntitats fTelefonsEntitats = new FormTelefonsEntitats();
            fTelefonsEntitats.ShowDialog();
        }

        //ens obre un formulari Telefon Entitat
        public static void obrirFormTelefonEntitat()
        {
            FormTelefonEntitat fTelefonEntitat = new FormTelefonEntitat();
            fTelefonEntitat.ShowDialog();
        }

        //ens obre un formulari Telefons Instalacions
        public static void obrirFormTelefonsInstalacions()
        {
            FormTelefonsInstalacions fTelefonsInstalacions = new FormTelefonsInstalacions();
            fTelefonsInstalacions.ShowDialog();
        }

        //ens obre un formulari Telefon Instalacio
        public static void obrirFormTelefonInstalacio()
        {
            FormTelefonInstalacio fTelefonInstalacio = new FormTelefonInstalacio();
            fTelefonInstalacio.ShowDialog();
        }

        //ens obre un formulari Faqs Android
        public static void obrirFormFaqsAndroid()
        {
            FormFaqsAndroid fFaqsAndroid = new FormFaqsAndroid();
            fFaqsAndroid.ShowDialog();
        }

        //ens obre un formulari Faq Android
        public static void obrirFormFaqAndroid()
        {
            FormFaqAndroid fFaqAndroid = new FormFaqAndroid();
            fFaqAndroid.ShowDialog();
        }

        #endregion

        #region FORMULARIOS DAVID

        //ens obre un formulari amb les Instalacions
        public static void obrirFormInstalacions()
        {
            FormInstalacions formInstalacions = new FormInstalacions();
            formInstalacions.ShowDialog();
        }

        //ens obre un formulari per donar d'alta una instalació
        public static void obrirFormInstalacioAlta()
        {
            FormInstalacioAlta formInstalacioAlta = new FormInstalacioAlta();
            formInstalacioAlta.ShowDialog();
        }

        //ens obre un formulari per modificar una instalació
        public static void obrirFormInstalacioModificar(INSTALACIONS _instalacio)
        {
            FormInstalacioAlta formInstalacioAlta = new FormInstalacioAlta(_instalacio);
            formInstalacioAlta.Text = "MODIFICAR INSTALACIÓ";
            formInstalacioAlta.ShowDialog();
        }

        //ens obre un formulari amb els espais de la instalació
        public static void obrirFormEspais(INSTALACIONS _instalacio)
        {
            FormEspais formEspais = new FormEspais(_instalacio);
            formEspais.ShowDialog();
        }

        //ens obre un formulari per donar d'alta un espai
        public static void obrirFormEspaisAlta(int id_instalacio)
        {
            FormEspaiAlta formEspaiAlta = new FormEspaiAlta(id_instalacio);
            formEspaiAlta.ShowDialog();
        }

        //ens obre un formulari per modificar un espai
        public static void obrirFormEspaisModificar(ESPAIS _espais)
        {
            FormEspaiAlta formEspaiAlta = new FormEspaiAlta(_espais);
            formEspaiAlta.Text = "MODIFICAR ESPAI";
            formEspaiAlta.ShowDialog();
        }

        //ens obre un formulari amb tots els espais
        public static void obrirFormEspaisTots()
        {
            FormEspaisTodos formEspaisTodos = new FormEspaisTodos();
            formEspaisTodos.ShowDialog();
        }

        #endregion

    }
}
