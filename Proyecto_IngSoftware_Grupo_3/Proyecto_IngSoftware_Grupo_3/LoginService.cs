using System.ComponentModel;

namespace Proyecto_IngSoftware_Grupo_3
{
    internal class LoginService
    {
        internal bool ValidateLogin(string user, string pass)
        {
            AsecapDatabase adb = new AsecapDatabase();

            //falta testear las conexiones y querys

            Admin adm = adb.GetAdminByUser(user);

            if (adm == null) return false;
            else
            {
                if (adm.pass == pass) return true;
                return false;
            }
        }
    }
}