using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public class EspaisORM
    {
        //Select todos los espacios
        public static List<ESPAIS> selectEspais()
        {
            List<ESPAIS> _espais = (from e in GeneralORM.bd.ESPAIS
                                    orderby e.id_instalacio
                                    select e).ToList();

            return _espais;
        }

        //Alta espai
        public static String altaEspai(String nom, float preu, bool tipus, int id_instalacio)
        {
            String mensaje = "";
            ESPAIS _espai = new ESPAIS();

            _espai.nom = nom;
            _espai.preu = preu;
            _espai.es_exterior = tipus;
            _espai.id_instalacio = id_instalacio;

            ORM.GeneralORM.bd.ESPAIS.Add(_espai);

            mensaje = ORM.GeneralORM.SaveChanges();

            return mensaje;
        }

        //Modificar espai
        public static String modificarEspai(int id, String nom, float preu, bool tipus)
        {
            String mensaje = "";
            ESPAIS _espai = ORM.GeneralORM.bd.ESPAIS.Find(id);

            _espai.nom = nom;
            _espai.preu = preu;
            _espai.es_exterior = tipus;

            mensaje = ORM.GeneralORM.SaveChanges();

            return mensaje;
        }

        //Eliminar espai
        public static String eliminarEspai(ESPAIS _espais)
        {
            String mensaje = "";

            ORM.GeneralORM.bd.ESPAIS.Remove(_espais);

            mensaje = ORM.GeneralORM.SaveChanges();

            return mensaje;
        }
    }
}
