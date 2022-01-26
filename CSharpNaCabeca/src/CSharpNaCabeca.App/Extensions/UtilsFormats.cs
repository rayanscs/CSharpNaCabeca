using System;

namespace CSharpNaCabeca.App.Extensions

{
    public static class UtilsFormats
    {
        public static string CepFormat(string cep) => Convert.ToUInt64(cep).ToString(@"00000\-000");
    }
}
