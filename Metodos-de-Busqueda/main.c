#include <stdio.h>
#include <stdlib.h>
#include "busqueda.h"

int
main( int argc, char* argv[])
{
  if( argc < 4 )                  //Si faltan argumentos para ejecutar el programa automaticamente
  {
    printf("Argumentos insuficientes, se pedirán las entradas a continuacion\n");
    printf("Pulsa Enter para continuar...\n");
    getchar();
    fflush(stdin);
    obtenerEntradas();            //Se llama a la función obtenerEntradas()
  }
  if( argc == 4 )                 //Se ejecuta automaticamente con los argumentos recibidos
  {
    int n = atoi(argv[1]);        //Se convierten los argumentos a enteros
    int op = atoi(argv[2]);
    int num = atoi(argv[3]);
    printf("Metodos:\n1 -- Busqueda Lineal\n2 -- Busqueda Binaria\n3 -- Arbol Binario de busqueda (Pruebas)");
    printf("\n4 -- Arbol Binario de Busqueda (Normal)\n");
    printf("\nSe ejecutará el programa con los siguientes argumentos:\n");
    printf("\tMetodo: %d\n\tTamaño de arreglo: %d\n\tNumero a buscar: %d\n\n",op,n,num);
    busqueda(n,op,num);           //Se llama a la función busuqeda()
    printf("\n\nTermino la ejecucion\n");
  }
  return 0;
}
