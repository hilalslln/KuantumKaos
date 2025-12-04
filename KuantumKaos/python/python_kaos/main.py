from veri_paketi import VeriPaketi
from karanlik_madde import KaranlikMadde
from anti_madde import AntiMadde
import random

envanter = []

while True:
    print("\n--- KUANTUM AMBARI ---")
    print("1. Yeni Nesne Ekle")
    print("2. Envanteri Listele")
    print("3. Nesneyi Analiz Et")
    print("4. Acil Soğutma Uygula")
    print("5. Çıkış")

    secim = input("Seçim: ")

    if secim == "1":
        r = random.randint(0, 2)
        if r == 0:
            nesne = VeriPaketi()
            print("Yeni Veri Paketi oluşturuldu.")
        elif r == 1:
            nesne = KaranlikMadde()
            print("Yeni Karanlık Madde oluşturuldu.")
        else:
            nesne = AntiMadde()
            print("Yeni Anti Madde oluşturuldu.")
        envanter.append(nesne)

    elif secim == "2":
        if not envanter:
            print("Envanter boş.")
        else:
            for n in envanter:
                print(f"ID: {n.id} | Stabilite: {n.stabilite}")

    elif secim == "3":
        nesne_id = input("Analiz edilecek ID: ")
        hedef = next((n for n in envanter if n.id == nesne_id), None)

        if not hedef:
            print("Nesne bulunamadı!")
            continue

        try:
            hedef.analiz_et()
        except Exception as e:
            print(e)
            envanter.remove(hedef)

    elif secim == "4":
        nesne_id = input("Soğutulacak ID: ")
        hedef = next((n for n in envanter if n.id == nesne_id), None)

        if not hedef:
            print("Nesne bulunamadı!")
            continue

        if hasattr(hedef, "acil_durum_sogutmasi"):
            hedef.acil_durum_sogutmasi()
        else:
            print("Bu nesne kritik değildir.")

    elif secim == "5":
        break

    else:
        print("Geçersiz seçim.")
