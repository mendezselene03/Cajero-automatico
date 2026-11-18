using System;
using System.Text.RegularExpressions;

namespace CajeroAutomatico
{
    public static class Validador
    {
        // Valida que el número de tarjeta no esté vacío y tenga formato numérico válido
        public static bool EsTarjetaValida(string nroTarjeta)
        {
            return !string.IsNullOrWhiteSpace(nroTarjeta);
        }

        // Valida que el PIN tenga el formato correcto (por ejemplo, 4 dígitos)
        public static bool EsPinValido(string pin)
        {
            return !string.IsNullOrWhiteSpace(pin) && pin.Length >= 4;
        }

        // Valida que un monto ingresado sea un número decimal válido y mayor a cero
        public static bool EsMontoValido(string textoMonto, out decimal montoParseado)
        {
            string limpio = textoMonto.Replace("$", "").Replace(".", "").Trim();
            return decimal.TryParse(limpio, out montoParseado) && montoParseado > 0;
        }
    }
}