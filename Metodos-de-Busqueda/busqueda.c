#include <stdio.h>
#include <stdlib.h>
#include "busqueda.h"
#include "arbol.h"

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
  system( "clear" );
  printf( "Vamo' a buscar :v\n" );
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
      index = busquedaLineal( A , n , num );
      if( index != -1 )
        printf("Se encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("No esta el numero prro :'v\n'");
      break;
    case 2:
      index = busquedaBinaria( A , n , num );
      if( index != -1 )
        printf("Se encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("No esta el numero prro :'v\n'");
      break;
    case 3:
      index = aBB( A, n, num );
      if( index != -1 )
        printf("Se encontro el numero %d sobre el arbol.\n",num);
      else
        printf("No esta el numero prro :'v\n'");
      break;
    default:
      printf("Khe? :v\n");
      break;
  }
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
