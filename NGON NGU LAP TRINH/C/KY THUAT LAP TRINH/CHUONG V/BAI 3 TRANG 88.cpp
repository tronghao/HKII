#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>


int main()
{	
	int so_luong=1000, dem=0;
	int  m, n;
	float *doc;
	
	
	char dd[50];
	printf("\n Nhap duong dan: ");
	fflush(stdin);	gets(dd);
	FILE *f;
	f=fopen(dd,"rt");
	if(f==NULL) printf("\n Loi mo file");
	else
	{
	printf("\n Noi dung file vua doc: \n");
	fscanf(f,"%d", &m);
	fscanf(f,"%d", &n);
	doc=(float*)malloc(sizeof(float)*m*n);
	for(int i=0; i<m*n; i++)
	{
		fscanf(f,"%f", doc+i);
		dem++;
	}
		
	for(int i=0; i<dem; i++)
	{
		printf(" %5.2f", *(doc+i));
		if((i+1)%n==0) printf("\n");
	}
		
	fclose(f);
	}

	free(doc);
	printf("\n An phim bat ky de thoat");
	getch();
	return 0;
}

