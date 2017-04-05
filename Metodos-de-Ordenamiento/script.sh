#! /bin/bash
# Script para la práctica 1
echo Ejecutando script...
for i in `seq 1 120`;
do
   ./a.out < opciones.txt
   ./op
done
echo Terminamos 
