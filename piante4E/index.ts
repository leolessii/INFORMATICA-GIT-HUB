class Pianta 
{
    id:number 
    nome: string
    prezzo : number
    tot: number //identifica il numero di piante che in questo momento sono in procinto di essere servite
}

class Ordine
{
    id: number
    idPianta: number
    stato: "ordinata" | "consegnata"
}

const catalogo: Pianta[] = [
    {id:0, nome:"Anthurium", prezzo:54.00, tot:0},
    {id:1, nome:"Azalea", prezzo:48.00, tot:0},
    {id:2, nome:"Orchidea", prezzo:68.50, tot:0},
    {id:3, nome:"Spathiphyllum", prezzo:38.00, tot:0},
    {id:4, nome:"Kroton", prezzo:54.00, tot:0}
]

mostraCatalogo(catalogo)

function mostraCatalogo(catalogo: Pianta[])
{
    var elenco = document.getElementById("elencoPiante")

    elenco!.innerHTML = ``

    for (var pianta of catalogo)
        {
            var li = `<li calss="list-group-item d-flex justify-content-between align-items-start">
                        <div class ="ms-2 me-auto>
                            <div class="fw-bold">${pianta.nome}
                                <span calss="badge text-bg-primary rounded-pill mx-1">0</span>
                            </div>
                        </div>
                        </li>`
            elenco!.innerHTML += li
        }
}