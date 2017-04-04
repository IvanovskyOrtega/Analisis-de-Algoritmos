#ifndef _ARBOL_H_
#define _ARBOL_H_

struct nodo
{
  int dato;
  struct nodo *Izq;
  struct nodo *Der;
};

int
aBB1 (int* A, int n, int num);
int
aBB2 ( int* A, int n, int num );
void
insertar (struct nodo **Raiz, int miDato1);
struct nodo *
nuevoNodo (int dato1);
int *
inordenSecuencial(struct nodo *Raiz, int* A);
int
buscarABB(struct nodo *Raiz, int num);
#endif
