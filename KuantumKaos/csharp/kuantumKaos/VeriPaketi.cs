using kuantumKaos;
using System;

namespace kuantumKaos
{
    public class VeriPaketi : KuantumNesnesi
    {
        public override void AnalizEt()
        {
            Stabilite -= 5;
            Console.WriteLine("Veri içeriği okundu.");

            if (Stabilite <= 0)
            {
                throw new KuantumCokusuException(ID);
            }
        }
    }
}