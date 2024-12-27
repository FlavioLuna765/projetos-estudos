/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//#include <stdio.h>

int main()
{

    char nome1[] = "Flavio";
    char nome2[] = "Flavia";
    float idade1, idade2, media;
    
    printf("Digite nome1 \n");
    scanf("%s", nome1);
    printf("Digite idade1 \n");
    scanf("%f", &idade1);
    printf("Digite nome2 \n");
    scanf("%s", nome2);
    printf("Digite idade2 \n");
    scanf("%f", &idade2);
    
    media = (idade1 + idade2) / 2;
    
    printf("%s e %s tem a media de idade de %.2f", nome1,nome2,media);
    

    return 0;
}


