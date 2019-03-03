using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class DiesSemanaORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS ELS DIES DE LA SEMANA 
        **/
        public static List<DIA_SEMANA> SelectAllDiesSemana()
        {
            List<DIA_SEMANA> _diesSemana =
                 (from a in GeneralORM.bd.DIA_SEMANA
                  orderby a.id
                  select a).ToList();

            return _diesSemana;

        }

        /**
         * ENS ACTUALITZA UN DIA DE LA BASE DE DADES 
         **/
        public static String UpdateDia(DIA_SEMANA dia)
        {
            String missatgeError = "";
            DIA_SEMANA a = GeneralORM.bd.DIA_SEMANA.Find(dia.id);

            a.nom = dia.nom;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN DIA NOU
         **/
        public static String InsertDia(DIA_SEMANA dia)
        {
            String missatgeError = "";

            GeneralORM.bd.DIA_SEMANA.Add(dia);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN DIA DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByDia(DIA_SEMANA dia)
        {
            String missatgeError = "";

            GeneralORM.bd.DIA_SEMANA.Remove(dia);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
