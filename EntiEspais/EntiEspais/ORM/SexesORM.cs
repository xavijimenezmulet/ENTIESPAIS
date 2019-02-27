using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class SexesORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS ELS SEXES 
        **/
        public static List<SEXE> SelectAllSexes()
        {
            List<SEXE> _sexes =
                 (from a in GeneralORM.bd.SEXE
                  orderby a.tipus
                  select a).ToList();

            return _sexes;

        }

        /**
         * ENS ACTUALITZA UN SEXE DE LA BASE DE DADES 
         **/
        public static String UpdateSexe(SEXE sexe)
        {
            String missatgeError = "";
            SEXE a = GeneralORM.bd.SEXE.Find(sexe.id);

            a.tipus = sexe.tipus;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN SEXE NOU
         **/
        public static String InsertSexe(SEXE sexe)
        {
            String missatgeError = "";

            GeneralORM.bd.SEXE.Add(sexe);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN SEXE DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteBySexe(SEXE sexe)
        {
            String missatgeError = "";

            GeneralORM.bd.SEXE.Remove(sexe);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
