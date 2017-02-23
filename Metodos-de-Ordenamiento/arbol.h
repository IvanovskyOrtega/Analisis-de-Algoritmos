#ifndef _ARBOL_H_
#define _ARBOL_H_

struct nodo
{
  int dato;
  struct nodo *Izq;
  struct nodo *Der;
};

int * aBB (int* A, int n);
void insertar (struct nodo **Raiz, int miDato1);
struct nodo *nuevoNodo (int dato1);
int * inordenSecuencial(struct nodo *Raiz, int* A);

#endif
