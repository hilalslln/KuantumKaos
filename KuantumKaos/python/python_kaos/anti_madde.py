from kuantum_nesnesi import KuantumNesnesi
from kritik import Kritik
from kuantum_cokusu_exception import KuantumCokusuException

class AntiMadde(KuantumNesnesi, Kritik):
    def analiz_et(self):
        self.stabilite -= 35
        print("Anti-madde tepkimeye giriyor!")

        if self.stabilite <= 0:
            raise KuantumCokusuException(self.id)

    def acil_durum_sogutmasi(self):
        self.stabilite += 50
        print("Anti-madde kararlılığı artırıldı.")
