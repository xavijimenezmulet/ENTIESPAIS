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
    }
}
