import { KuantumNesnesi } from "./KuantumNesnesi.js";
import { KuantumCokusuException } from "./KuantumCokusuException.js";

export class VeriPaketi extends KuantumNesnesi {
    analizEt() {
        this.stabilite -= 5;
        console.log("Veri paketi analiz edildi.");

        if (this.stabilite <= 0) {
            throw new KuantumCokusuException(this.id);
        }
    }
}
