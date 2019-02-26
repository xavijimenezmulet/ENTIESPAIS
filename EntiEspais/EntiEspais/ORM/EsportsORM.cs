using System.Collections.Generic;
using System.Linq;

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
    }
}
