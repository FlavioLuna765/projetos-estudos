function corrigir() {

    var pontos = 0;
    if (document.prova.rq1[1].checked) {
        pontos = pontos + 3;
    }

    if (document.prova.rq2[0].checked) {
        pontos = pontos + 3;

    }

    if (document.prova.rq3[3].checked) {
        pontos = pontos + 4;
    }

    if (pontos <= 6) {
        document.getElementById("exibe").innerHTML = "Sua nota foi " + pontos + " Voce foi REPROVADO...!";
    } else {
        document.getElementById("exibe").innerHTML = "Sua nota foi " + pontos + " Voce foi APROVADO...!";
    }

}