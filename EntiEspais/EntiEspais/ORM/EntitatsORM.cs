using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * ORM ENTITATS (ENS SERVIRÀ PER ACCEDIR A TOT L'HO RELACIONAT AMB ENTITATS A LA BASE DE DADES)
 **/
namespace EntiEspais.ORM
{
    public static class EntitatsORM
    {

        /**
         * ENS RETORNA LA SELECT AMB TOTES LES ENTITATS
         **/
        public static List<ENTITATS> SelectAllEntitiesByTemporadaActual(String temporada)
        {
            List<ENTITATS> _entitats =
                 (from e in GeneralORM.bd.ENTITATS
                  orderby e.nom
                  where e.temporada.Equals(temporada)
                  select e).ToList();

            return _entitats;

        }
    }
}
