using System.Collections.Generic;
using System.Linq;
using System;

namespace EntiEspais.ORM
{
    public static class EsportsORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTS ELS ESPORTS.
         **/
        public static List<ESPORTS> SelectAllEsports()
        {
            List<ESPORTS> _esports =
                 (from esp in GeneralORM.bd.ESPORTS
                  orderby esp.nom
                  select esp).ToList();

            return _esports;
        }

        /**
         * ENS ACTUALITZA UN ESPORT DE LA BASE DE DADES 
         **/
        public static String UpdateEsport(ESPORTS esport)
        {
            String missatgeError = "";
            ESPORTS a = GeneralORM.bd.ESPORTS.Find(esport.id);

            a.nom = esport.nom;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN ESPORT NOU
         **/
        public static String InsertEsport(ESPORTS esport)
        {
            String missatgeError = "";

            GeneralORM.bd.ESPORTS.Add(esport);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN ESPORT DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByEsport(ESPORTS esport)
        {
            String missatgeError = "";

            GeneralORM.bd.ESPORTS.Remove(esport);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

    }
}
