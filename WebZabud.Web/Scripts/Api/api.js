function obtenerDatos() {
    let url = 'http:/localhost:56182/api/products';
    const api = new XMLHttpRequest();
    api.open('GET', url, true);
    api.withCredentials = true;
    api.setRequestHeader("Access-Control-Allow-Origin","http:/localhost:56182/api/products");
    api.send();
    api.onreadystatechange = function () {
        console.log(this.getAllResponseHeaders);
        //if (this.status === 200 && this.readyState === 4) {
        //    let datos = Json.Parse(this.responseText);
        //    console.log(datos);
        //}
    };


}

$(document).ready(function () {
    obtenerDatos();
});