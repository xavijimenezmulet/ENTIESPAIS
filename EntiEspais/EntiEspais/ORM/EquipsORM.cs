using System.Collections.Generic;
using System.Linq;
using System;

namespace EntiEspais.ORM
{
    public static class EquipsORM
    {
        //Ens retorna una llista amb tots els equips.
        public static List<EQUIPS> SelectAllEquips()
        {
            List<EQUIPS> _equips =
                (from eq in GeneralORM.bd.EQUIPS
                 select eq
                ).ToList();

            return _equips;
        }
        //------------------------------------------//

        //Insertar un equip a la base de dades.
        public static string InsertEquip(EQUIPS equip)
        {
            string mensaje = "";

            GeneralORM.bd.EQUIPS.Add(equip);

            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }
        //------------------------------------------//

        //Modificar un equip de la base de dades.
        public static String UpdateEquip(EQUIPS equip)
        {
            String missatgeError = "";
            EQUIPS eq = GeneralORM.bd.EQUIPS.Find(equip.id);

            eq.nom = equip.nom;
            eq.te_discapacitat = equip.te_discapacitat;
            eq.id_entitat = equip.id_entitat;
            eq.temporada = equip.temporada;
            eq.id_competicio = equip.id_competicio;
            eq.id_categoria_edat = equip.id_categoria_edat;
            eq.id_categoria_equip = equip.id_categoria_equip;
            eq.id_sexe = equip.id_sexe;
            eq.id_esport = equip.id_esport;

            missatgeError = GeneralORM.SaveChanges();

            return missatgeError;

        }
        //------------------------------------------//

        //Eliminar un equip de la base de dades.
        public static string DeleteEquip(EQUIPS equip)
        {
            string mensaje = "";

            GeneralORM.bd.EQUIPS.Remove(equip);

            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }
        //------------------------------------------//
        /**
         * ENS RETORNA LA SELECT AMB EL ID D'UN EQUIP
         **/
        public static List<EQUIPS> SelectAllEquipByid(int id)
        {

            List<EQUIPS> _equips =
                 (from e in GeneralORM.bd.EQUIPS
                  orderby e.nom
                  where e.id.Equals(id)
                  select e).ToList();

            return _equips;
        }
    }
}
