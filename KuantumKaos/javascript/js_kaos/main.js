import readline from "readline";
import { VeriPaketi } from "./VeriPaketi.js";
import { KaranlikMadde } from "./KaranlikMadde.js";
import { AntiMadde } from "./AntiMadde.js";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

let envanter = [];

function menu() {
    console.log("\n--- KUANTUM AMBARI ---");
    console.log("1. Yeni Nesne Ekle");
    console.log("2. Envanteri Listele");
    console.log("3. Nesneyi Analiz Et");
    console.log("4. Acil Soğutma Uygula");
    console.log("5. Çıkış");

    rl.question("Seçim: ", secim => {
        switch (secim) {
            case "1":
                const r = Math.floor(Math.random() * 3);
                let nesne;

                if (r === 0) {
                    nesne = new VeriPaketi();
                    console.log("Yeni Veri Paketi oluşturuldu.");
                } else if (r === 1) {
                    nesne = new KaranlikMadde();
                    console.log("Yeni Karanlık Madde oluşturuldu.");
                } else {
                    nesne = new AntiMadde();
                    console.log("Yeni Anti Madde oluşturuldu.");
                }

                envanter.push(nesne);
                menu();
                break;

            case "2":
                if (envanter.length === 0) {
                    console.log("Envanter boş.");
                } else {
                    envanter.forEach(n => {
                        console.log(`ID: ${n.id} | Stabilite: ${n.stabilite}`);
                    });
                }
                menu();
                break;

            case "3":
                rl.question("Analiz edilecek ID: ", id => {
                    const hedef = envanter.find(x => x.id === id);

                    if (!hedef) {
                        console.log("Nesne bulunamadı!");
                        menu();
                        return;
                    }

                    try {
                        hedef.analizEt();
                    } catch (e) {
                        console.log(e.message);
                        envanter = envanter.filter(x => x !== hedef);
                    }

                    menu();
                });
                break;

            case "4":
                rl.question("Soğutulacak ID: ", id => {
                    const hedef = envanter.find(x => x.id === id);

                    if (!hedef) {
                        console.log("Nesne bulunamadı!");
                        menu();
                        return;
                    }

                    if (hedef.acilDurumSogutmasi) {
                        hedef.acilDurumSogutmasi();
                    } else {
                        console.log("Bu nesne kritik değildir.");
                    }

                    menu();
                });
                break;

            case "5":
                rl.close();
                break;

            default:
                console.log("Geçersiz seçim.");
                menu();
        }
    });
}

menu();
