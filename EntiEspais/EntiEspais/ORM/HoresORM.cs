using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class HoresORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS LES HORES DE LA SEMANA 
        **/
        public static List<HORES> SelectAllHores()
        {
            List<HORES> _hores =
                 (from a in GeneralORM.bd.HORES
                  orderby a.inici
                  select a).ToList();

            return _hores;

        }

        /**
       * ENS RETORNA LA SELECT AMB TOTS LES HORES DE LA SEMANA SENSE REPETIR LES HORES
       **/
        public static List<HORES> SelectIntervalHores()
        {
            List<HORES> _hores =
                 (from a in GeneralORM.bd.HORES
                  orderby a.inici
                  select a).Distinct().ToList();

            return _hores;

        }

        //Ens retorna la select amb totes les hores finals sense repetir
        public static List<HORES> SelectIntervalHoresFi()
        {
            List<HORES> _hores =
                 (from a in GeneralORM.bd.HORES
                  orderby a.fi
                  select a).Distinct().ToList();

            return _hores;

        }

        /**
         * ENS ACTUALITZA UNA HORA DE LA BASE DE DADES 
         **/
        public static String UpdateHora(HORES hora)
        {
            String missatgeError = "";
            HORES a = GeneralORM.bd.HORES.Find(hora.id);

            a.inici = hora.inici;
            a.fi = hora.fi;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UNA HORA NOVA
         **/
        public static String InsertHora(HORES hora)
        {
            String missatgeError = "";

            GeneralORM.bd.HORES.Add(hora);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UNA HORA DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByHora(HORES hora)
        {
            String missatgeError = "";

            GeneralORM.bd.HORES.Remove(hora);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
        /**
         * ENS RETORNA LA SELECT AMB L'HORA DONAT UN ID
         **/
        public static List<HORES> SelectHoresByid(int id)
        {
            List<HORES> _hores =
                 (from e in GeneralORM.bd.HORES
                  where e.id.Equals(id)
                  select e).ToList();

            return _hores;
        }
        /**
         * ENS RETORNA LA SELECT AMB L'HORA DONAT UNA HORA INICI
         **/
        public static List<HORES> SelectHoresByHinici(TimeSpan hInici)
        {
            List<HORES> _hores =
                 (from e in GeneralORM.bd.HORES
                  where e.inici.Equals(hInici)
                  select e).ToList();

            return _hores;
        }
        /**
         * ENS RETORNA LA SELECT AMB L'HORA DONAT UNA HORA FINAL
         **/
        public static List<HORES> SelectHoresByHfinal(TimeSpan hFi)
        {
            List<HORES> _hores =
                 (from e in GeneralORM.bd.HORES
                  where e.fi.Equals(hFi)
                  select e).ToList();

            return _hores;
        }
        /**
       * ENS RETORNA LA SELECT AMB ELS INTERVALS BASICS
       **/
        public static List<HORES> SelectHoresPrimaries(int id)
        {
            List<HORES> _hores =
                 (from e in GeneralORM.bd.HORES
                  where e.id < id
                  orderby e.id
                  select e).ToList();

            return _hores;
        }

        //Ens retorna l'id de quan la hora es 00:00:00
        public static int selectIdHores()
        {
            TimeSpan horaInicio = TimeSpan.Parse("00:00:00");
            TimeSpan horaFinal = TimeSpan.Parse("00:00:00");

            int id = (from e in GeneralORM.bd.HORES
                      where e.inici == horaInicio && e.fi == horaFinal
                      select e.id).First();

            return id;
        }
    }
}
