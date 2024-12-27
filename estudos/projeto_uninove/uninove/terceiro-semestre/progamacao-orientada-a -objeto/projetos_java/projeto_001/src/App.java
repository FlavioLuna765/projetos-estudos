public class App {
    public static void main(String[] args) throws Exception {
        //System.out.println("Hello World , Bem vindo Flávio Luna !!! ");
        Carro novoCarro = new Carro();
				
				// insere as informacoes dentro do objeto;
				novoCarro.marca = "VW";
				novoCarro.modelo = "FOX";
				novoCarro.cor = "AZUL";
				novoCarro.km = 15560;
				novoCarro.preco = 32000;
				novoCarro.desconto = 10;
				
				// perde o codigo perde a referencia (novoCarro = null;)
				
				// msotrar as informacoes do objeto;-
				System.out.println("Marca : " + novoCarro.marca);
				System.out.println("modelo : " + novoCarro.modelo);
				System.out.println("cor : " + novoCarro.cor);
				System.out.println("km : " + novoCarro.km);
				System.out.println("preço : " + novoCarro.preco);
				System.out.println("Desconto : " + novoCarro.calcularDesconto(5.5));
                
    }
}
