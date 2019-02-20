using BlowFishCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/**
 * CLASSE UTILTIATS (ENS SERVIRÀ PER UTILITZAR MÈTODES DE LA CLASSE PER REUTILITZAR CODI
 **/
namespace EntiEspais.Classes
{
    public static class Utilitats
    {
        /**
         * ENS SERVEIX PER FICAR LA HORA A LA LABEL DEL MENU
         **/
        public static String ponerHoraMenu()
        {
            String hora = DateTime.Now.ToString("H:mm") + " " + DateTime.Now.ToLongDateString();

            return hora;
        }

        /**
         * ENS RETORNA SI UN EMAIL ÉS CORRECTE O NO
         **/
        public static Boolean isAnEmail(String email)
        {
            Boolean verdader = false;
            String expresio;
            expresio = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresio))
            {
                if (Regex.Replace(email, expresio, String.Empty).Length == 0)
                {
                    verdader  = true;
                }
                else
                {
                    verdader = false;
                }
            }
            else
            {
                verdader = false;
            }

            return verdader;
        }

        public static Boolean desencriptarContrassenya(String contrassenya, String contrassenyaComparar)
        {
            Boolean verdader = false;
            BlowFish b = new BlowFish("04B915BA43FEB5B6");
            String c = b.Decrypt_CBC(contrassenya);
            if (c.Equals(contrassenyaComparar))
            {
                verdader = true;
            }

            return verdader;

        }
    }
}
