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
	int* A = NULL;
	int op;
	system("clear");
	printf("\nIngresa la cantidad de números a ordenar:");
	scanf("%d",&n);
	tam = n;
	A = (int*)malloc(n*sizeof(int));
	FILE* numeros = fopen("numeros10millones.txt", "r");
	while (feof(numeros)==0 && i < n)
	     	{
	           fscanf(numeros,"%d",&A[i]);
	           i++;
	       }
	fclose(numeros);
	printf("Métodos de ordenamiento:\n1 -- Burbuja\n2 -- Burbuja mejorada\n");
	printf("3 -- Insercion\n4 -- Seleccion\n5 -- Shell\n6 -- ABB\n");
	printf("Selecciona el metdodo que deseas utilizar:\t");
	scanf("%d",&op);
	uswtime(&utime0, &stime0, &wtime0);
	A = opcion(A,n,op);
	uswtime(&utime1, &stime1, &wtime1);
	imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, tam, A, op );
}
