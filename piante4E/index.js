var Pianta = /** @class */ (function () {
    function Pianta() {
    }
    return Pianta;
}());
var Ordine = /** @class */ (function () {
    function Ordine() {
    }
    return Ordine;
}());
var catalogo = [
    { id: 0, nome: "Anthurium", prezzo: 54.00, tot: 0 },
    { id: 1, nome: "Azalea", prezzo: 48.00, tot: 0 },
    { id: 2, nome: "Orchidea", prezzo: 68.50, tot: 0 },
    { id: 3, nome: "Spathiphyllum", prezzo: 38.00, tot: 0 },
    { id: 4, nome: "Kroton", prezzo: 54.00, tot: 0 }
];
mostraCatalogo(catalogo);
function mostraCatalogo(catalogo) {
    var elenco = document.getElementById("elencoPiante");
    elenco.innerHTML = "";
    for (var _i = 0, catalogo_1 = catalogo; _i < catalogo_1.length; _i++) {
        var pianta = catalogo_1[_i];
        var li = "<li calss=\"list-group-item d-flex justify-content-between align-items-start\">\n                        <div class =\"ms-2 me-auto>\n                            <div class=\"fw-bold\">".concat(pianta.nome, "\n                                <span calss=\"badge text-bg-primary rounded-pill mx-1\">0</span>\n                            </div>\n                        </div>\n                        </li>");
        elenco.innerHTML += li;
    }
}
