public class KaranlikMadde extends KuantumNesnesi implements IKritik {

    @Override
    public void analizEt() {
        stabilite -= 20;
        System.out.println("Karanlık madde dalgalanıyor!");

        if (stabilite <= 0) {
            throw new KuantumCokusuException(id);
        }
    }

    @Override
    public void acilDurumSogutmasi() {
        stabilite += 30;
        System.out.println("Karanlık madde soğutuldu.");
    }
}
