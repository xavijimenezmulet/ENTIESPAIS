using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class TelefonsInstalacionsORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS ELS TELEFONS 
        **/
        public static List<TELEFONS_INSTALACIONS> SelectAllTelefons()
        {
            List<TELEFONS_INSTALACIONS> _telefons =
                 (from a in GeneralORM.bd.TELEFONS_INSTALACIONS
                  orderby a.id
                  select a).ToList();

            return _telefons;

        }

        /**
         * ENS ACTUALITZA UN TELÈFON DE LA BASE DE DADES 
         **/
        public static String UpdateTelefon(TELEFONS_INSTALACIONS telefon)
        {
            String missatgeError = "";
            TELEFONS_INSTALACIONS a = GeneralORM.bd.TELEFONS_INSTALACIONS.Find(telefon.id);

            a.telefon = telefon.telefon;
            a.id_instalacio = telefon.id_instalacio;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN TELÈFON NOU
         **/
        public static String InsertTelefon(TELEFONS_INSTALACIONS telefon)
        {
            String missatgeError = "";

            GeneralORM.bd.TELEFONS_INSTALACIONS.Add(telefon);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN TELÈFON DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByTelefon(TELEFONS_INSTALACIONS telefon)
        {
            String missatgeError = "";

            GeneralORM.bd.TELEFONS_INSTALACIONS.Remove(telefon);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
