using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class FaqsAndroidORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTS ELS FAQS 
        **/
        public static List<FAQS> SelectAllFaqs()
        {
            List<FAQS> _faqs =
                 (from a in GeneralORM.bd.FAQS
                  orderby a.id
                  select a).ToList();

            return _faqs;

        }

        /**
         * ENS ACTUALITZA UN FAQ DE LA BASE DE DADES 
         **/
        public static String UpdateFaq(FAQS faq)
        {
            String missatgeError = "";
            FAQS a = GeneralORM.bd.FAQS.Find(faq.id);

            a.pregunta = faq.pregunta;
            a.descripcion = faq.descripcion;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN FAQ NOU
         **/
        public static String InsertFaq(FAQS faq)
        {
            String missatgeError = "";

            GeneralORM.bd.FAQS.Add(faq);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN FAQ DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByFaq(FAQS faq)
        {
            String missatgeError = "";

            GeneralORM.bd.FAQS.Remove(faq);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
