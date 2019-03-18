using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiEspais.ORM
{
    public class HorariInstalacio
    {
        //Nos hace un select de todos los horarios de instalaciones
        public static List<HORARI_INSTALACIO> selectHorarisInstalacio()
        {
            List<HORARI_INSTALACIO> _horari = (from e in GeneralORM.bd.HORARI_INSTALACIO
                                               select e).ToList();

            return _horari;
        }

        //Alta de un horario de instalacion
        public static String insertHorariInstalacio(int id_dia, int id_hora, int id_instalacio)
        {
            String mensaje = "";
            HORARI_INSTALACIO _horari = new HORARI_INSTALACIO();

            _horari.id_dia = id_dia;
            _horari.id_hores = id_hora;
            _horari.id_instalacio = id_instalacio;

            GeneralORM.bd.HORARI_INSTALACIO.Add(_horari);
            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }

        //Update alta horario de instalacion
        public static String modificarHorariInstalacio(int id_dia, int id_hora_antigua, int id_hora, int id_instalacio)
        {
            String mensaje = "";
            HORARI_INSTALACIO _horari = ORM.GeneralORM.bd.HORARI_INSTALACIO.Find(id_dia, id_hora_antigua, id_instalacio);
            ORM.GeneralORM.bd.HORARI_INSTALACIO.Remove(_horari);

            HORARI_INSTALACIO _horarialta = new HORARI_INSTALACIO();
            _horarialta.id_dia = id_dia;
            _horarialta.id_hores = id_hora;
            _horarialta.id_instalacio = id_instalacio;

            GeneralORM.bd.HORARI_INSTALACIO.Add(_horarialta);
            mensaje = GeneralORM.SaveChanges();

            return mensaje;
        }
    }
}
