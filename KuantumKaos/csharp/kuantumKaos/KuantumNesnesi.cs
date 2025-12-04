using System;

namespace kuantumKaos
{
    public abstract class KuantumNesnesi
    {
        public string ID { get; set; } = "";

        private double stabilite;
        public double Stabilite
        {
            get { return stabilite; }
            set
            {
                if (value < 0)
                    stabilite = 0;
                else if (value > 100)
                    stabilite = 100;
                else
                    stabilite = value;
            }
        }

        public int TehlikeSeviyesi { get; set; }

        public abstract void AnalizEt();

        public string DurumBilgisi()
        {
            return $"ID: {ID} | Stabilite: {Stabilite}";
        }
    }
}