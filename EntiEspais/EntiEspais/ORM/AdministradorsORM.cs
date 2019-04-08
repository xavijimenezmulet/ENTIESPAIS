using EntiEspais.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class AdministradorsORM
    {
        /**
         * ENS RETORNA SI LA CONTRASSENYA DEL ADMIN ÉS LA MATEIXA QUE EL DE LA BASE DE DADES
         **/
        public static Boolean FindAdminByEmailAndPassword(String email, String Password)
        {
            Boolean verdader;

            List<ADMINISTRADORS> _admins =
                (from a in GeneralORM.bd.ADMINISTRADORS
                 where a.email.Equals(email)
                 select a).ToList();
            if( _admins.Count == 0 )
            {
                verdader = false;
            }
            else
            {
                ADMINISTRADORS admin = _admins[0];
                if(Utilitats.desencriptarContrassenya(admin.contrasenya, Password))
                {
                    verdader = true;
                }
                else
                {
                    verdader = false;
                }
            }

            return verdader;

        }

        /**
         * ENS RETORNA LA SELECT AMB TOTS ELS ADMINISTRADORS
         **/
        public static List<ADMINISTRADORS> SelectAllAdministradors()
        {
            List<ADMINISTRADORS> _admins =
                 (from a in GeneralORM.bd.ADMINISTRADORS
                  orderby a.nom
                  select a).ToList();

            return _admins;

        }

        /**
         * ENS ACTUALITZA UN HOTEL ADMINISTADOR DE LA BASE DE DADES 
         **/
        public static String UpdateAdministrador(ADMINISTRADORS administrador)
        {
            String missatgeError = "";
            ADMINISTRADORS a = GeneralORM.bd.ADMINISTRADORS.Find(administrador.id);

            a.nom           = administrador.nom;
            a.cognoms       = administrador.cognoms;
            a.contrasenya   = administrador.contrasenya;
            a.dni           = administrador.dni;
            a.email         = administrador.email;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UN ADMINISTRADOR NOU
         **/
        public static String InsertAdministrador(ADMINISTRADORS administrador)
        {
            String missatgeError = "";
            
            GeneralORM.bd.ADMINISTRADORS.Add(administrador);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UN ADMINISTRADOR DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByAdministrador(ADMINISTRADORS administrador)
        {
            String missatgeError = "";

            GeneralORM.bd.ADMINISTRADORS.Remove(administrador);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS RETORNA LA SELECT AMB L'ADMINISTRADOR 
         **/
        public static List<ADMINISTRADORS> SelectAdministradorByEmail(string email)
        {
            List<ADMINISTRADORS> _admins =
                 (from a in GeneralORM.bd.ADMINISTRADORS
                  orderby a.nom
                  where a.email.Equals(email)
                  select a).ToList();

            return _admins;

        }
        /**
         * ENS RETORNA LA SELECT AMB L'ADMINISTRADOR PER ID
         **/
        public static List<ADMINISTRADORS> SelectAdministradorById(int id)
        {
            List<ADMINISTRADORS> _admins =
                 (from a in GeneralORM.bd.ADMINISTRADORS
                  orderby a.nom
                  where a.id.Equals(id)
                  select a).ToList();

            return _admins;

        }
    }
}
