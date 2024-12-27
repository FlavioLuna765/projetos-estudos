function validar() {
    if (usuario === "admin" && senha==="123456") {
        Window.open("restrito.html");
    } else {
        alert('acesso negado');
    }
}

