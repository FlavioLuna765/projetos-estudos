function logar() {
    var login = document.getElementById('login').value;
    var senha = document.getElementById('senha').value;

    if (login == "admin" && senha == "admin") {
        alert('Sucesso !');
        location.href = "homepage.html";
    } else {
        alert('Usuário e senha incorretos!!!!');
    }
}