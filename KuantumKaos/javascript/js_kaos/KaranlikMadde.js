import { KuantumNesnesi } from "./KuantumNesnesi.js";
import { IKritik } from "./IKritik.js";
import { KuantumCokusuException } from "./KuantumCokusuException.js";

export class KaranlikMadde extends KuantumNesnesi {
    analizEt() {
        this.stabilite -= 20;
        console.log("Karanlık madde dalgalanıyor!");

        if (this.stabilite <= 0) {
            throw new KuantumCokusuException(this.id);
        }
    }

    acilDurumSogutmasi() {
        this.stabilite += 30;
        console.log("Karanlık madde soğutuldu.");
    }
}
