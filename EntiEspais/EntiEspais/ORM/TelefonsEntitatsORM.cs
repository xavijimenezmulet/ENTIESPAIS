using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class TelefonsEntitatsORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS ELS TELEFONS 
        **/
        public static List<TELEFONS_ENTITATS> SelectAllTelefons()
        {
            List<TELEFONS_ENTITATS> _telefons =
                 (from a in GeneralORM.bd.TELEFONS_ENTITATS
                  orderby a.id
                  select a).ToList();

            return _telefons;

        }

        /**
         * ENS ACTUALITZA UN TELÈFON DE LA BASE DE DADES 
         **/
        public static String UpdateTelefon(TELEFONS_ENTITATS telefon)
        {
            String missatgeError = "";
            TELEFONS_ENTITATS a = GeneralORM.bd.TELEFONS_ENTITATS.Find(telefon.id);

            a.numero = telefon.numero;
            a.id_entitat = telefon.id_entitat;
            a.temporada_entitat = telefon.temporada_entitat;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN TELÈFON NOU
         **/
        public static String InsertTelefon(TELEFONS_ENTITATS telefon)
        {
            String missatgeError = "";
            
            GeneralORM.bd.TELEFONS_ENTITATS.Add(telefon);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN TELÈFON DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByTelefon(TELEFONS_ENTITATS telefon)
        {
            String missatgeError = "";

            GeneralORM.bd.TELEFONS_ENTITATS.Remove(telefon);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
        /**
        * ENS RETORNA LA SELECT AMB ELS TELEFONS D'UNA ENTITAT
        **/
        public static List<TELEFONS_ENTITATS> SelectTelefonsEntitat(ENTITATS entitat)
        {
            int id = entitat.id;
            string temporada = entitat.temporada;
            List<TELEFONS_ENTITATS> _telefons =
                 (from a in GeneralORM.bd.TELEFONS_ENTITATS
                  orderby a.id
                  where a.id_entitat.Equals(id) && a.temporada_entitat.Equals(temporada)
                  select a).ToList();

            return _telefons;

        }
        /**
        * ENS RETORNA LA SELECT AMB UN TELEFON PER ID
        **/
        public static List<TELEFONS_ENTITATS> SelectTelefonsById(int id)
        {
            List<TELEFONS_ENTITATS> _telefons =
                 (from a in GeneralORM.bd.TELEFONS_ENTITATS
                  orderby a.id
                  where a.id.Equals(id)
                  select a).ToList();

            return _telefons;

        }
    }
}
