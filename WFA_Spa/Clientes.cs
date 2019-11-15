using System;
using System.Linq;

namespace WFA_Spa
{
    class Clientes
    {
        public static void Agregar(string TXT_Nombre, string TXT_Apellido, string TXT_DNI, string TXT_Email)
        {
            //if (!ExisteCliente())
            //{
                using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
                {
                    db.SP_Cliente_Agregar(TXT_Nombre, TXT_Apellido, TXT_DNI, TXT_Email);
                }
            //}
        }

        public static void Editar(int ID_Cliente, string TXT_Nombre, string TXT_Apellido, string TXT_DNI, string TXT_Email)
        {
            //if (!ExisteCliente())
            //{
            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                db.SP_Cliente_Editar(ID_Cliente, TXT_Nombre, TXT_Apellido, TXT_DNI, TXT_Email);
            }
            //}
        }

        public static void Borrar(int ID_Cliente)
        {
            //if (!ExisteCliente())
            //{
                using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
                {
                    db.SP_Cliente_Borrar(ID_Cliente);
                }
            //}
        }

        public static Cliente Buscar(int ID_Cliente)
        {
            Cliente cliente = null;

            using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
            {
                cliente = 
                    (Cliente) db.Clientes.SingleOrDefault(u => u.Id == ID_Cliente);

                //var user = (from u in dc.Users
                //            where u.UserName == usn
                //            select u).FirstOrDefault();
            }

            return cliente;
        }

        private static bool ExisteCliente()
        {
            throw new NotImplementedException();
        }
    }


}
