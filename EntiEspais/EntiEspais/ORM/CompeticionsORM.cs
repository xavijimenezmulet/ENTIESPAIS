using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class CompeticionsORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTES LES COMPETICIONS 
        **/
        public static List<COMPETICIONS> SelectAllCompeticions()
        {
            List<COMPETICIONS> _competicions =
                 (from a in GeneralORM.bd.COMPETICIONS
                  orderby a.nom
                  select a).ToList();

            return _competicions;

        }

        /**
         * ENS ACTUALITZA UNA COMPETICIÓ DE LA BASE DE DADES 
         **/
        public static String UpdateCompeticio(COMPETICIONS competicio)
        {
            String missatgeError = "";
            COMPETICIONS a = GeneralORM.bd.COMPETICIONS.Find(competicio.id);

            a.nom = competicio.nom;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UNA COMPETICIÓ NOVA
         **/
        public static String InsertCompeticio(COMPETICIONS competicio)
        {
            String missatgeError = "";

            GeneralORM.bd.COMPETICIONS.Add(competicio);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UNA COMPETICIÓ DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByCompeticio(COMPETICIONS competicio)
        {
            String missatgeError = "";

            GeneralORM.bd.COMPETICIONS.Remove(competicio);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
