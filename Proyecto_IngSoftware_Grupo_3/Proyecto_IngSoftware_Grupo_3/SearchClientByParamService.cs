using System.Xml.Linq;

namespace Proyecto_IngSoftware_Grupo_3
{
    internal class SearchClientByParamService
    {
        internal bool existsClientByName(string name)
        {
            AsecapDatabase adb = new AsecapDatabase();
            Cliente c = adb.GetClientByName(name);

            if (c == null) return false;
            else return true;
        }

        internal bool existsClientByRut(string rut)
        {
            AsecapDatabase adb = new AsecapDatabase();
            Cliente c = adb.GetClientByRut(rut);

            if (c == null) return false;
            else return true;
        }
    }
}