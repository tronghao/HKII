#include "stdio.h"

void nhap(int a[][3], int m, int n);
void xuat(int a[][3], int m, int n);
void writeF(int a[][3], int m, int n);
void readF(int a[][3], int m , int n);

int main()
{
	int a[10][3], n;
	//nhap(a, 2, 3);
	//xuat(a, 2, 3);
	//writeF(a, 2, 3);
	readF(a, 2,3);
	xuat(a, 2,3);
	return 0;
}

void nhap(int a[][3], int m, int n)
{
	for(int i=0; i<m; i++)
	{
		for(int j=0; j<n; j++)
		{
			printf("A[%d][%d] = ", i, j);
			scanf("%d", &a[i][j]);
		}
	
	}
}

void xuat(int a[][3], int m, int n )
{
	printf("Noi dung mang la: \n");
	for(int i=0; i<m; i++)
	{
		for(int j=0; j<n; j++)
		{
			printf("%3d", a[i][j]);
		}
		printf("\n");
	
	}
}

void writeF(int a[][3], int m, int n)
{
	FILE *f;
	f=fopen("D:/test.out", "wb");
	if(f!=NULL)
	{
	
		fwrite(a, sizeof(int), n*m, f);
		fclose(f);
	}
	else printf("Loi mo file!");
}

void readF(int a[][3], int m, int n)
{
	int dem=0;
	FILE *f;
	f=fopen("D:/test.out", "rb");
	if(f!=NULL)
	{
		for(int i=0; i<m; i++)
		{
			for(int j=0; j<n; j++)
			{
				fread(&a[i][j], sizeof(int), 1, f);
			}	
		}
	
		fclose(f);
	}
	else printf("Loi mo file!");
}
