namespace Proyecto_IngSoftware_Grupo_3
{
    internal class AddClienteService
    {
        internal void addClient(string rutCliente, string nombreCliente, string tipoCliente, string descripcionCliente)
        {
            Cliente c = new Cliente(rutCliente,"1234K",nombreCliente,tipoCliente,descripcionCliente);

            AsecapDatabase adb = new AsecapDatabase();

            adb.AddCliente(c);
        }
    }
}