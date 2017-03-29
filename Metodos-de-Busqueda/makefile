a.out: main.o busqueda.o arbol.o #tiempo.o
	gcc main.o busqueda.o arbol.o #tiempo.o
main.o: main.c
	gcc -c main.c -Wall
busqueda.o: busqueda.c
	gcc -c busqueda.c -Wall
arbol.o: arbol.c
	gcc -c arbol.c -Wall
#tiempo.o: tiempo.c
	#gcc -c tiempo.c -Wall
clean:
	rm main.o busqueda.o arbol.o a.out #tiempo.o
run: a.out
	./a.out
