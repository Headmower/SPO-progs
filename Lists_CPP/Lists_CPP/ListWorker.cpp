#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <Windows.h>

namespace ListWorker{
	void Generate(int*& list,int length){
		delete list;
		list = (int*)calloc(length, sizeof(int));
		for (int i = 0; i < length; i++){
			list[i] = i;
		}
	};
}