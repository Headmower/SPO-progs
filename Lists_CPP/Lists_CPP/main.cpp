#include "ListWorker.h"
#include "Renderer.h"
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <Windows.h>

void main(int argc, char* argv[]){
	int count = 1000;
	int length = 1000000;
	if (argc >= 2)
		length = atoi(argv[1]);
	if (argc >= 3)
		count = atoi(argv[2]);
	int* list = NULL;
	printf_s("Generating lists");
	for (int i = 0; i < count; i++){
		ListWorker::Generate(list,length);
		printf_s(".");
	}
	printf_s("Finished\r\n");
}