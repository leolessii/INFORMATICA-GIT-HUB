var Json = /** @class */ (function () {
    function Json() {
    }
    Json.prototype.Save = function (data) {
        var JsonData = { string: data };
        var JsonString = JSON.stringify(JsonData);
        JSON.parse(JsonString);
        localStorage.setItem("activity", data);
    };
    Json.prototype.ReadJson = function () {
        var jsonString = localStorage.getItem("activity");
        if (jsonString != null) {
            //alert("non null");
            //alert(jsonString);
            return jsonString;
        }
        else {
            //alert("null");
            return null;
        }
    };
    return Json;
}());
function ButtonSave() {
    var data = document.getElementById("input");
    var JsonObject = new Json();
    JsonObject.Save(data.value);
}
function AggiornaLista() {
    var JsonObject = new Json();
    document.getElementById("list").innerHTML += "<li class=\"list-group-item active\" aria-current=\"true\"> ".concat(JsonObject.ReadJson(), " </li>");
}
