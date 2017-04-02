#! /bin/bash
# Script para la práctica 2
echo Ejecutando el script
for i in `seq 1 1200`;
do
   ./op
   ./a.out < opciones
done
./op
echo Terminamos
