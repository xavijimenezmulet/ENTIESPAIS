using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    class DemandaActORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES DEMANDAS D'ACTIVITATS
         **/
        public static List<DEMANDA_ACT> SelectAllDemandaAct()
        {
            List<DEMANDA_ACT> _demandasAct =
                 (from d in GeneralORM.bd.DEMANDA_ACT
                  orderby d.id
                  select d).ToList();

            return _demandasAct;
        }
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES DEMANDAS D'ACTIVITATS JA ASSIGNADES
         **/
        public static List<DEMANDA_ACT> SelectAllDemandaActAssignades()
        {
            List<DEMANDA_ACT> _demandasAct =
                 (from d in GeneralORM.bd.DEMANDA_ACT
                  orderby d.id
                  where d.es_asignada == true
                  select d).ToList();

            return _demandasAct;
        }
    }
}
