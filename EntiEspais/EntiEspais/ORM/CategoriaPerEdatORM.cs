using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class CategoriaPerEdatORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES CATEGORIES PER EDAT
         **/
        public static List<CATEGORIA_EDAT> SelectAllCategoriesPerEdat()
        {
            List<CATEGORIA_EDAT> _categoriaEdats =
                 (from a in GeneralORM.bd.CATEGORIA_EDAT
                  orderby a.nom
                  select a).ToList();

            return _categoriaEdats;

        }
    }
}
