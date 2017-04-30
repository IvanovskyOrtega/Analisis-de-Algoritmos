#include <stdio.h>
#include <stdlib.h>
#include "arbol.h"

/**
  Esta función inserta los elementos de un arreglo de números a un árbol
  de búsqueda binaria, para posteriormente realizar el recorrido inorden
  y regresar el arreglo con los números ordenados.
  Recibe como argumentos:
  	int *A: El arreglo con los números desordenados
  	int n: El tamaño del arreglo A
  Regresa:
  	El arreglo con los números ordenados.
  Posibles errores:
  	Falta de memoria para la creación del árbol (no reportado durante 
	las pruebas hechas).
*/
int *
aBB (int* A, int n)
{
  struct nodo *miRaiz; // Declaramos la variable raíz de tipo struct nodo*
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo)); // Reservamos la memoria suficiente para la variable
  miRaiz = NULL;  // Inicializamos la raiz en NULL	
  for( int i = 0 ; i < n ; i++ )
    {
	  insertar (&miRaiz, A[i]); // Se insertan los elementos del arreglo en el árbol
    }
  A = inordenSecuencial (miRaiz, A); // Se realiza el recorrido inorden del árbol para ordenar el arreglo
  return A; // Regresamos el arreglo ordenado
}

/**
  Este método realiza el recorrido inorden sobre el árbol binario de búsqueda
  el cuál nos permitirá ordenar los elementos del arreglo que se recibe como
  parámetro, de menor a mayor.
  Recibe como argumentos:
  int *A: Arreglo de números a ordenar de tamaño n
  struct nodo *Raiz: La raíz de árbol a recorrer, el cúal contiene los números
  del arreglo
  Regresa:
  El arreglo *A con los números ordenados
  Posibles errores:
  Algún error en la creación del árbol, que hasta el momento no se ha presentado
  durante las ejecuciónes realizadas en las pruebas.
  Falta de memoria para las variables (no reportado al momento).
*/
int * 
inordenSecuencial(struct nodo *Raiz, int *A)
{
	int i=0;	// Contador para el arreglo
	struct nodo *Aux, *Rec;	// Aux es un puntero auxiliar, Rec es un puntero auxiliar para el recorrido 
	Aux = Raiz;	// Igualamos los punteros Aux y Raiz
	while(Aux != NULL)	// Mientras la raíz no sea nula
	{
		if(Aux->Izq == NULL)	// No hay subárboles a la izquierda de la raíz
		{
			A[i] =Aux->dato;  // Sacamos el elemento del nodo actual y lo metemos al arreglo
			Aux= Aux->Der;	// Nos movemos al subárbol derecho
			i++;	// Incrementamos el contador del arreglo
		}
		else	// Si hay subárboles izquierdos
		{
			Rec = Aux->Izq;	// Rec es igual al nodo hijo izquierdo del padre actual
			while(Rec->Der !=NULL && Rec->Der != Aux)	// Recorrido sobre el subárbol derecho del nodo actual
				Rec = Rec->Der;	// Empezamos a recorrer el subárbol todo a la derecha

			if (Rec->Der == NULL)	// Si se llego al último nodo más a la derecha del subárbol
			{
				Rec->Der = Aux;	// Agregamos referencia entre el nodo Rec actual y el nodo Aux 
						// actual para el recorrido de regreso.
				Aux = Aux->Izq;	// Nos movemos al subárbol izquierdo del nodo auxiliar actual
			}
			else	// Si ya recorrimos todos los subárboles a la izquierda del nodo actual
			{
				Rec->Der = NULL;	// Eliminamos la referencia entre el nodo
							// más a la derecha de los subárboles
							// izquierdos y el nodo actual
				A[i] =Aux->dato;	// Remplazamos el valor del arreglo por
							// el valor del nodo actual
				Aux = Aux->Der;		// Nos movemos al subárbol derecho o
							// hacia el nodo referenciado en caso de
							// ser nodo más a la derecha de los
							// subárboles izquierdos del nodo actual
				i++;			// Incrementamos el contador del arreglo
			}
		}
	}
	return A;	// Se regresa el arreglo ordenado
}

/**
  Este método realiza la inserción de un elemento en el árbol binario
  de búsqueda de forma iterativa.
  Recibe: 
    struct nodo **Raiz: Una referencia al nodo raíz del árbol.
    int miDato1: El valor del número a ingresar en el nodo del árbol
  Función void no regresa elementos.
  Posibles errores: 
    Falta de memoria para la creación del nodo (no reportado durante
    las pruebas hechas).
*/
void
insertar (struct nodo **Raiz, int miDato1)
{
  struct nodo **aux = NULL;	// Creamos un nodo auxiliar
  aux = Raiz;	// Igualamos el nodo auxiliar a la raiz para no hacer modificaciones a la raíz original
  if (*Raiz == NULL)	// Si no hay elementos en el árbol
    {
      *Raiz = nuevoNodo (miDato1);	// Creamos un nuevo nodo
    }
  else	// Si hay elementos en el árbol
  {
    while (*aux != NULL)	// Hasta encontrar la posición adecuada para el nuevo nodo
    {
      if (miDato1 < (*aux)->dato)	// Si el número a ingresar el menor al número en aux
      {
        aux = &((*aux)->Izq);	// Ir al hijo izquierdo del padre aux actual
      }
      else if (miDato1 > (*aux)->dato) // Si el número a ingresar el mayor al número en aux
      {
        aux = &((*aux)->Der); // Ir al hijo derecho del padre aux actual
      }
    }
    *aux = nuevoNodo (miDato1); // Si ya se llegó a la posición adecuada, agrega el nuevo nodo
  }
}

/**
  Esta función se encarga de crear un nodo para el árbol.
  Recibe:
    int dato1: El número que almacenará el nodo
  Regresa: 
    El nodo de tipo struct nodo*
  Posibles errores:
    Falta de memoria para la creación del nodo (no se presentó
    durante la ejecución de las pruebas).
*/
struct nodo *
nuevoNodo (int dato1)
{
  struct nodo *Nuevo;	// Declaramos la variable de tipo struct nodo*
  Nuevo = (struct nodo *) malloc (sizeof (struct nodo)); // Reservamos la memoria suficiente
  Nuevo->dato = dato1; // Guardamos el número en el nodo
  Nuevo->Izq = Nuevo->Der = NULL; // Sin hijos
  return Nuevo;	// Regresamos el nuevo nodo
}
