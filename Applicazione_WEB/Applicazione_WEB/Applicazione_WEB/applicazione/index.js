var Json = /** @class */ (function () {
    function Json() {
    }
    Json.prototype.Save = function (data) {
        var JsonData = { string: data };
        var JsonString = JSON.stringify(JsonData);
        JSON.parse(JsonString);
        localStorage.setItem("activity", this.activity);
    };
    Json.prototype.ReadJson = function () {
        var jsonString = localStorage.getItem("activity");
        if (jsonString) {
            return JSON.parse(jsonString);
        }
        else {
            return null;
        }
    };
    return Json;
}());
function ButtonSave() {
    var data = document.getElementById("input").innerText;
    localStorage.setItem("activity", data);
    alert(data.toString());
}
function AggiornaLista() {
    document.getElementById("list").innerHTML += "<li class=\"list-group-item active\" aria-current=\"true\"> ".concat(localStorage.getItem("activity"), " </li>");
}
