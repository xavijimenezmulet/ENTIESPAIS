using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public static class CategoriaPerEdatORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES CATEGORIES PER EDAT
         **/
        public static List<CATEGORIA_EDAT> SelectAllCategoriesPerEdat()
        {
            List<CATEGORIA_EDAT> _categoriaEdats =
                 (from a in GeneralORM.bd.CATEGORIA_EDAT
                  orderby a.nom
                  select a).ToList();

            return _categoriaEdats;

        }

        /**
         * ENS ACTUALITZA UNA CATEGORIA PER EDAT DE LA BASE DE DADES 
         **/
        public static String UpdateCategoriaPerEdat(CATEGORIA_EDAT categoria)
        {
            String missatgeError = "";
            CATEGORIA_EDAT a = GeneralORM.bd.CATEGORIA_EDAT.Find(categoria.id);

            a.nom = categoria.nom;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UNA CATEGORIA PER EDAT NOVA
         **/
        public static String InsertCategoriaPerEdat(CATEGORIA_EDAT categoria)
        {
            String missatgeError = "";

            GeneralORM.bd.CATEGORIA_EDAT.Add(categoria);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UNA CATEGORIA PER EDAT DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByCategoriaPerEdat(CATEGORIA_EDAT categoria)
        {
            String missatgeError = "";

            GeneralORM.bd.CATEGORIA_EDAT.Remove(categoria);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
    }
}
