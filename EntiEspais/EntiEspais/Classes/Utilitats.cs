using BlowFishCS;
using EntiEspais.ORM;
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

        /**
         * ENS INTRODUEXI DE FORMA AUTOMATICA ELS INTERVALS DE HORES
         **/
        public static void InsertHores()
        {
            
            TimeSpan inici = new TimeSpan(0, 0, 0);
            TimeSpan final = new TimeSpan(0, 0, 0);
            HORES hores = new HORES();

            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 23)
                    {
                        if (j < 3)
                        {
                            inici = new TimeSpan(i, j * 15, 0);
                            final = new TimeSpan(i, (j * 15) + 15, 0);
                            hores.inici = inici;
                            hores.fi = final;
                            GeneralORM.InsertHoresInterval(hores);


                        }
                        else
                        {
                            inici = new TimeSpan(i, j * 15, 0);
                            final = new TimeSpan(i + 1, 0, 0);
                            hores.inici = inici;
                            hores.fi = final;
                            GeneralORM.InsertHoresInterval(hores);
                        }
                    }
                    else
                    {
                        if (j < 3)
                        {
                            inici = new TimeSpan(i, j * 15, 0);
                            final = new TimeSpan(i, (j * 15) + 15, 0);
                            hores.inici = inici;
                            hores.fi = final;
                            GeneralORM.InsertHoresInterval(hores);
                        }
                        else
                        {
                            inici = new TimeSpan(i, j * 15, 0);
                            final = new TimeSpan(0, 0, 0);
                            hores.inici = inici;
                            hores.fi = final;
                            GeneralORM.InsertHoresInterval(hores);
                        }
                    }

                }
            }
        }
    }
}
