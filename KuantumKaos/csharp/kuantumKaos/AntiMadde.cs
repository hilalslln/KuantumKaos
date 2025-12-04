using System;

namespace kuantumKaos
{
    public class AntiMadde : KuantumNesnesi, IKritik
    {
        public override void AnalizEt()
        {
            Console.WriteLine("Evrenin dokusu titriyor...");

            Stabilite -= 25;

            if (Stabilite <= 0)
            {
                throw new KuantumCokusuException(ID);
            }
        }

        public void AcilDurumSogutmasi()
        {
            Stabilite += 50;

            if (Stabilite > 100)
                Stabilite = 100;

            Console.WriteLine("Anti madde acil soğutma uygulandı!");
        }
    }
}