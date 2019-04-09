using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        /**
        * BORREM UNA ACTIVITAT
        **/
        public static String DeleteActivitat(ACTIVITATS activitat)
        {
            string mensaje = "";

            GeneralORM.bd.ACTIVITATS.Remove(activitat);
            try
            {
                mensaje = GeneralORM.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = GeneralORM.MissatgesError(sqlEx);
            }
            return mensaje;
        }
        /**
        * ENS RETORNA LA SELECT AMB TOTES LES ACTIVITATS
        **/
        public static List<ACTIVITATS> SelectActivitatsById(int id)
        {
            List<ACTIVITATS> _acts =
                 (from a in GeneralORM.bd.ACTIVITATS
                  orderby a.id
                  where a.id.Equals(id)
                  select a).ToList();

            return _acts;
        }
    }
}
