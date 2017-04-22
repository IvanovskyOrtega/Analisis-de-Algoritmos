#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "busqueda.h"
#include "arbol.h"
#include "tiempo.h"

/**
Este método captura las entradas en dado caso de que los argumentos para el main
no sean los suficientes para poder ejecutar el programa, es decir, se pedirán
una a una las entradas necesarias para ejecutarlo.
*/
void
obtenerEntradas()
{
  int num;                                //Número a buscar sobre el arreglo
  int op;                                 //Método de búsqueda a emplear
  int n;                                  //Tamaño del artreglo
  while( op < 1 || op > 4 )               //Loop infinito si se ingresa una opción inválida
  {
    system("clear");
    printf("\nIngrese el tamaño del arreglo de busqueda:\n");                   //Se solicita el tamaño del arreglo
    scanf("%d",&n);
    printf("\nIngrese el método a utilizar:\n");                                //Se solicita el método a utilizar
    printf("(1)---Busqueda Lineal\n");
    printf("(2)---Busqueda Binaria\n");
    printf("(3)---Arbol Binario de Busqueda (Especial para pruebas, busca todos los numeros)\n");
    printf("(4)---Arbol Binario de Busqueda (Solo busca un numero)\n");
    printf("Ingresa tu seleccion:\t");
    scanf("%d",&op);
    switch(op)                                                      //Dependiendo del método se pedirá o no el número a buscar
    {
      case 1:
      case 2:
      case 4:
        printf("\nIngresa el número a buscar sobre el arreglo:\t"); //Se pide el numero
        scanf("%d",&num);
        busqueda( n, op, num );                                     //Se llama a la funcion busqueda()
        break;
      case 3:
        num = -1;                                                   //No interesa el numero
        busqueda( n, op, num );                                     //Se llama a la funcion busqueda()
        break;
      default:                                                      //Opcion no valida
        printf("\nOpcion invalida\n");
        printf("Pulsa Enter para continuar...\n");
        getchar();
        getchar();
        fflush(stdin);
        break;
      }
  }
}

/**
Este método lee los números desde un archivo .txt que se encuentra en la
misma carpeta donde estan los códigos fuente.
Recibe como parámetros el arreglo A donde va a almacenar los números y el
tamaño n del arreglo a generar.
POSIBLES ERRORES:
  -Los archivos de números no estan en el directorio de los códigos
  -Los archivos de números tienen otro nombre
*/
void
leerNumeros( int* A, int n , int op )
{
  int i = 0;
  FILE *numeros;                                             //Puntero a archivo
  if( op == 3 || op == 4 )                                   //Para los metodos que usan el ABB, se utiliza el archivo de números desordenados
  {
    numeros = fopen( "numeros10millones.txt" , "r" );  //Se abre el archivo de números desordenados
  }
  else
  {
    numeros = fopen( "10millones.txt" , "r" );         //Se abre el archivo de números ordenados
  }
	while ( feof( numeros ) == 0 && i < n )                    //Leer hasta llegar al final del archivo
	{
	  fscanf( numeros , "%d" , &A[i] );                        //Se almacenan los números en el arreglo
    i++;
	}
  fclose(numeros);                                           //Cierra el archivo
}

/**
Este método sirve como menú para seleccionar el método a utilizar y el tamaño
del arreglo sobre el cual se buscara el arreglo, además del número a buscar en
él.
Recibe como parámetros el tamaño del arreglo, el método a utilizar
(1-Busqueda lineal, 2-Busqueda binaria, 3-BST) y el numero a buscar en el
arreglo (o arbol en el caso del BST).
*/
void
busqueda(int n, int op, int num)
{
  int* A;                                               //Arreglo donde se almacenarán los números
  int index;                                            //Variable utilizada para saber si se encontro el número, si index !=-1, se encontro
  double utime0;                                        //Lista de variables utilizadas para calcular tiempos de ejecucion
  double stime0;
  double wtime0;
  double utime1;
  double stime1;
  double wtime1;
  A = (int*)malloc(n*sizeof(int));                      //Se crea un arreglo del tamaño especificado por el parámetro n
  leerNumeros( A , n, op );                             //Llama a la función leerNumeros() para llenar el arreglo
  switch( op )                                          //Swtich case para el metodo
  {
    case 1:                                             //Caso 1: Búsqueda Lineal
      uswtime(&utime0, &stime0, &wtime0);               //Iniciar conteo de tiempo
      index = busquedaLineal( A , n , num );            //Se llama a la función de busquedaLineal()
      uswtime(&utime1, &stime1, &wtime1);               //Termina conteo de tiempo
      if( index != -1 )                                 //Condicion para saber si se encontró el número
        printf("\n\tSe encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("\n\tNo se encontro el numero.\n");
      imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, op, num, n, index);   //Imprime los resultados a archivo
      break;
    case 2:                                             //Caso 2: Busqueda binaria
      uswtime(&utime0, &stime0, &wtime0);               //Iniciar conteo de tiempo
      index = busquedaBinaria( A , n , num );           //Se llama a la función de busquedaBinaria()
      uswtime(&utime1, &stime1, &wtime1);               //Termina conteo de tiempo
      if( index != -1 )                                 //Condicion para saber si se encontró el número
        printf("\n\tSe encontro el numero %d en el indice %d del arreglo.\n",num,index);
      else
        printf("\n\tNo se encontro el numero.\n");
      imprimirResultados( utime0, stime0, wtime0, utime1, stime1, wtime1, op, num, n, index);   //Imprime los resultados a archivo
      break;
    case 3:                                             //Caso 3: Busqueda sobre el BST (ABB) especial para pruebas (mas informacion en su documentación)
      index = aBB2( A, n);                              //Se llama a la función aBB2()
      printf("\n\tTermino la ejecucion del metodo.\n");
      break;
    case 4:                                             //Caso 4: Busqueda sobre el BST (ABB) diseñada para buscar un elemento (más información en su documentación)
      index = aBB1( A, n, num );                        //Se llama a la función aBB1()
      if( index != -1 )                                 //Condicion para saber si se encontró el número
        printf("\n\tSe encontro el numero %d sobre el arbol.\n",num);
      else
        printf("\n\tNo se encontro el numero.\n");
      break;
    default:		//Opcion no valida
      printf ("\n\t\tOpcion invalida\n");
  }
}

/**
Este método ejecuta el algoritmo de búsqueda lineal.
Recibe como parámetros el arreglo de búsqueda, el tamaño del arreglo y
el elemento a buscar.
Regresa la posición del arreglo donde se encontró el número si la búsqueda fue
exitosa.
Regresa -1 si no se encontró el número.
*/
int
busquedaLineal( int* A, int n, int num )
{
  for( int i = 0 ; i < n ; i++ )
  {
    if( A[i] == num )                   //Compara cada elemento del arreglo con el elemento buscado
      return i;
  }
  return -1;
}

/**
Este método ejecuta el algoritmo de búsqueda binaria.
Recibe como parámetros el arreglo de búsqueda, el tamaño del arreglo y
el elemento a buscar.
Regresa la posición del arreglo donde se encontró el número si la búsqueda fue
exitosa.
Regresa -1 si no se encontró el número.
*/
int
busquedaBinaria( int* A, int n, int num )
{
  int centro;                           //Se establece un centro para dividir el arreglo en 2 mitades, mitad inferior y mitad superior
  int inf = 0;                          //Limite inferior del arreglo
  int sup = n-1;                        //Limite superior del arreglo
  while ( inf <= sup )                  //Condicion de salida
  {
    centro = ( sup + inf )/2;           //Se parte el arreglo en 2
    if( A[centro] == num )              //Si el número se encuentra en el centro...
      return centro;                              //Regresa centro (indice del arreglo donde se encontró) y termina el ciclo
      else if( num < A[centro] )        //Si el número a buscar es menor que el que se encuentra en el centro
        sup = centro - 1;                         //limite superior es igual al centro-1 y se trabaja con la mitad inferior y se repite el ciclo
      else                              //Si el número a buscar es mayor que el que se encutnra en el centro
        inf = centro + 1;                         //limite inferior es igual al centro+1 y se trabaja con la mitad superior y se repite el ciclo
  }
  return -1;                            //No se encontró el número
}

/**
Esta función imprime los resultados obtenidos de la búsqueda a un archivo de
texto.
Recibe como parámetros las variables de medición de tiempo declaradas en
busqueda(), el metodo utilizado op, el tamaño del arreglo n, el indice
del arreglo donde fue encontrado index, y el número buscado num.
*/
void
imprimirResultados( double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int op, int num, int n, int index )
{
  FILE* resultados;                                       //Puntero a archivo de resultados
  char encontrado[3]={};                                  //Cadena para imprimir si el numero fue encontrado o no
  resultados = fopen("resultados.txt", "a");              /*
                                                            Abrimos el archivo en modo append.
                                                            No sobreescibe el archivo, y lo crea si no existe.
                                                          */
  if(index != -1)                                         //Si el número fue encontrado
    strcpy(encontrado,"si");
  else
    strcpy(encontrado,"no");                              //Si no fue encontrado
  /*
    Las condiciones de abajo solo son para tener un buen formato en el archivo.
    Se agregan o quitan tabuladores para mejor visualización y orden en la
    información de salida al archivo.
  */
  if(num >= 1000000)
  {
    if(n < 1000)
      fprintf(resultados,"Metodo: %d\t Numero: %d\t N: %d\t\t Encontrado: %s\t TR: %.10e\n",op,num,n,encontrado,wtime1 - wtime0);
    if(n >= 1000)
      fprintf(resultados,"Metodo: %d\t Numero: %d\t N: %d\t Encontrado: %s\t TR: %.10e\n",op,num,n,encontrado,wtime1 - wtime0);
  }
  else
  {
    if(n < 1000)
      fprintf(resultados,"Metodo: %d\t Numero: %d\t\t N: %d\t\t Encontrado: %s\t TR: %.10e\n",op,num,n,encontrado,wtime1 - wtime0);
    if(n >= 1000)
      fprintf(resultados,"Metodo: %d\t Numero: %d\t\t N: %d\t Encontrado: %s\t TR: %.10e\n",op,num,n,encontrado,wtime1 - wtime0);
  }


  /*
  Para mayor información del uso de CPU en la ejecución, descomentar la
  seccion de abajo.
  */

  /*
  fprintf(resultados,"\tFormato exponencial:\n");
  fprintf(resultados,"\tReal (Tiempo total)  %.10e s\n",  wtime1 - wtime0);
  fprintf(resultados,"\tUser (Tiempo de procesamiento en CPU) %.10e s\n",  utime1 - utime0);
  fprintf(resultados,"\tSys (Tiempo en acciónes de E/S)  %.10e s\n",  stime1 - stime0);
  fprintf(resultados,"\tCPU/Wall   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
  fprintf(resultados,"\n");
  fprintf(resultados,"\n");
  fprintf(resultados,"\tFormato segundos:\n");
  fprintf(resultados,"\tReal (Tiempo total)  %.10f s\n",  wtime1 - wtime0);
  fprintf(resultados,"\tUser (Tiempo de procesamiento en CPU) %.10f s\n",  utime1 - utime0);
  fprintf(resultados,"\tSys (Tiempo en acciónes de E/S)  %.10f s\n",  stime1 - stime0);
  fprintf(resultados,"\tCPU/Wall   %.10f %% \n\n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
  */

  fclose(resultados);
}
