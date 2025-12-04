using System;

namespace kuantumKaos
{
    public class KaranlikMadde : KuantumNesnesi, IKritik
    {
        public override void AnalizEt()
        {
            Stabilite -= 15;

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

            Console.WriteLine("Karanlık madde soğutuldu.");
        }
    }
}