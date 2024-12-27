function validar(usuario, senha) {
    if (usuario === "admin" && senha==="1234") {
       window.open("restrito.html");
    } else if(usuario==="aluno" && senha==="uninove") {    
       window.open("https://www.uninove.br/");
    } else {
       alert('Acesso negado');
    }
 }