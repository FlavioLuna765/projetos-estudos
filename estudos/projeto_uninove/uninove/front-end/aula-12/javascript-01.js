/*
function checar(ddd) {
    if (ddd == "11") {
        document.write("São Paulo");
    } else if (ddd == 19) {
        alert("Campinas");
    }
}
*/

function checar(ddd) {
    switch (ddd) {
        case "11":
            alert("São Paulo");
            break;
        case "19":
            alert("Campinas");
            break;
        default:
            alert("não identificada");
    }
}
