/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <stdio.h>

int main()
{   
    float a  = 10;
    float b = 20;
    float c = 25;
    
    if(a <= b + c && b <= a +c && c < a + b){
        printf("E triangulo");
    }else{
        printf("Não e triangulo");
    }

    return 0;
}
