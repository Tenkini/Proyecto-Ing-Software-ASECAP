using System.Data;

namespace Proyecto_IngSoftware_Grupo_3
{
    internal class ShowClientesService
    {
        internal DataTable ShowClients()
        {
            AsecapDatabase adb = new AsecapDatabase();

            return adb.ShowClientesDatabase(); ;
        }
    }
}