class Json
{
    public activity: string
    
    public Save(data: string) :void
    {
        var JsonData = { string: data };
        var JsonString = JSON.stringify(JsonData);
        
        JSON.parse(JsonString);
        localStorage.setItem("activity", this.activity);
    }
    
    public ReadJson(): any
    {
        const jsonString = localStorage.getItem("activity");

        if(jsonString)
        {
            return JSON.parse(jsonString);
        }
        else
        {
            return null;
        }
    }
}

function ButtonSave()
{
    const data = document.getElementById("input")!.innerText;
    localStorage.setItem("activity", data);
    alert(data.toString())
}

function AggiornaLista()
{
    document.getElementById("list")!.innerHTML += `<li class="list-group-item active" aria-current="true"> ${localStorage.getItem("activity")} </li>`;
}



