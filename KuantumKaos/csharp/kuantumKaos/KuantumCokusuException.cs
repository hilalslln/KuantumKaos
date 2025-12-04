using System;

namespace kuantumKaos
{
    public class KuantumCokusuException : Exception
    {
        public KuantumCokusuException(string id)
            : base($"KUANTUM ÇÖKÜŞÜ! Patlayan nesne ID: {id}")
        {
        }
    }
}
