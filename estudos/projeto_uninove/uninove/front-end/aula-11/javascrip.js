function somar(sal, per) {
    var resultado;
    resultado = sal + (sal * per / 100);
    document.getElementById("dados").innerHTML = "O resultado da soma é "  + resultado ;
    
}