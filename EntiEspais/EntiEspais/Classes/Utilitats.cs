using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * CLASSE UTILTIATS (ENS SERVIRÀ PER UTILITZAR MÈTODES DE LA CLASSE PER REUTILITZAR CODI
 **/
namespace EntiEspais.Classes
{
    public static class Utilitats
    {
        public static String ponerHoraMenu()
        {
            String hora = DateTime.Now.ToString("H:mm") + " " + DateTime.Now.ToLongDateString();

            return hora;
        }
    }
}
