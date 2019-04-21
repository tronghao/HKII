#include "stdio.h"

void nhap(int a[], int n);
void xuat(int a[], int n);
void writeF(int a[], int n);
void readF(int a[], int &n);

int main()
{
	int a[10], n;
	//nhap(a, 9);
	//xuat(a, 9);
	//writeF(a, 9);
	readF(a, n);
	xuat(a, n);
	return 0;
}

void nhap(int a[], int n)
{
	for(int i=0; i<n; i++)
	{
		printf("A[%d] = ", i);
		scanf("%d", &a[i]);
	}
}

void xuat(int a[], int n)
{
	printf("Noi dung mang la: ");
	for(int i=0; i<n; i++)
	{
		printf("%3d", a[i]);
	
	}
}

void writeF(int a[], int n)
{
	FILE *f;
	f=fopen("D:/test.out", "wb");
	if(f!=NULL)
	{
		fwrite(a, sizeof(int), n, f);
		fclose(f);
	}
	else printf("Loi mo file!");
}

void readF(int a[], int &n)
{
	int dem=0;
	FILE *f;
	f=fopen("D:/test.out", "rb");
	if(f!=NULL)
	{
		while(!feof(f))
		{
			fread(&a[dem], sizeof(int), 1, f);	
			dem++;
		}
	
		fclose(f);
	}
	else printf("Loi mo file!");
	n=dem-1;
}
