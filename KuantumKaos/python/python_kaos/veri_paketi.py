from kuantum_nesnesi import KuantumNesnesi
from kuantum_cokusu_exception import KuantumCokusuException

class VeriPaketi(KuantumNesnesi):
    def analiz_et(self):
        self.stabilite -= 5
        print("Veri paketi analiz edildi.")

        if self.stabilite <= 0:
            raise KuantumCokusuException(self.id)
