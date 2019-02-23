using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public class InstalacionsORM
    {
        //Retorna el SELECT amb totes les instalacions
        public static List<INSTALACIONS> SelectInstalacions()
        {
            List<INSTALACIONS> _instalacions =
                 (from e in GeneralORM.bd.INSTALACIONS
                  orderby e.id
                  select e).ToList();

            return _instalacions;

        }
    }
}
