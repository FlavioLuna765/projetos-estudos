function validar(cliente, senha) {
    if (cliente==="admin" && senha==="1234") {
        Window.open("https://www.pexels.com/pt-br/");
     } else if(cliente==="aluno" && senha==="uninove") {
        window.open("https://www.uninove.br/");
     } else if(cliente==="pexels" && senha==="imagens") {
        window.open("https://www.pexels.com/pt-br/")
     }
     else {
        alert('Acesso Negado');
    }
}
