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
        /**
          * MODIFIQUEM UNA DEMANDA
          **/
        public static String UpdateAssignarDemanda(DEMANDA_ACT demanda)
        {
            String missatgeError = "";
            DEMANDA_ACT d = GeneralORM.bd.DEMANDA_ACT.Find(demanda.id);

            d.id = demanda.id;
            d.nom = demanda.nom;
            d.num_dies = demanda.num_dies;
            d.duracio = demanda.duracio;
            d.num_dies = demanda.num_dies;
            d.es_asignada = demanda.es_asignada;
            d.id_equip = demanda.id_equip;
            d.id_espai = demanda.id_espai;
            d.id_interval_hores = demanda.id_interval_hores;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }
    }
}
