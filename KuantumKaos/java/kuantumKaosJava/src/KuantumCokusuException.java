public class KuantumCokusuException extends RuntimeException {

    public KuantumCokusuException(String id) {
        super("Kuantum çöküşü gerçekleşti! Nesne ID: " + id);
    }
}
