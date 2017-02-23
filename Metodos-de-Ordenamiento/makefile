a.out: main.o metodos.o arbol.o tiempo.o
	gcc main.o metodos.o arbol.o tiempo.o
main.o: main.c
	gcc -c main.c -Wall
metodos.o: metodos.c
	gcc -c metodos.c -Wall
arbol.o: arbol.c
	gcc -c arbol.c -Wall
tiempo.o: tiempo.c
	gcc -c tiempo.c -Wall
clean:
	rm main.o metodos.o arbol.o tiempo.o
run: a.out
	./a.out
