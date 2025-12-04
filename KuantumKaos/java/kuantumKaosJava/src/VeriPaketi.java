public class VeriPaketi extends KuantumNesnesi {

    @Override
    public void analizEt() {
        stabilite -= 5;
        System.out.println("Veri paketi analiz edildi.");

        if (stabilite <= 0) {
            throw new KuantumCokusuException(id);
        }
    }
}
