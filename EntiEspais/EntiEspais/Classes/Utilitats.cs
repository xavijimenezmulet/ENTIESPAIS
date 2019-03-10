﻿using BlowFishCS;
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
        public static int intervalsHores = 96;
        public static ADMINISTRADORS adminActual;
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
         * METODE PER OMPLIR DIES I HORES AL CALENDARI 
         **/
        public static string[,] horesYdiesCalendari()
        {
            string[,] rows = new string[Utilitats.intervalsHores, 9];
            List<HORES> horari = HoresORM.SelectHoresPrimaries(111);
            for (int i = 0; i < Utilitats.intervalsHores; i++)
            {
                rows[i, 0] = horari[i].inici.ToString();
                rows[i, 1] = horari[i].fi.ToString();

            }
            return rows;
        }

        /**
        *METODE PER OMPLIR EQUIPS ASSIGNATS AL CALENDARI 
        **/
        public static string[,] omplirMatriuCalendari(ESPAIS espai)
        {
            string[,] rows = horesYdiesCalendari();

            List<DEMANDA_ACT> demandesAssignades = DemandaActORM.SelectAllDemandaActAssignades();
            for (int k = 0; k < demandesAssignades.Count; k++)
            {
                if (demandesAssignades[k].id_espai == espai.id)
                {
                    EQUIPS equipDemanda = EquipsORM.SelectAllEquipByid(demandesAssignades[k].id_equip).First();
                    foreach (DIA_SEMANA dia in demandesAssignades[k].DIA_SEMANA)
                    {
                        List<int> intervals = Utilitats.comparaHores(demandesAssignades[k].id_interval_hores);
                        for (int m = 0; m < intervals.Count; m++)
                        {
                            rows[intervals[m], dia.id + 1] = equipDemanda.nom;
                        }
                    }
                }
            }
            return rows;
        }

        /**
         *METODE PER TROBAR CELA DEL CALENDARI 
         **/
        public static int trobarCela(string[,] rows, string hora)
        {
            int fila = 0;
            List<String> llistaHores = new List<string>();
            for (int i = 0; i < intervalsHores; i++)
            {
                llistaHores.Add(rows[i, 0]);
            }

            for (int i = 0; i < intervalsHores; i++)
            {
                if(llistaHores[i] == hora)
                {
                    fila = i;
                }
            }
            return fila;
        }

        /**
         *METODE PER COMPROBAR SI L'ESPAI ESTA OCUPAT EN LES HORES D'UNA DEMANDA
         **/
         public static bool comprobarHoresEspai(DEMANDA_ACT demanda, string[,] rows)
        {
            bool ocupat = false;
            
            EQUIPS equipDemanda = EquipsORM.SelectAllEquipByid(demanda.id_equip).First();
            foreach (DIA_SEMANA dia in demanda.DIA_SEMANA)
            {
                List<int> intervals = Utilitats.comparaHores(demanda.id_interval_hores);
                for (int i = 0; i < intervals.Count; i++)
                {
                    if (rows[intervals[i], dia.id + 1] != null)
                    {
                        ocupat = true;
                    }
                }
            }
            return ocupat;
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
            int idFi = HoresORM.SelectHoresByHfinal(hFi).First().id;
            for(int i = idInici; i <= idFi; i++)
            {
                hores.Add(i-15);
            }
            return hores;
        }
        /**
        *METODE PER COMPARAR INTERVALS D'HORES EXCLUIDES
        **/
        public static List<int> comparaHoresExcluides(int idIntervalHores)
        {
            List<int> hores = comparaHores(idIntervalHores);

            List<int> horesExcluides = new List<int>();

            for(int i = 0; i < intervalsHores; i++)
            {
                horesExcluides.Add(i);
            }
            horesExcluides.RemoveRange(hores[0], hores.Count);
            return horesExcluides;
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
