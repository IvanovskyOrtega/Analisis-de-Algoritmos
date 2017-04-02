#include <stdio.h>
#include <stdlib.h>

/*
  Este archivo genera las combinaciones de prueba pedidas en la práctica.
*/

int
main( void )
{
  int metodo; //opcion para el método de Ordenamiento
  int tamA; //Indica el tamaño del arreglo
  FILE* op = fopen("opciones.txt","r"); //modo de lectura
  fscanf(op, "%d %d", &tamA, &metodo);
  if( tamA == 100 )
  {
    tamA = 1000;
  }
  else if( tamA == 1000 )
  {
    tamA = 5000;
  }
  else if( tamA == 5000 )
  {
    tamA = 10000;
  }
  else if( tamA == 10000 )
  {
    tamA = 50000;
  }
  else if( tamA == 50000 )
  {
    tamA = 100000;
  }
  else if( tamA == 100000 )
  {
    tamA = 200000;
  }
  else if( tamA == 200000 )
  {
    tamA = 400000;
  }
  else if( tamA == 400000 )
  {
    tamA = 600000;
  }
  else if( tamA == 600000 )
  {
    tamA = 800000;
  }
  else if( tamA == 800000 )
  {
    tamA = 1000000;
  }
  else if( tamA == 1000000 )
  {
    tamA = 2000000;
  }
  else if( tamA == 2000000 )
  {
    tamA = 3000000;
  }
  else if( tamA == 3000000 )
  {
    tamA = 4000000;
  }
  else if( tamA == 4000000 )
  {
    tamA = 5000000;
  }
  else if( tamA == 5000000 )
  {
    tamA = 6000000;
  }
  else if( tamA == 6000000 )
  {
    tamA = 7000000;
  }
  else if( tamA == 7000000 )
  {
    tamA = 8000000;
  }
  else if( tamA == 8000000 )
  {
    tamA = 9000000;
  }
  else if( tamA == 9000000 )
  {
    tamA = 10000000;
  }
  else if( tamA == 10000000 && metodo !=6 )
  {
    tamA = 100;
    metodo++;
  }
  else if( tamA == 10000000 && metodo == 6 )//Reinicia el fichero
  {
    tamA = 100;
    metodo = 1;
  }
  fclose(op);
  op = fopen("opciones.txt","w");//abrir el archivo en modo de escritura
  fprintf(op,"%d %d",tamA,metodo);
  fclose(op);
}
