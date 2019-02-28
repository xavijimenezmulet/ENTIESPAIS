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
                  select  a).Distinct().ToList();

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
    }
}
