function validar(usuario, senha) {
    if (usuario === "admin" && senha==="1234") {
       window.open("file:///C:/Users/Flavio%20Luna/OneDrive/Documentos/estudos/app-luna/cadastro.html");
    } else if(usuario==="aluno" && senha==="uninove") {    
       window.open("https://www.uninove.br/");
    } else {
       alert('Dados Incorretos... Tente Novamente !!!!');
    }
 }
