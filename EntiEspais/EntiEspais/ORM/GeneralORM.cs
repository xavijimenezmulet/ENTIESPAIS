using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * CLASSE GENERAL ORM ENS SERVIRÀ PER UTILITZAR ELS MÈTODES PER DIRGIRNOS A LA BASE DE
 * DADES, TAMBÉ PER CONTROLAR ELS SEUS ERRORS
 **/
namespace EntiEspais.ORM
{
    public static class GeneralORM
    {

        //CONEXIÓ AMB ENTITIES
        public static ENTI_ESPAISEntities bd = new ENTI_ESPAISEntities();

        /**
         * LI PASSEM LA SQLEXCEPTION PER PARAMETRE SI LA TENIM REGISTRADA LA RETORNAREM SI NO
         * ENS MOSTRARA EL ERROR TAL COM ENS HO MOSTRA EL SQL SERVER
         **/
        public static String MissatgesError(SqlException ex)
        {
            String missatge = "";
            switch (ex.Number)
            {
                case -1:
                    missatge = "Error de conexió amb el servidor!";
                    break;
                case 547:
                    missatge = "Té elements relacionats!";
                    break;
                case 2601:
                case 2627:
                    missatge = "Conté dades duplicades!";
                    break;
                case 4060:
                    missatge = "No es troba a la base de dades!";
                    break;
                case 18456:
                    missatge = "Usuari o contrasenya incorrectes!";
                    break;
                default:
                    missatge = ex.Number + " - " + ex.Message;
                    break;
            }

            return missatge;
        }

        

        /**
         * ENS FA UN REJECT(TIRAR ENRERE) DE UN UPDATE UN DELETE O UN ADD DE LA BASE DE DADES
         **/
        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default:
                        break;
                }
            }
        }

        /**
         * ENS GUARDA EL CANVIS FETS A LA BASE DE DADES EN CAS D'EXCEPCIÓ UTILITZAN EL METODE REJECT EN TIRA ENRERE
         * LA OPERACIÓ I A MÉS ENS ENVIA EL MISSATGE D'ERROR
         **/
        public static String SaveChanges()
        {
            String missatgeError = "";
            try
            {
                //bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                RejectChanges();
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                missatgeError = MissatgesError(sqlEx);
            }

            return missatgeError;
        }
    }

}
