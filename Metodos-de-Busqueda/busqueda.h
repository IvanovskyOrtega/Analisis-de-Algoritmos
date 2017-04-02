#ifndef _BUSQUEDA_H_
#define _BUSQUEDA_H_

void
busqueda();
int
busquedaLineal( int* A, int n, int num );
int
busquedaBinaria( int* A, int n, int num );
void
imprimirResultados( double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int op, int num, int n, int index );

#endif
