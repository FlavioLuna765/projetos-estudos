public class Carro {

    // PROPRIEDADES DOS ATRIBUTOS
	String marca;
    String modelo;
    String cor;
    int km;
    int capacidadeTanque;
    int kmPorLitro;
    double preco;
    double desconto;
    
    // METODO PARA CALCULAR FUNÇÃO
    int calcularkm() {
    	return capacidadeTanque*kmPorLitro;
    }
    
    double calcularDesconto(double percentualDescontoVendedor) {
    	
    	if(percentualDescontoVendedor <= 0 && percentualDescontoVendedor >= 4) {
    		return preco * (percentualDescontoVendedor / 100);
    		
    	}else if (percentualDescontoVendedor < 0) {
    		return 0.0;
    		
    	}else {
    		return preco * 0.04;
    	}
    }
    
}
