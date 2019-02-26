using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class SexeORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTS ELS SEXES.
         **/
        public static List<SEXE> SelectAllSexes()
        {
            List<SEXE> _sexes =
                 (from s in GeneralORM.bd.SEXE
                  orderby s.tipus
                  select s).ToList();

            return _sexes;
        }
    }
}
