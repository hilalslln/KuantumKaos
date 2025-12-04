export class KuantumCokusuException extends Error {
    constructor(id) {
        super(`Kuantum çöküşü gerçekleşti! Nesne ID: ${id}`);
    }
}
