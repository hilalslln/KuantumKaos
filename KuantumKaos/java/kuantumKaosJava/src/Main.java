import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        ArrayList<KuantumNesnesi> envanter = new ArrayList<>();
        Random random = new Random();

        while (true) {
            System.out.println("\n--- KUANTUM AMBARI ---");
            System.out.println("1. Yeni Nesne Ekle");
            System.out.println("2. Envanteri Listele");
            System.out.println("3. Nesneyi Analiz Et");
            System.out.println("4. Acil Soğutma Uygula");
            System.out.println("5. Çıkış");

            System.out.print("Seçim: ");
            String secim = scanner.nextLine();

            switch (secim) {

                case "1":
                    int r = random.nextInt(3);
                    KuantumNesnesi nesne = null;

                    if (r == 0) {
                        nesne = new VeriPaketi();
                        System.out.println("Yeni Veri Paketi oluşturuldu.");
                    } else if (r == 1) {
                        nesne = new KaranlikMadde();
                        System.out.println("Yeni Karanlık Madde oluşturuldu.");
                    } else {
                        nesne = new AntiMadde();
                        System.out.println("Yeni Anti Madde oluşturuldu.");
                    }

                    envanter.add(nesne);
                    break;

                case "2":
                    if (envanter.isEmpty()) {
                        System.out.println("Envanter boş.");
                    } else {
                        for (KuantumNesnesi k : envanter) {
                            System.out.println("ID: " + k.getId() +
                                " | Stabilite: " + k.getStabilite());
                        }
                    }
                    break;

                case "3":
                    System.out.print("Analiz edilecek nesnenin ID'si: ");
                    String id = scanner.nextLine();

                    KuantumNesnesi bulunan = null;
                    for (KuantumNesnesi k : envanter) {
                        if (k.getId().equals(id)) {
                            bulunan = k;
                            break;
                        }
                    }

                    if (bulunan == null) {
                        System.out.println("Nesne bulunamadı!");
                        break;
                    }

                    try {
                        bulunan.analizEt();
                    } catch (KuantumCokusuException e) {
                        System.out.println(e.getMessage());
                        envanter.remove(bulunan);
                    }
                    break;

                case "4":
                    System.out.print("Soğutulacak nesnenin ID'si: ");
                    String sid = scanner.nextLine();

                    for (KuantumNesnesi k : envanter) {
                        if (k.getId().equals(sid)) {
                            if (k instanceof IKritik) {
                                ((IKritik) k).acilDurumSogutmasi();
                            } else {
                                System.out.println("Bu nesne kritik değildir.");
                            }
                        }
                    }
                    break;

                case "5":
                    return;

                default:
                    System.out.println("Geçersiz seçim.");
            }
        }
    }
}
