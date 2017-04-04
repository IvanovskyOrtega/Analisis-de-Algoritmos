#! /bin/bash
# Script para la práctica 2
echo Ejecutando el script
for i in `seq 1 819`; #800 iteraciones para las busquedas lineal y binaria, 20 para la del arbol.
do
   ./a.out < opciones.txt #redirigir la entrada estándar, se mandan los argumentos desde el fichero opciones.txt
   ./op #se actualiza el fichero opciones.txt
done
echo Terminamos
