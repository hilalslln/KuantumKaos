public class AntiMadde extends KuantumNesnesi implements IKritik {

    @Override
    public void analizEt() {
        stabilite -= 35;
        System.out.println("Anti-madde tepkimeye giriyor!");

        if (stabilite <= 0) {
            throw new KuantumCokusuException(id);
        }
    }

    @Override
    public void acilDurumSogutmasi() {
        stabilite += 50;
        System.out.println("Anti-madde kararlılığı artırıldı.");
    }
}
