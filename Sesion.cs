namespace CajeroAutomatico
{
    public static class Sesion
    {
        public static string NroTarjetaActual { get; set; } = string.Empty;
        public static int IdCuentaActual { get; set; }
        public static string TitularActual { get; set; } = string.Empty;
        public static decimal SaldoActual { get; set; }
        public static string Estado { get; set; } = string.Empty;

        public static void Cerrar()
        {
            NroTarjetaActual = "";
            IdCuentaActual = 0;
            TitularActual = "";
            SaldoActual = 0;
            Estado = "Inactiva";
        }
    }
}