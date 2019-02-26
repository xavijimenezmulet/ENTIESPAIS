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
         * ENS RETORNA LA SELECT AMB TOTES LES COMPETICIONS.
         **/
        public static List<COMPETICIONS> SelectAllCompeticions()
        {
            List<COMPETICIONS> _competicions =
                 (from comp in GeneralORM.bd.COMPETICIONS
                  orderby comp.nom
                  select comp).ToList();

            return _competicions;
        }
    }
}
