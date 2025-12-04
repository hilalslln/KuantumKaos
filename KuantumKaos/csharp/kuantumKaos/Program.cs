using System;
using System.Collections.Generic;

namespace kuantumKaos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KuantumNesnesi> envanter = new List<KuantumNesnesi>();
            Random random = new Random();

            while (true)
            {
                try
                {
                    Console.WriteLine("\n--- KUANTUM AMBARI KONTROL PANELİ ---");
                    Console.WriteLine("1. Yeni Nesne Ekle");
                    Console.WriteLine("2. Tüm Envanteri Listele");
                    Console.WriteLine("3. Nesneyi Analiz Et");
                    Console.WriteLine("4. Acil Durum Soğutması Yap");
                    Console.WriteLine("5. Çıkış");
                    Console.Write("Seçiminiz: ");

                    string? secim = Console.ReadLine();
                    Console.WriteLine();

                    switch (secim)
                    {
                        //yeni nesne ekleme
                        case "1":
                            int tur = random.Next(1, 4);

                            KuantumNesnesi yeniNesne;

                            if (tur == 1)
                            {
                                yeniNesne = new VeriPaketi();
                                yeniNesne.ID = Guid.NewGuid().ToString();
                                yeniNesne.TehlikeSeviyesi = 1;
                                yeniNesne.Stabilite = random.Next(50, 101);
                                Console.WriteLine("Yeni Veri Paketi oluşturuldu.");
                            }
                            else if (tur == 2)
                            {
                                yeniNesne = new KaranlikMadde();
                                yeniNesne.ID = Guid.NewGuid().ToString();
                                yeniNesne.TehlikeSeviyesi = 7;
                                yeniNesne.Stabilite = random.Next(40, 90);
                                Console.WriteLine("Yeni Karanlık Madde oluşturuldu.");
                            }
                            else
                            {
                                yeniNesne = new AntiMadde();
                                yeniNesne.ID = Guid.NewGuid().ToString();
                                yeniNesne.TehlikeSeviyesi = 10;
                                yeniNesne.Stabilite = random.Next(30, 80);
                                Console.WriteLine("Yeni Anti Madde oluşturuldu!");
                            }

                            envanter.Add(yeniNesne);
                            break;

                        //tum envanteri listeleme
                        case "2":
                            foreach (var nesne in envanter)
                            {
                                Console.WriteLine(nesne.DurumBilgisi());
                            }
                            break;

                        //nesne analizi
                        case "3":
                            Console.Write("Analiz edilecek ID: ");
                            string analizID = Console.ReadLine();

                            var analizNesne = envanter.Find(n => n.ID == analizID);

                            if (analizNesne == null)
                            {
                                Console.WriteLine("Nesne bulunamadı.");
                            }
                            else
                            {
                                analizNesne.AnalizEt();
                                Console.WriteLine("Analiz tamamlandı.");
                            }
                            break;

                        //acil durum sogutmasi
                        case "4":
                            Console.Write("Soğutma yapılacak ID: ");
                            string sogutID = Console.ReadLine();

                            var sogutNesne = envanter.Find(n => n.ID == sogutID);

                            if (sogutNesne == null)
                            {
                                Console.WriteLine("Nesne bulunamadı.");
                            }
                            else if (sogutNesne is IKritik kritik)
                            {
                                kritik.AcilDurumSogutmasi();
                                Console.WriteLine("Soğutma işlemi tamamlandı.");
                            }
                            else
                            {
                                Console.WriteLine("Bu nesne soğutulamaz!");
                            }
                            break;

                        //cikis
                        case "5":
                            return;

                        default:
                            Console.WriteLine("Geçersiz seçim!");
                            break;
                    }
                }
                catch (KuantumCokusuException ex)
                {
                    Console.WriteLine("\nSİSTEM ÇÖKTÜ! TAHLİYE BAŞLATILIYOR...");
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
    }
}
