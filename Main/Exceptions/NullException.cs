namespace GeoShared.Main.Exceptions
{
    public class NullException : Exception
    {
        public NullException(string code) : base($"Erro, the {code} retorns with error") { }
    }
}
