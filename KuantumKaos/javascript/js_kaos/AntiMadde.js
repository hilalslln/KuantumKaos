import { KuantumNesnesi } from "./KuantumNesnesi.js";
import { IKritik } from "./IKritik.js";
import { KuantumCokusuException } from "./KuantumCokusuException.js";

export class AntiMadde extends KuantumNesnesi {
    analizEt() {
        this.stabilite -= 35;
        console.log("Anti-madde tepkimeye giriyor!");

        if (this.stabilite <= 0) {
            throw new KuantumCokusuException(this.id);
        }
    }

    acilDurumSogutmasi() {
        this.stabilite += 50;
        console.log("Anti-madde kararlılığı artırıldı.");
    }
}
