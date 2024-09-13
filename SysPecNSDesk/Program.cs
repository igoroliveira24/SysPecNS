using SysPecNSLib;

namespace SysPecNSDesk
{
    internal static class Program
    {
        public static Usuario UsuarioLogado = new();
        public static Cliente frmDgvClienteParaPedido = new();
        public static FrmEstoque Estoque = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }
    }
}