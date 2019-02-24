using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public class EspaisORM
    {
        //Alta espai
        public static void altaEspai(String nom, float preu, bool tipus, int id_instalacio)
        {
            ESPAIS _espai = new ESPAIS();

            _espai.nom = nom;
            _espai.preu = preu;
            _espai.es_exterior = tipus;
            _espai.id_instalacio = id_instalacio;

            ORM.GeneralORM.bd.ESPAIS.Add(_espai);

            ORM.GeneralORM.bd.SaveChanges();
        }

        //Modificar espai
        public static void modificarEspai(int id, String nom, float preu, bool tipus)
        {
            ESPAIS _espai = ORM.GeneralORM.bd.ESPAIS.Find(id);

            _espai.nom = nom;
            _espai.preu = preu;
            _espai.es_exterior = tipus;

            ORM.GeneralORM.bd.SaveChanges();
        }

        //Eliminar espai
        public static void eliminarEspai(ESPAIS _espais)
        {
            ORM.GeneralORM.bd.ESPAIS.Remove(_espais);

            ORM.GeneralORM.bd.SaveChanges();
        }
    }
}
