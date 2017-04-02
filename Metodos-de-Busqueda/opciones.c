#include <stdio.h>
#include <stdlib.h>

/*
  Este archivo genera las combinaciones de prueba pedidas en la práctica.
*/

int
main( void )
{
  int numeros[20] = {322486, 14700764, 3128036, 6337399, 61396, 10393545, 2147445644,
                  1295390003, 450057883, 187645041, 1980098116, 152503, 5000,
                  1493283650, 214826, 1843349527, 1360839354, 2109248666,
                  2147470852, 0};
  int control; //variable de control para saber que numero se va a buscar
  int num; //numero a buscar
  int metodo; //opcion para el método de busqueda
  int tamA; //Indica el tamanio del arreglo
  FILE* op = fopen("opciones.txt","r"); //modo de lectura
  fscanf(op, "%d %d %d %d", &tamA, &num, &metodo, &control);
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
  else if( tamA == 10000000 && metodo !=3 )
  {
    tamA = 100;
    metodo++;
  }
  else if( tamA == 10000000 && metodo == 3 )//Reinicia el fichero
  {
    tamA = 100;
    metodo = 1;
    control++;
  }
  fclose(op);
  op = fopen("opciones.txt","w");//abrir el archivo en modo de escritura
  fprintf(op,"%d %d %d %d",tamA,numeros[control],metodo,control);
  fclose(op);
}
