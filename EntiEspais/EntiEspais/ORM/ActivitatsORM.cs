using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    class ActivitatsORM
    {
        /**
        * ENS RETORNA LA SELECT AMB TOTES LES ACTIVITATS
        **/
        public static List<ACTIVITATS> SelectAllActivitats()
        {
            List<ACTIVITATS> _acts =
                 (from a in GeneralORM.bd.ACTIVITATS
                  orderby a.id
                  select a).ToList();

            return _acts;
        }

        /**
        * INSERTEM UNA ACTIVITAT
        **/
        public static String InsertActivitat(ACTIVITATS activitat)
        {
            string mensaje = "";

            GeneralORM.bd.ACTIVITATS.Add(activitat);

            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }
    }
}
