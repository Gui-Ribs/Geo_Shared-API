﻿namespace GeoShared.Main.Exceptions
{
    public class NullException : Exception
    {
        public NullException() : base("Erro, JSON is null") { }
    }
}
