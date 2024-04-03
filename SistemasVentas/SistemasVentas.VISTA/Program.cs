namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            
            Application.Run(new UsuarioVistas.UsuarioDatosVista());
            Application.Run(new ProductoVistas.ProductosDatosVistas());
            Application.Run(new ClienteVistas.ClienteDatosVista());
            Application.Run(new DetalleIngVistas.DetalleIngDatosVista());
            Application.Run(new DetalleVentaVistas.DetalleVentaDatosVistas());
            Application.Run(new IngresoVistas.IngresoDatosVista());
            Application.Run(new ProductoVistas.ProductosDatosVistas());
            Application.Run(new ProveeVistas.ProveeDatosVista());
            Application.Run(new UsuarioRolVistas.UsuarioRolDatosVista());
            Application.Run(new VentaVistas.VentaDatosVista());

        }
    }
}