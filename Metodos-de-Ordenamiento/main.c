#include <stdio.h>
#include <stdlib.h>
#include "arbol.h"
#include "metodos.h"
#include "tiempo.h"

int 
main( void )
{
	double utime0;
	double stime0;
	double wtime0;
	double utime1;
	double stime1; 
	double wtime1;
	int n;
	int tam;
	int i=0;
	int* A;
	printf("Ingresa la cantidad de números a ordenar:");
	scanf("%d",&n);
	tam = n;
	A = (int*)malloc(n*sizeof(int));
	FILE* numeros = fopen("/home/ivanovsky/Algorythms-Analisis/Sort-Methods/numeros.txt", "rb");
	while (feof(numeros)==0 && i < n)
      	{
            fscanf(numeros,"%d",&A[i]);
            i++;
        }
	uswtime(&utime0, &stime0, &wtime0);
	burbuja(A, n);
	uswtime(&utime1, &stime1, &wtime1);
	imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, tam );
}
