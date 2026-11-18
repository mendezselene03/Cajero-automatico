using System;

namespace CajeroAutomatico
{
    public class Extraccion
    {
        public decimal Monto { get; set; }
        public string NroTransaccion { get; set; }

        // Constructor que recibe el monto enviado desde el formulario
        public Extraccion(decimal monto)
        {
            Monto = monto;
        }

        public bool VerificarLimite()
        {
            // Valida que no supere el límite diario o el saldo actual de la sesión
            if (Monto > 100000 || Monto > Sesion.SaldoActual)
            {
                return false;
            }
            return true;
        }

        public bool Ejecutar()
        {
            try
            {
                if (!VerificarLimite()) return false;

                // Descontamos el dinero del saldo actual
                Sesion.SaldoActual -= Monto;

                // Generamos un número aleatorio de transacción para el ticket
                NroTransaccion = new Random().Next(100000, 999999).ToString();

                // Registramos la operación en la base de datos
                SucursalDB.RegistrarTransaccion("Extracción", NroTransaccion, "OK");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}