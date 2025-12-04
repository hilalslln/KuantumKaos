import uuid

class KuantumNesnesi:
    def __init__(self):
        self.id = str(uuid.uuid4())
        self.stabilite = 100

    def analiz_et(self):
        raise NotImplementedError("Bu metot alt sınıflarda uygulanmalıdır.")
