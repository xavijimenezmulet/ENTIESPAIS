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
    }
}
