#include <stdio.h>
#include <stdlib.h>
#include "busqueda.h"
#include "arbol.h"
#include "tiempo.h"

void
leerNumeros( int* A, int n )
{
  int i = 0;
  system( "clear" );
  FILE *numeros = fopen( "10millones.txt" , "r" );
	while ( feof( numeros ) == 0 && i < n )
	{
	  fscanf( numeros , "%d" , &A[i] );
    i++;
	}
}

void
busqueda()
{
  int n;
  int* A;
  int op;
  int num;
  int index;
  double utime0;
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  system( "clear" );
  printf( "Practica 2: Algoritmos de Busqueda\n" );
  printf("\nTamaño del arreglo de busqueda:");
	scanf( "%d" , &n );
  A = (int*)malloc(n*sizeof(int));
  leerNumeros( A , n );
  printf("\nIngresa el número a buscar sobre el arreglo:\t");
  scanf("%d", &num );
  printf("\nSeleccionar el metodo de busqueda:\n");
  printf("(1)-Busqueda Lineal\n(2)-Busqueda Binaria\n(3)-Busqueda sobre un ABB\n");
  printf("Ingrese opcion:\t");
  scanf( "%d" , &op );
  switch( op )
  {
    case 1:
      uswtime(&utime0, &stime0, &wtime0);
      index = busquedaLineal( A , n , num );
      uswtime(&utime1, &stime1, &wtime1);
      if( index != -1 )
        printf("Se encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("No se encontro el numero.\n'");
      break;
    case 2:
      uswtime(&utime0, &stime0, &wtime0);
      index = busquedaBinaria( A , n , num );
      uswtime(&utime1, &stime1, &wtime1);
      if( index != -1 )
        printf("Se encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("No se encontro el numero.\n'");
      break;
    case 3:
      index = aBB( A, n, num );
      if( index != -1 )
        printf("Se encontro el numero %d sobre el arbol.\n",num);
      else
        printf("No se encontro el numero.\n'");
      break;
    default:
      printf("Opcion no valida.\n");
      break;
  }
  imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, op, num, n, index);
}

int
busquedaLineal( int* A, int n, int num )
{
  for( int i = 0 ; i < n ; i++ )
  {
    if( A[i] == num )
      return i;
  }
  return -1;
}

int
busquedaBinaria( int* A, int n, int num )
{
  int centro;
  int inf = 0;
  int sup = n-1;
  while ( inf <= sup )
  {
    centro = ( sup + inf )/2;
    if( A[centro] == num )
      return centro;
      else if( num < A[centro] )
        sup = centro - 1;
      else
        inf = centro + 1;
  }
  return -1;
}

void
imprimirResultados( double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int op, int num, int n, int index )
{
  FILE* resultados;
  resultados = fopen("resultados.txt", "a");
  if( op == 1 )
    fprintf(resultados,"Busqueda con el algoritmo de busqueda lineal\n");
  else if( op == 2 )
    fprintf(resultados,"Busqueda con el algoritmo de busqueda binaria\n");
  else
    fprintf(resultados,"Busqueda con el algoritmo de busqueda sobre un ABB\n");
  fprintf(resultados,"\n");
  fprintf(resultados,"\tSe busco el numero: %d, sobre un arreglo de %d numeros\n",num,n);
  if(index != -1)
    fprintf(resultados,"\tEl numero fue encontrado.\n");
  else
    fprintf(resultados,"\tEl numero no fue encontrado.\n");
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
  fclose(resultados);
}
