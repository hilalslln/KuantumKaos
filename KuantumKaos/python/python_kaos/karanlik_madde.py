from kuantum_nesnesi import KuantumNesnesi
from kritik import Kritik
from kuantum_cokusu_exception import KuantumCokusuException

class KaranlikMadde(KuantumNesnesi, Kritik):
    def analiz_et(self):
        self.stabilite -= 20
        print("Karanlık madde dalgalanıyor!")

        if self.stabilite <= 0:
            raise KuantumCokusuException(self.id)

    def acil_durum_sogutmasi(self):
        self.stabilite += 30
        print("Karanlık madde soğutuldu.")
