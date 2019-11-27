using System;
using System.Linq;

namespace CL_Spa
{
    public class Clientes
    {
        public static void Agregar(string TXT_Nombre, string TXT_Apellido, string TXT_DNI, string TXT_Email)
        {
            //if (!ExisteCliente())
            //{
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                //db.SP_Cliente_Agregar(TXT_Nombre, TXT_Apellido, TXT_DNI, TXT_Email);

                db.SP_Cliente_Agregar_2(TXT_Nombre,
                                        TXT_Apellido,
                                        long.Parse(TXT_DNI),
                                        TXT_Email);

            }
            //}
        }

        public static void Editar(int ID_Cliente, string TXT_Nombre, string TXT_Apellido, string TXT_DNI, string TXT_Email)
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                db.SP_Cliente_Editar(ID_Cliente, TXT_Nombre, TXT_Apellido, TXT_DNI, TXT_Email);
            }
        }

        public static void Borrar(int ID_Cliente)
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                db.SP_Cliente_Borrar(ID_Cliente);
            }
        }

        public static Cliente Buscar(int ID_Cliente)
        {
            Cliente cliente = null;

            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                cliente =
                    (Cliente)db.Clientes.SingleOrDefault(u => u.Id == ID_Cliente);

                //var user = (from c in db.Clientes
                //            where c.Id == ID_Cliente
                //            select c).FirstOrDefault();
            }

            return cliente;
        }

        public static bool ExisteCliente(long DNI_Cliente)
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                var cli = (from c in db.Clientes
                           where c.DNI == DNI_Cliente
                           select c).FirstOrDefault();

                if (cli != null)
                    return true;
                else
                    return false;
            }
        }

        public static bool ClienteTieneTurnos(int ID_Cliente)
        {
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                var t = (from c in db.Turnos
                         where c.IdCliente == ID_Cliente
                         select c).FirstOrDefault();

                if (t != null)
                    return true;
                else
                    return false;
            }
        }
    }

}
