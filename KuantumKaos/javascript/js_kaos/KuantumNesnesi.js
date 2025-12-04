import { randomUUID } from "crypto";

export class KuantumNesnesi {
    constructor() {
        this.id = randomUUID();
        this.stabilite = 100;
    }

    analizEt() {
        throw new Error("Bu metot alt sınıflarda uygulanmalıdır.");
    }
}
