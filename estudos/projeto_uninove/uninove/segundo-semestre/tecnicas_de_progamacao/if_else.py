int main()
{
    int idade;
    
    printf("Digite sua idade \n");
    scanf("%d", &idade);
    
    if (idade < 18){
        printf("menor de idade");
    }else{
        printf("maior de idade");
    }
        
    return 0;
}


//
a || b && b !(b || !a)

int main()
{
    int a = 0;
    int b = 1;
    
    if(a || b && !(b || !a)){
        printf("True");
    }else{
        printf("False");
    }

    return 0;
}
