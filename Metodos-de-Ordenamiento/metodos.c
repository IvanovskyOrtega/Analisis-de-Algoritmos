#include <stdio.h>
#include <stdlib.h>
#include "metodos.h"
#include "arbol.h"
#include "tiempo.h"

/*
	Esta funcion se encarga de escoger el método de acuerdo al argumento
	recibido por el programa main.
	Recibe:
		-int* A : Arreglo con números desordenados.
		-int n  : Tamaño del arreglo.
		-int op : El método a utilizar
	Regresa:
		El arreglo A ordenado de acuerdo al método.
*/
int *
opcion ( int* A, int n, int op )
{
	double utime0;	/* Variables para la medición de tiempo */
	double stime0;
	double wtime0;
	double utime1;
	double stime1;
	double wtime1;
	switch( op )
	{
		case 1:
			uswtime(&utime0, &stime0, &wtime0);	/* Comienza la medición de tiempo */
			A = burbuja( A , n);	         /* Se ejecuta el ordenamiento burbuja	*/
			uswtime(&utime1, &stime1, &wtime1);  /* Termina la medición de tiempo */
			/* Se imprimen los resultados a archivo. */
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;	/* Se regresa el arreglo con los números ordenados */
		case 2:
			uswtime(&utime0, &stime0, &wtime0);
			A = burbuja_Mejorada( A , n );	/* Se ejecuta el ordenamiento burbuja mejorada */
			uswtime(&utime1, &stime1, &wtime1);
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;
		case 3:
			uswtime(&utime0, &stime0, &wtime0);
			A = insercion( A , n );	/* Se ejecuta el ordenamiento por inserción */
			uswtime(&utime1, &stime1, &wtime1);
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;
		case 4:
			uswtime(&utime0, &stime0, &wtime0);
			A = seleccion( A , n );	/* Se ejecuta el ordenamiento por delección */
			uswtime(&utime1, &stime1, &wtime1);
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;
		case 5:
			uswtime(&utime0, &stime0, &wtime0);
			A = shell( A , n );	/* Se ejecuta el ordenamiento Shell */
			uswtime(&utime1, &stime1, &wtime1);
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;
		case 6:
			uswtime(&utime0, &stime0, &wtime0);
			A = aBB( A , n );	/* Se ejecuta el ordenamiento con un árbol binario de busqueda */
			uswtime(&utime1, &stime1, &wtime1);
			imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, n, A, op );
			return A;
		default:
			printf("\nOpcion invalida :(\n");	/* Opción inválida */
			return A;

	}
}

/*
	Este método se encarga de ordenar los elementos de un arreglo utilizando
	el ordenamiento burbuja.
	Recibe:
		-int *A : Arreglo con los números desordenados.
		-int n  : Tamaño del arreglo
	Regresa:
		-El arreglo A ordenado.
*/
int *
burbuja(int *A, int n)
{
  int pos1=1;
  int pos2=0;
  int temp=0;
  while(pos1<n) /* Controla el número de recorridos sobre el arreglo */
  {
    pos2=0;	/* Empezamos a comparar desde el primer elemento*/
    while(pos2<n-1)	/* Nos aseguramos de no salir de los limites del arreglo */
    {
      if(A[pos2]>A[pos2+1])	/* Comparamos el elemento en pos2 y el de pos2+1 */
      {	/* Si el primer elemento comparado es mayor al segundo */
        temp=A[pos2];	/* Se realiza el swap de los elementos */
        A[pos2]=A[pos2+1];
				A[pos2+1]=temp;
      }
      pos2++;	/* Incrementamos el contador de pos2 */
    }
    pos1++;	/* Volvemos a rrecorrer el arreglo */
  }
  return A; /* Regresamos el arreglo ordenado */
}

/*
	Esta función realiza el ordenamiento de un arreglo utilizando el método de
	ordenamiento burbuja en su versión mejorada.
	Recibe:
		-int *A : El arreglo con los números desordenados.
		-int n  : El tamaño del arreglo,
	Regresa:
		-El arreglo A con sus elementos ordenados.
*/
int *
burbuja_Mejorada(int *A, int n)
{
  int pos1=1;	/* Contador para recorrer el arreglo */
  int pos2=0;	/*  */
  int temp=0;
  while(pos1<n)	/* Controla el número de recorridos sobre el arreglo */
  {
    pos2=0;	/* Se empieza a comparar desde el primer elemento con el que esta en pos1 */
    while(pos2<pos1)	/*  Para comparar solo con los elementos que estan antes de A[pos1] */
    {
      if(A[pos1]<A[pos2])	/* Se comparan los elementos */
      {
        temp=A[pos2];	/* Se realiza el intercambio */
        A[pos2]=A[pos1];
				A[pos1]=temp;
      }
      pos2++;	/* Incrementamos el contador */
    }
    pos1++;	/* Incrementa pos1 hasta llegar al ultimo elemento */
  }
  return A; /* Regresamos el arreglo ordenado */
}

/*
	Este metodo se encarga de ordenar los elementos de un arreglo utilizando el
	ordenamiento por inserción.
	Recibe:
		-int *A : El arreglo con los números desordenados.
		-int n  : El tamaño del arreglo,
	Regresa:
		-El arreglo A con sus elementos ordenados.
*/
int *
insercion(int *A, int n)
{
  int pos1=1;
  int pos2=0;
  int temp=0;
  while(pos1<n)	/* Evitamos salir de los limites del arreglo */
  {
    temp=A[pos1];	/* Igualamos la variable temp a el elemento en A[pos1] */
    pos2=pos1-1;	/* El indice pos2 será el anterior de pos1 */
    for(;(A[pos2]>temp)&&(pos2>=0);pos2--)	/* Se rompe hasta que A[pos2] sea mayor a temp y que pos2>=0 */
    {	/* Equivale a while((A[pos2]>temp)&&(pos2>=0)) y se decrementa el indice dentro del while */
      A[pos2+1]=A[pos2];	/* Intercambia los elementos */
    }
    A[pos2+1]=temp;	/* Intercambia temp con el elemento en pos2+1, donde se rompió el loop */
    pos1++;	/* Incrementamos el contador pos1 */
  }
  return A;	/* Regresamos el arreglo ordenado */
}

/*
	Este metodo se encarga de ordenar los elementos de un arreglo utilizando el
	ordenamiento por seleccion.
	Recibe:
		-int *A : El arreglo con los números desordenados.
		-int n  : El tamaño del arreglo,
	Regresa:
		-El arreglo A con sus elementos ordenados.
*/
int *
seleccion(int *A, int n)
{
  int pos1=0;
  int pos2=0;
  int pos3=0;
  int temp;
  while(pos1<n-1) /* Evitamos salir de los limites del arreglo */
  {
    pos2=pos1;	/* Se compara desde el elemento en pos1 (Empezando por 0, y cambia cuando incrementa) */
    pos3=pos1+1;	/* El indice pos3 será el siguiente elemento a pos1 y pos2 */
    while(!(pos3>n-1))	/* Evitamos salir de los limites del arreglo */
    {
      if(A[pos3]<A[pos2])	/* Si el elemento en pos3 es mayor a el de pos2 */
      {
        pos2=pos3;	/* Guardamos la posición */
      }
			pos3++;	/* Incrementamos pos3 */
    }
    if(pos2!=pos1)	/* Si pos2 y pos1 no tienen el mismo indice */
    {	/* Significa que encontramos un elemento mínimo */
      temp=A[pos2];	/* Intercambiamos los elementos */
      A[pos2]=A[pos1];
      A[pos1]=temp;
    }
    pos1++;	/* Incrementamos pos1 */
  }
  return A;	/* Regresamos el arreglo ordenado */
}

/*
	Este metodo se encarga de ordenar los elementos de un arreglo utilizando el
	ordenamiento Shell.
	Recibe:
		-int *A : El arreglo con los números desordenados.
		-int n  : El tamaño del arreglo,
	Regresa:
		-El arreglo A con sus elementos ordenados.
*/
int *
shell(int *A, int n)
{
  int gap;
  int i;
  int j;
  int temp;
  for (gap = n/2 ; gap > 0 ; gap /= 2) /* Partimos el arreglo en 2 por cada iteración */
	{
     for (i = gap; i < n ; i++) /* Recorre la parte superior de los subarreglos */
		 {
         for (j = i-gap ; j >= 0 && A[j] > A[j+gap] ; j -= gap) /* Recorre la parte inferior de los subarreglos */
				 {	/* Si encuentra un elemento menor en la parte superior */
             temp = A[j];	/* Se hace el intercambio */
             A[j] = A[j+gap];
             A[j+gap] = temp;
            }
        }
  }
  return A;	/* Regresamos el arreglo ordenado */
}

/*
	Esta función se encarga de imprimir los resultados a un archivo.
	Recibe:
		-double utime0: Tiempo de procesamiento en CPU (inicial)
		-double stime0:	Tiempo en acciónes de E/S (inicial)
		-double wtime0: Tiempo total (inicial)
		-double utime1: Tiempo de procesamiento en CPU (final)
		-double stime1:	Tiempo en acciónes de E/S (final)
		-double wtime1: Tiempo total (final)
		-int n        :	Tamaño del arreglo
		-int *A       : Arreglo ordenado
		-int op       : Método que se usó para ordenarlo
*/
void
imprimirResultados( double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int n, int* A, int op )
{
	FILE* resultados;
	resultados = fopen("resultados.txt", "a");
	if(op == 1)
		fprintf(resultados,"Ordenar %d numeros con el método Burbuja Simple:", n);
	else if(op == 2)
		fprintf(resultados,"Ordenar %d numeros con el método Burbuja Mejorada:", n);
	else if(op == 3)
		fprintf(resultados,"Ordenar %d numeros con el método Inserción:", n);
	else if(op == 4)
		fprintf(resultados,"Ordenar %d numeros con el método Selección:", n);
	else if(op == 5)
		fprintf(resultados,"Ordenar %d numeros con el método Shell:", n);
	else if(op == 6)
		fprintf(resultados,"Ordenar %d numeros con el método por ABB:", n);
	fprintf(resultados,"\n");
	fprintf(resultados,"\tFormato exponencial:\n");
	fprintf(resultados,"\tReal (Tiempo total)  %.10e s\n",  wtime1 - wtime0);
	fprintf(resultados,"\tUser (Tiempo de procesamiento en CPU) %.10e s\n",  utime1 - utime0);
	fprintf(resultados,"\tSys (Tiempo en acciónes de E/S)  %.10e s\n",  stime1 - stime0);
	fprintf(resultados,"\tCPU/Wall   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	fprintf(resultados,"\n");
	fprintf(resultados,"\n");
	fprintf(resultados,"\tFormato segundos:\n");
	fprintf(resultados,"\tReal (Tiempo total)  %.10f s\n",  wtime1 - wtime0);
	fprintf(resultados,"\tUser (Tiempo de procesamiento en CPU) %.10f s\n",  utime1 - utime0);
	fprintf(resultados,"\tSys (Tiempo en acciónes de E/S)  %.10f s\n",  stime1 - stime0);
	fprintf(resultados,"\tCPU/Wall   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	fprintf(resultados,"\n");
	// Decomentar lo siguiente si se quiere ver que el arrelgo fue ordenado
	/*
	for( int i = 0 ; i < n  ; i++)
	{
		fprintf(resultados, "\t%d)\t%d\n",i+1,A[i]);
	}
	*/
	fclose(resultados);
}
