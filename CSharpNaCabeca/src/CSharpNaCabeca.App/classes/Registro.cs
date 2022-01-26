namespace CSharpNaCabeca.App.classes
{
    public class Registro
    {
        public Registro(string nome, int ano, string stack)
        {
            Nome = nome;
            Ano = ano;
            Stack = stack;
        }

        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Stack { get; set; }

        public static implicit operator string(Registro r)
        => $@"{r.Nome};{r.Ano};{r.Stack}";

        public static implicit operator Registro(string line)
        {
            var i = line.Split(',');
            return new Registro(i[0], int.Parse(i[1]), i[2]);
        }
    }
}
