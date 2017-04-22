#include <stdio.h>
#include <stdlib.h>
#include "arbol.h"
#include "tiempo.h"
#include "busqueda.h"

int
aBB1 ( int* A, int n, int num )
{
  double utime0;
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  printf("\n\tCreando arbol\n");
  struct nodo *miRaiz;
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo));
  miRaiz = NULL;
  int clave;
  int a;
  for( int i = 0 ; i < n ; i++ )
    {
	  clave = A[i];
	  insertar (&miRaiz, clave);
    }
  printf("\tSe creo el arbol\n");
  uswtime(&utime0, &stime0, &wtime0);
  a = buscarABB(miRaiz, num );
  uswtime(&utime1, &stime1, &wtime1);
  imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, 4, num, n, a  );
  return a;
}

int
aBB2 ( int* A, int n )
{
  double utime0;
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  int i;
  int numeros[20] = {322486, 14700764, 3128036, 6337399, 61396, 10393545, 2147445644,
                  1295390003, 450057883, 187645041, 1980098116, 152503, 5000,
                  1493283650, 214826, 1843349527, 1360839354, 2109248666,
                  2147470852, 0};
  printf("\n\tCreando arbol\n");
  struct nodo *miRaiz;
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo));
  miRaiz = NULL;
  int clave;
  int a;
  for( i = 0 ; i < n ; i++ )
    {
	  clave = A[i];
	  insertar (&miRaiz, clave);
    }
  printf("\tSe creo el arbol\n");
  for( i = 0 ; i < 20 ; i++ )
  {
    uswtime(&utime0, &stime0, &wtime0);
    a = buscarABB(miRaiz, numeros[i] );
    uswtime(&utime1, &stime1, &wtime1);
    imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, 3, numeros[i], n, a  );
  }
  return a;
}

void
insertar (struct nodo **Raiz, int miDato1)
{
  struct nodo **aux = NULL;
  aux = Raiz;
  if (*Raiz == NULL)
    {
      *Raiz = nuevoNodo (miDato1);
    }
  else
  {
    while (*aux != NULL)
    {
      if (miDato1 < (*aux)->dato)
      {
        aux = &((*aux)->Izq);
      }
      else if (miDato1 > (*aux)->dato)
      {
        aux = &((*aux)->Der);
      }
      else
      {
        break;
      }
    }
    *aux = nuevoNodo (miDato1);
  }
}

struct nodo *
nuevoNodo (int dato1)
{
  struct nodo *Nuevo;
  Nuevo = (struct nodo *) malloc (sizeof (struct nodo));
  Nuevo->dato = dato1;
  Nuevo->Izq = Nuevo->Der = NULL;
  return Nuevo;
}

int
buscarABB(struct nodo *Raiz, int num)
{
  if( Raiz == NULL )
    {
        return -1;
    }
  if( num == Raiz->dato )
   {
        return 0;
   }
   if( num > Raiz->dato )
    {
	     return buscarABB( Raiz->Der, num );
    }
    else
    {
        return buscarABB( Raiz->Izq, num );
    }
return -1;
}
