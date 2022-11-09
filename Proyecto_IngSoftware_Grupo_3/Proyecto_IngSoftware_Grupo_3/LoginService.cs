using System.ComponentModel;

namespace Proyecto_IngSoftware_Grupo_3
{
    internal class LoginService
    {
        internal bool validateLogin(string user, string pass)
        {
            AsecapDatabase adb = new AsecapDatabase();

            //falta testear las conexiones y querys

            /*if (adb.connect())
            {
                String passdb = adb.login(user);
                if (passdb != null) { MessageBox.Show("Usuario no encontrado"); return false; }
                else if (pass == passdb) return true;
                else return false;
            }*/

            MessageBox.Show("Conexion no lograda");
            return false;

        }
    }
}