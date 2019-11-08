using System;

namespace WFA_Spa
{
    class Clientes
    {
        public static void Agregar(string TXT_Nombre, string TXT_Apellido, string TXT_DNI, string TXT_Email)
        {
            //if (noExisteCliente)
            //{
                using (DataClassesSpaDataContext db = new DataClassesSpaDataContext())
                {
                    db.SP_Cliente_Agregar(TXT_Nombre, TXT_Apellido, TXT_DNI, TXT_Email);
                }
            //}

        }
    }


}
