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
        public static List<INSTALACIONS> selectInstalacions()
        {
            List<INSTALACIONS> _instalacions =
                 (from e in GeneralORM.bd.INSTALACIONS
                  orderby e.id
                  select e).ToList();

            return _instalacions;

        }

        //Alta instalació
        public static String altaInstalacio(String nom, String contrasenya, String adresa, String tipus, String email, String ruta_imagen, float altitud, float latitud, ref int id_instalacion)
        {
            String mensaje = "";
            INSTALACIONS _instalacio = new INSTALACIONS();

            _instalacio.nom = nom;
            _instalacio.contrasenya = contrasenya;
            _instalacio.adresa = adresa;
            _instalacio.tipus = tipus;
            _instalacio.email = email;
            _instalacio.ruta_imagen = ruta_imagen;
            _instalacio.altitut = altitud;
            _instalacio.latitut = latitud;

            ORM.GeneralORM.bd.INSTALACIONS.Add(_instalacio);

            mensaje = ORM.GeneralORM.SaveChanges();

            id_instalacion = _instalacio.id;
            return mensaje;
        }

        //Eliminar instalació
        public static String eliminarInstalacio(INSTALACIONS _instalacio)
        {
            String mensaje = "";

            ORM.GeneralORM.bd.INSTALACIONS.Remove(_instalacio);

            mensaje = ORM.GeneralORM.SaveChanges();

            return mensaje;
        }

        //Modificar instalació
        public static String modificarinstalacio(int id, String nom, String contrasenya, String adresa, String tipus, String email, String ruta_imagen, float altitud, float latitud)
        {
            String mensaje = "";
            INSTALACIONS _instalacio = ORM.GeneralORM.bd.INSTALACIONS.Find(id);

            _instalacio.nom = nom;
            _instalacio.contrasenya = contrasenya;
            _instalacio.adresa = adresa;
            _instalacio.tipus = tipus;
            _instalacio.email = email;
            _instalacio.ruta_imagen = ruta_imagen;
            _instalacio.altitut = altitud;
            _instalacio.latitut = latitud;

            mensaje = ORM.GeneralORM.SaveChanges();

            return mensaje;
        }
        //Retorna el SELECT una instalacio per id
        public static List<INSTALACIONS> selectInstalacioById(int id)
        {
            List<INSTALACIONS> _instalacions =
                 (from e in GeneralORM.bd.INSTALACIONS
                  orderby e.id
                  where e.id.Equals(id)
                  select e).ToList();

            return _instalacions;

        }
    }
}
