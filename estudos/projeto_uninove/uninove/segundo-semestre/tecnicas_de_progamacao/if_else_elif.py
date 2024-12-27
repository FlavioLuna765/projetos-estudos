/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <stdio.h>

int main()
{   
    float nota = 5;
    
    if (nota >= 6) {
        printf("Aprovado");
    }else if (nota < 6 && nota > 4) {
        printf("Reprovado");
    
    }else {
        printf("Recuperação");
    }

    return 0;
}

/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <stdio.h>

int main()
{
    float nota;
    float media;
    
    printf("Digite uma nota \n");
    scanf("%f",&nota);
    printf("Digite uma nota \n");
    scanf("%f",&nota);
    
    if (nota >= 6) {
        printf("Aprovado");
        
    }else if (nota < 6 && nota > 4) {
        printf("Reprovado");
    
    }else {
        printf("Recuperação Estude mais !!!!!!");
    }
    

    return 0;
}

