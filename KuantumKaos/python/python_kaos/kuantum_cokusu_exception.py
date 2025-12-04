class KuantumCokusuException(Exception):
    def __init__(self, nesne_id):
        super().__init__(f"Kuantum çöküşü gerçekleşti! Nesne ID: {nesne_id}")
