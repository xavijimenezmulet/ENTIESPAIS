using System.Collections.Generic;
using System.Linq;
using System;

namespace EntiEspais.ORM
{
    public static class CategoriaDelEquipORM
    {
        /**
         * ENS RETORNA LA SELECT AMB TOTES LES CATEGORIES D'EQUIPS.
         **/
        public static List<CATEGORIA_EQUIP> SelectAllCategoriesEquips()
        {
            List<CATEGORIA_EQUIP> _categoriaEquips =
                 (from cat in GeneralORM.bd.CATEGORIA_EQUIP
                  orderby cat.nom
                  select cat).ToList();

            return _categoriaEquips;
        }

        /**
             * ENS ACTUALITZA UNA CATEGORIA PER EQUIP DE LA BASE DE DADES 
             **/
        public static String UpdateCategoriaPerEquip(CATEGORIA_EQUIP categoria)
        {
            String missatgeError = "";
            CATEGORIA_EQUIP a = GeneralORM.bd.CATEGORIA_EQUIP.Find(categoria.id);

            a.nom = categoria.nom;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

        /**
         * ENS INSERTA A LA BASE DE DADES UNA CATEGORIA PER EQUIP NOVA
         **/
        public static String InsertCategoriaPerEquip(CATEGORIA_EQUIP categoria)
        {
            String missatgeError = "";

            GeneralORM.bd.CATEGORIA_EQUIP.Add(categoria);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;
        }

        /**
         * ENS BORRA UNA CATEGORIA PER EQUIP DE LA BASE DE DADES QUE LI PASSEM PER PARAMETRE
         **/
        public static String DeleteByCategoriaPerEquip(CATEGORIA_EQUIP categoria)
        {
            String missatgeError = "";

            GeneralORM.bd.CATEGORIA_EQUIP.Remove(categoria);

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }

    }
}
