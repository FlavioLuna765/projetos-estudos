// C++ code
//
/*
	teste de if - else
    Autor: João Vagner
    data: 15/03
    versão 1.0
*/
#define CHAVE1 	10
#define LEDVM	13
#define CHAVE2 	4
#define LEDVD	2

int memo_LEDVM;

void setup()
{
  pinMode(LEDVM, OUTPUT);
  pinMode(LEDVD, OUTPUT);
  pinMode(CHAVE1, INPUT);
  pinMode(CHAVE2, INPUT);
}

void loop()
{
  if(digitalRead(CHAVE1)==false){ // le a chave 1
    if(memo_LEDVM==true){  // se a memoria for verdade
      memo_LEDVM=false;    // coloca a memoria em falso
      digitalWrite(LEDVM,LOW);  // apaga led vermelho
    }
    else{                   //(se nao verdade )=se memoria falso
      memo_LEDVM=true;          // memoria verdade
  	  digitalWrite(LEDVM,HIGH);  // acende led vermelho
    }   
  }
  
}