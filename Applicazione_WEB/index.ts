class Json
{    
    public constructor() {

    }
    public Save(data: string) :void
    {
        var JsonData = { string: data };
        var JsonString = JSON.stringify(JsonData);
        
        JSON.parse(JsonString);

        if(localStorage.getItem("activity")!= null)
        {
            const dataFromLocalStorage = localStorage.getItem("activity");
        }
        localStorage.setItem("activity", data);
    }
    
    public ReadJson(): any
    {
        const jsonString = localStorage.getItem("activity");

        if(jsonString != null)
        {
            //alert("non null");
            //alert(jsonString);
            return jsonString;
        }
        else
        {
            //alert("null");
            return null;
        }
    }
}

function ButtonSave()
{
    const data = document.getElementById("input") as HTMLInputElement;
    let JsonObject = new Json();
    JsonObject.Save(data.value);
}

function AggiornaLista()
{
    let JsonObject = new Json();
    document.getElementById("list")!.innerHTML += `<li class="list-group-item active" aria-current="true"> ${JsonObject.ReadJson()} </li>`;
}



