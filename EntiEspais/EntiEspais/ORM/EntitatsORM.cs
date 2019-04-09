using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
        public static List<ENTITATS> SelectAllEntities()
        {
            List<ENTITATS> _entitats =
                 (from e in GeneralORM.bd.ENTITATS
                  orderby e.nom
                  select e).ToList();

            return _entitats;
        }
        public static String DeleteEntitat(ENTITATS entitat)
        {
            String mensaje = "";
            GeneralORM.bd.ENTITATS.Remove(entitat);
            try
            {
                GeneralORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = GeneralORM.MissatgesError(sqlEx);
            }
            return mensaje;
        }

        //------INSERTAR
        public static void InsertEntitat(/*int id,*/ string temp, string nom, string pass, string adresa, string nif, string email, string imagen, string video, float altitud, float latitud)
        {
            ENTITATS entitat = new ENTITATS();

            //entitat.id = id;
            entitat.temporada = temp;
            entitat.nom = nom;
            entitat.contrasenya = pass;
            entitat.adresa = adresa;
            entitat.nif = nif;
            entitat.email = email;
            entitat.ruta_imagen = imagen;
            entitat.ruta_video = video;
            entitat.altitud = altitud;
            entitat.latitud = latitud;

            GeneralORM.bd.ENTITATS.Add(entitat);
            GeneralORM.bd.SaveChanges();
        }

        //---------ACTUALIZAR
        public static void UpdateEntitat(int id, string temp, string nom, string pass, string adresa, string nif, string email, string imagen, string video, float altitud, float latitud)
        {
            ENTITATS entitat = GeneralORM.bd.ENTITATS.Find(id, temp);

            //entitat.id = id;
            //entitat.temporada = temp;
            entitat.nom = nom;
            entitat.contrasenya = pass;
            entitat.adresa = adresa;
            entitat.nif = nif;
            entitat.email = email;
            entitat.ruta_imagen = imagen;
            entitat.ruta_video = video;
            entitat.altitud = altitud;
            entitat.latitud = latitud;

            GeneralORM.bd.SaveChanges();
        }
        /**
        * ENS RETORNA LA SELECT AMB TOTES LES ENTITATS
        **/
        public static List<ENTITATS> SelectEntitiesByIdiTemp(int id, String temporada)
        {
            List<ENTITATS> _entitats =
                 (from e in GeneralORM.bd.ENTITATS
                  orderby e.nom
                  where e.temporada.Equals(temporada) && e.id.Equals(id)
                  select e).ToList();

            return _entitats;

        }
    }
}
