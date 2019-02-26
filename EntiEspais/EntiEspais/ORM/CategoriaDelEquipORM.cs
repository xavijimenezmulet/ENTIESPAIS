using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class CategoriaDelEquipORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES CATEGORIES D'EQUIPS.
         **/
        public static List<CATEGORIA_EQUIP> SelectAllCategoriesEquips()
        {
            List<CATEGORIA_EQUIP> _categoriaEquips =
                 (from cat in GeneralORM.bd.CATEGORIA_EQUIP
                  orderby cat.nom
                  select cat).ToList();

            return _categoriaEquips;
        }
    }
}
