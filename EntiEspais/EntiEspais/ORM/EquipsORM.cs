using System.Collections.Generic;
using System.Linq;

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
        public static string InsertEquip(string nom,
            string esport,
            bool discapacitat,
            int id_entitat,
            string temporada,
            int id_competicio,
            int id_categoria_edat,
            int id_categoria_equip,
            int id_sexe,
            int id_esport)
        {
            string mensaje = "";

            EQUIPS equip = new EQUIPS();

            equip.nom = nom;
            equip.te_discapacitat = discapacitat;
            equip.id_entitat = id_entitat;
            //equip.temporada = ;//INSERTAR MÉTODO PARA SABER TEMPORADA ACTUAL.
            equip.id_competicio = id_competicio;
            equip.id_categoria_edat = id_categoria_edat;
            equip.id_categoria_equip = id_categoria_equip;
            equip.id_sexe = id_sexe;
            equip.id_esport = id_esport;

            GeneralORM.bd.EQUIPS.Add(equip);

            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }
        //------------------------------------------//

        //Modificar un equip de la base de dades.
        public static string UpdateEquip(string nom,
            bool discapacitat,
            int id_entitat,
            string temporada,
            int id_competicio,
            int id_categoria_edat,
            int id_categoria_equip,
            int id_sexe,
            int id_esport)
        {
            string mensaje = "";
            //
            EQUIPS equip = GeneralORM.bd.EQUIPS.Find("????"); //INSERTAR CLAVE PRIMARIA <--
            //
            mensaje = GeneralORM.SaveChanges();

            return mensaje;
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

    }
}
