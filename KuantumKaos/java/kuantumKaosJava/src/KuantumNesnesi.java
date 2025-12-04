public abstract class KuantumNesnesi {
    protected String id;
    protected int stabilite;

    public KuantumNesnesi() {
        this.id = java.util.UUID.randomUUID().toString();
        this.stabilite = 100;
    }

    public String getId() {
        return id;
    }

    public int getStabilite() {
        return stabilite;
    }

    public void setStabilite(int stabilite) {
        this.stabilite = stabilite;
    }

    public abstract void analizEt();
}
