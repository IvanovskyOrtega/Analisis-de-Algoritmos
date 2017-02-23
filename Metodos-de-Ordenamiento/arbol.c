#include <stdio.h>
#include <stdlib.h>
#include "arbol.h"

int *
aBB (int* A, int n)
{
  struct nodo *miRaiz;
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo));
  miRaiz = NULL;
  int clave;
  for( int i = 0 ; i < n ; i++ )
    {
	  clave = A[i];
	  insertar (&miRaiz, clave);
    }
  A = inordenSecuencial (miRaiz, A);
	return A;
}

int * 
inordenSecuencial(struct nodo *Raiz, int* A)
{
	int i=0;
	struct nodo *Cur, *Pre;

	if(Raiz==NULL)
		return A;

	Cur = Raiz;
	while(Cur != NULL)
	{
		if(Cur->Izq == NULL)
		{
			A[i]=Cur->dato;
			Cur= Cur->Der;
		}
		else
		{
			Pre = Cur->Izq;
			while(Pre->Der !=NULL && Pre->Der != Cur)
				Pre = Pre->Der;

			if (Pre->Der == NULL)
			{
				Pre->Der = Cur;
				Cur = Cur->Izq;
			}
			else
			{
				Pre->Der = NULL;
				A[i]=Cur->dato;
				Cur = Cur->Der;
			}
		}
		i++;
	}
	return A;
}

void
insertar (struct nodo **Raiz, int miDato1)
{
  if (*Raiz == NULL)
    *Raiz = nuevoNodo (miDato1);
  else if (miDato1 < (*Raiz)->dato)
    insertar (&((*Raiz)->Izq), miDato1);
  else
    insertar (&((*Raiz)->Der), miDato1);
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
