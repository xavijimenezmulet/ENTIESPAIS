using BlowFishCS;
using EntiEspais.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
         * ENS ENCRIPTA LA CONTRASSENYA BÀSICA D'UN ADMINISTRADOR
         **/
        public static String encriptarContrassenyaAdmins()
        {
            
            BlowFish b = new BlowFish("04B915BA43FEB5B6");
            String c = b.Encrypt_CBC("administrador");
            

            return c;

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

        /**
         *METODE PER TENIR LA TEMPORADA ACTUAL 
         **/
        public static string tempActual()
        {
            string temp = "";
            int monthN = System.DateTime.Now.Month;
            int yearN = System.DateTime.Now.Year;
            

            if (monthN < 7)
            {
                temp = (yearN - 1) + "-" + yearN;
            }
            else
            {
                temp = yearN + "-" + (yearN + 1);
            }

            return temp;
        }

        public static List<DIA_SEMANA> diesDemanda(DEMANDA_ACT demanda)
        {
            List<DIA_SEMANA> diaAct = demanda.DIA_SEMANA.ToList();

            return diaAct;
        }
        /**
         *METODE PER COMPARAR INTERVALS D'HORES 
         **/
         public static List<int> comparaHores(int idIntervalHores)
        {
            List<int> hores = new List<int>();
            HORES interval = HoresORM.SelectHoresByid(idIntervalHores).First();
            TimeSpan hInici= interval.inici;
            TimeSpan hFi = interval.fi;
            int idInici = HoresORM.SelectHoresByHinici(hInici).First().id;
            int idFi = HoresORM.SelectHoresByHinici(hFi).First().id;
            for(int i = idInici; i <= idFi; i++)
            {
                hores.Add(i-15);
            }
            return hores;
        }



        /**
        *METODE PER BUSCAR L'ESPAI MES ÒPTIM PER UNA DEMANDA D'ACTIVITAT
        **/
        /*
        public static ESPAIS buscarEspai(DEMANDA_ACT demanda)
        {
            List<DIA_SEMANA> diaAct = demanda.DIA_SEMANA.ToList();
            //diaAct.;
            
            ESPAIS espai;
            List<int> dies = new List<int>();
            //List<DIA_SEMANA> dies = new List<DIA_SEMANA>();
            //dies.AddRange(demanda.DIA_SEMANA);
            for (int i = 0; i < demanda.DIA_SEMANA.Count; i++)
            {
                dies.Add(demanda.DIA_SEMANA.);
            }
            
            //Cridar metode SelectInstalacions i guardar a la llista
            List<INSTALACIONS> instalacions = new List<INSTALACIONS>();
            for (int i = 0; i < instalacions.Count; i++)
            {
                if(instalacions[i].HORARI_INSTALACIO.)
            }
    
            return espai;
        }*/
    }
}
