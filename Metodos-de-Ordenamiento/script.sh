#! /bin/bash
# Script para la práctica 1
echo Ejecutando el programa para 1000 elementos con cada método de ordenamiento
for i in `seq 1 120`;
do
   ./op
   ./a.out < opciones.txt
done
./op
echo Terminamos uwu
