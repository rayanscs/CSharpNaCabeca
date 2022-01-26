using System;
using System.Text.RegularExpressions;

namespace CSharpNaCabeca.App.Extensions

{
    public static class UtilsValidates
    {
        public static bool ValidateCep(string cep)
        {
            var rx = new Regex(@"^\d{5}-\d{3}$");

            if (rx.IsMatch(cep))
            return true;

            return false;
        }

        public static bool ValidateCel(string cel)
        {
            var rx = new Regex(@"^\(\d{2}\)\d{5}-\d{4}$");

            if (rx.IsMatch(cel))
                return true;

            return false;
        }

        public static bool ValidateCpf(string cpf)
        {
            var rx = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            if (rx.IsMatch(cpf))
                return true;

            return false;
        }
    }
}
