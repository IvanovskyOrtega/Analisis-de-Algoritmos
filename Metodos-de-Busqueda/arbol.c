#include <stdio.h>
#include <stdlib.h>
#include "arbol.h"
#include "tiempo.h"
#include "busqueda.h"

/**
 * Esta función inserta los elementos de un arreglo de números a un árbol
 * de búsqueda binaria, para posteriormente realizar la búsqueda de un número 
 * sobre el árbol.
 * Recibe como argumentos:
 * 	int *A: El arreglo con los números desordenados
 * 	int n: El tamaño del arreglo A
 *	int num: Número a buscar en el árbol
 * Regresa:
 * 	0 si fue encontrado, -1 en caso contrario.
 * Posibles errores:
 * 	Falta de memoria para la creación del árbol (no reportado durante
 *	las pruebas hechas).
 */  * /
  int
aBB1 (int *A, int n, int num)
{
  double utime0;		// Variables usadas para la medición de tiempo
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  printf ("\n\tCreando arbol\n");
  struct nodo *miRaiz;		// Creamos el nodo raíz
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo));	// Reservamos memoria para la raíz
  miRaiz = NULL;		// Inicializamos en NULL
  int a;			// Variable utilizada para saber si encontró el número
  for (int i = 0; i < n; i++)
    {
      insertar (&miRaiz, A[i]);	// Se realiza la inserción de los elementos del arreglo en el árbol
    }
  printf ("\tSe creo el arbol\n");
  uswtime (&utime0, &stime0, &wtime0);	// Comienza la medición de tiempo
  a = buscarABB (miRaiz, num);	// Llamada a la función buscarABB
  uswtime (&utime1, &stime1, &wtime1);	// Termina la medición de tiempo
  imprimirResultados (utime0, stime0, wtime0, utime1, stime1, wtime1, 4, num, n, a);	// Se imprimen los resultados a archivo
  return a;			// 0 si fue encontrado, -1 en caso contrario
}

/**
 * Esta función inserta los elementos de un arreglo de números a un árbol
 * de búsqueda binaria, para posteriormente realizar la búsqueda de los números
 * de un arreglo.
 * Recibe como argumentos:
 * 	int *A: El arreglo con los números desordenados
 * 	int n: El tamaño del arreglo A
 * Regresa:
 * 	0 si la ejecución se dió con éxito.
 * Posibles errores:
 * 	Falta de memoria para la creación del árbol (no reportado durante
 *	las pruebas hechas).
 */ */
  int
aBB2 (int *A, int n)
{
  double utime0;		// Variables usadas en la medición de tiempos
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  int i;			// Contador para ciclos
  int a;			// Variable para saber si se encontró o no el número
  int numeros[20] =
    { 322486, 14700764, 3128036, 6337399, 61396, 10393545, 2147445644,
    1295390003, 450057883, 187645041, 1980098116, 152503, 5000,
    1493283650, 214826, 1843349527, 1360839354, 2109248666,
    2147470852, 0
  };				// Arreglo de números a buscar (indicados en la práctica)
  printf ("\n\tCreando arbol\n");
  struct nodo *miRaiz;		// Declaramos el nodo raíz del árbol
  miRaiz = (struct nodo *) malloc (sizeof (struct nodo));	// Reservamos memoria para la raíz
  miRaiz = NULL;		// Inicializamos en NULL
  for (i = 0; i < n; i++)
    {
      insertar (&miRaiz, A[i]);	// Se realiza la inserción de los elementos del arreglo en el árbol
    }
  printf ("\tSe creo el arbol\n");
  for (i = 0; i < 20; i++)	// Ciclo para la búsqueda de los 20 números del arreglo
    {
      uswtime (&utime0, &stime0, &wtime0);	// Comienza la medición de tiempo para la búsqueda de un número
      a = buscarABB (miRaiz, numeros[i]);	// Se busca un número del arreglo
      uswtime (&utime1, &stime1, &wtime1);	// Termina la medición de tiempo
      imprimirResultados (utime0, stime0, wtime0, utime1, stime1, wtime1, 3, numeros[i], n, a);	// Se imprimen resultados a un archivo
    }
  return 0;			// Ejecución exitosa
}

/** 
 * Este método realiza la inserción de un elemento en el árbol binario
 * de búsqueda de forma iterativa.
 * Recibe:
 *   struct nodo **Raiz: Una referencia al nodo raíz del árbol.
 *   int miDato1: El valor del número a ingresar en el nodo del árbol
 * Función void no regresa elementos.
 * Posibles errores:
 *   Falta de memoria para la creación del nodo (no reportado durante
 *   las pruebas hechas).
 */ */
  void
insertar (struct nodo **Raiz, int miDato1)
{
  struct nodo **aux = NULL;	// Creamos un nodo auxiliar
  aux = Raiz;			// Igualamos el nodo auxiliar a la raiz para no hacer modificaciones a la raíz original
  if (*Raiz == NULL)		// Si no hay elementos en el árbol
    {
      *Raiz = nuevoNodo (miDato1);	// Creamos un nuevo nodo
    }
  else				// Si hay elementos en el árbol
    {
      while (*aux != NULL)	// Hasta encontrar la posición adecuada para el nuevo nodo
	{
	  if (miDato1 < (*aux)->dato)	// Si el número a ingresar el menor al número en aux
	    {
	      aux = &((*aux)->Izq);	// Ir al hijo izquierdo del padre aux actual
	    }
	  else if (miDato1 > (*aux)->dato)	// Si el número a ingresar el mayor al número en aux
	    {
	      aux = &((*aux)->Der);	// Ir al hijo derecho del padre aux actual
	    }
	}
      *aux = nuevoNodo (miDato1);	// Si ya se llegó a la posición adecuada, agrega el nuevo nodo
    }
}

/**
 * Esta función se encarga de crear un nodo para el árbol.
 * Recibe:
 *   int dato1: El número que almacenará el nodo
 * Regresa:
 *   El nodo de tipo struct nodo*
 * Posibles errores:
 *   Falta de memoria para la creación del nodo (no se presentó
 *   durante la ejecución de las pruebas).
 */ */
struct nodo *
nuevoNodo (int dato1)
{
  struct nodo *Nuevo;		// Declaramos la variable de tipo struct nodo*
  Nuevo = (struct nodo *) malloc (sizeof (struct nodo));	// Reservamos la memoria suficiente
  Nuevo->dato = dato1;		// Guardamos el número en el nodo
  Nuevo->Izq = Nuevo->Der = NULL;	// Sin hijos
  return Nuevo;			// Regresamos el nuevo nodo
}

/**
 * Este método realiza la búsqueda de un número sobre un árbol
 * binario de búsqueda de forma recursiva.
 * Recibe:
 * 	struct nodo *Raiz: raíz del árbol
 * 	int num: número a buscar sobre el árbol
 * Posibles errores:
 * 	Que el árbol no se haya creado correctamente (no reportado
 * 	durante las pruebas.)
 */ */
  int
buscarABB (struct nodo *Raiz, int num)
{
  if (Raiz == NULL)		// Si no hay elementos en el arreglo
    {
      return -1;
    }
  if (num == Raiz->dato)	// Si el número es igual al dato almacenado en el nodo actual
    {
      return 0;			// Se encontró el número
    }
  if (num > Raiz->dato)		// Si el número es mayor que el dato en el nodo actual
    {
      return buscarABB (Raiz->Der, num);	// Buscar en el hijo derecho del nodo actual
    }
  else				// Si es menor que el dato en el nodo actual
    {
      return buscarABB (Raiz->Izq, num);	// Buscar en el hijo izquierdo del nodo actual
    }
  return -1;			// No se encontró el número
}
