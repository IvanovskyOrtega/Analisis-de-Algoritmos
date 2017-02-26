#include <stdio.h>
#include <stdlib.h>
#include "metodos.h"

int *
burbuja(int *A, int n)
{
  int pos1=1;
  int pos2=0;
  int temp=0;
  while(pos1<n)
  {
    pos2=0;
    while(pos2<n-1)
    {
      if(A[pos2]>A[pos2+1])
      {
        temp=A[pos2];
        A[pos2]=A[pos2+1];
	A[pos2+1]=temp;
      }
      pos2++;
    }
    pos1++;
  }
  return A;
}

int *
burbuja_Mejorada(int *A, int n)
{
  int pos1=1;
  int pos2=0;
  int temp=0;
  while(pos1<n)
  {
    pos2=0;
    while(pos2<pos1)
    {
      if(A[pos1]<A[pos2])
      {
        temp=A[pos2];
        A[pos2]=A[pos1];
	A[pos1]=temp;
      }
      pos2++;
    }
    pos1++;
  }
  return A;
}

int *
insercion(int *A, int n)
{
  int pos1=1;
  int pos2=0;
  int temp=0;
  while(pos1<n)
  {
    temp=A[pos1];
    pos2=pos1-1;
    for(;(A[pos2]>temp)&&(pos2>=0);pos2--)
    {
      A[pos2+1]=A[pos2];
    }
    A[pos2+1]=temp;
    pos1++;
  }
  return A;
}

int *
seleccion(int *A, int n)
{
  int pos1=0;
  int pos2=0;
  int pos3=0;
  int temp;
  while(pos1<n-1)
  {
    pos2=pos1;
    pos3=pos1+1;
    while(!(pos3>n-1))
    {
      if(A[pos3]<A[pos2])
      {
        pos2=pos3;
      }
	pos3++;
    }
    if(pos2!=pos1)
    {
      temp=A[pos2];
      A[pos2]=A[pos1];
      A[pos1]=temp;
    }
    pos1++;
  }
  return A;
}

int *
shell(int *A, int n)
{
  int gap;
  int i; 
  int j;
  int temp;
  for (gap = n/2 ; gap > 0 ; gap /= 2) {
     for (i = gap; i < n ; i++) {
         for (j = i-gap ; j >= 0 && A[j] > A[j+gap] ; j -= gap) {
             temp = A[j];
             A[j] = A[j+gap];
             A[j+gap] = temp;
            }
        }
  }
  return A;
}

void 
imprimirResultados( double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int n, int* A )
{
	FILE* resultados;
	resultados = fopen("/home/ivanovsky/Escritorio/Analisis-de-Algoritmos/Metodos-de-Ordenamiento/resultados.txt", "w");
	fprintf(resultados,"Ordenar %d numeros:", n);	
	fprintf(resultados,"\n");
	fprintf(resultados,"\tReal (Tiempo total)  %.10e s\n",  wtime1 - wtime0);
	fprintf(resultados,"\tUser (Tiempo de procesamiento en CPU) %.10e s\n",  utime1 - utime0);
	fprintf(resultados,"\tSys (Tiempo en acciónes de E/S)  %.10e s\n",  stime1 - stime0);
	fprintf(resultados,"\tCPU/Wall   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	fprintf(resultados,"\n");
	fprintf(resultados,"\n");
	fprintf(resultados,"real (Tiempo total)  %.10f s\n",  wtime1 - wtime0);
	fprintf(resultados,"user (Tiempo de procesamiento en CPU) %.10f s\n",  utime1 - utime0);
	fprintf(resultados,"sys (Tiempo en acciónes de E/S)  %.10f s\n",  stime1 - stime0);
	fprintf(resultados,"CPU/Wall   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	fprintf(resultados,"\n");
		
	for( int i = 0 ; i < n  ; i++)
	{
		fprintf(resultados, "\t%d)\t%d\n",i+1,A[i]);
	}
	fclose(resultados);
}
