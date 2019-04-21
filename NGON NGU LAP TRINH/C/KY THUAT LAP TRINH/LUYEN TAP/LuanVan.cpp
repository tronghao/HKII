#include "stdio.h"
#include "stdlib.h"

typedef struct Luan_Van
{
	char maLV[5];
	char tenLV[30];
	char SVTH[20];
	char GVHD[20];
	int namTH;		
}LV;

void nhap(LV *a);
void xuat(LV *a);
void nhapn(LV*a, int n);
void xuatn(LV*a, int n);
void writeF(LV* a, int n);
void readF(LV* a, int &n);

int main()
{
	LV *a, *b; int n,m;
	do{
		printf("\nSo luong luan van can nhap: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai!\n");
	}while(n<=0);

	//tao mang
	a=(LV*)malloc(sizeof(LV)*n);
	b=(LV*)malloc(sizeof(LV)*10);
	/*
	//nhap
	nhapn(a, n);
	
	//xuat
	xuatn(a, n);
	
	//ghi file
	writeF(a, n);*/
	
	//doc file
	readF(b, m);
	b=(LV*)realloc(b, sizeof(LV)*m);
	xuatn(b, m);
	
	free(a); free(b);
	return 0;
}

void nhap(LV *a)
{
	printf("\n-------------------");
	printf("\nNhap ma LV: ");
	fflush(stdin);
	scanf("%s", a->maLV);
	
	printf("Nhap ten LV: ");
	fflush(stdin);
	gets(a->tenLV);
	
	printf("Nhap ten SVTH: ");
	fflush(stdin);
	gets(a->SVTH);
	
	printf("Nhap ten GVHD: ");
	fflush(stdin);
	gets(a->GVHD);
	
	printf("Nam thuc hien: ");
	fflush(stdin);
	scanf("%d", &a->namTH);
	printf("-------------------\n");
}

void xuat(LV *a)
{
	printf("\n%s\t%s\tSVTH: %s\tGVHD: %s\tNam:%d", a->maLV, a->tenLV, a->SVTH, a->GVHD, a->namTH);
}

void nhapn(LV*a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhap(a+i);
	}
}

void xuatn(LV*a, int n)
{
	printf("\n-------------------\n");
	printf("Danh sach luan van");
	for(int i=0; i<n; i++)
	{
		xuat(a+i);
	}
	printf("\n-------------------\n");
}

void writeF(LV* a, int n)
{
	/*char dd[30];
	printf("Nhap duong dan:");
	fflush(stdin);
	gets(dd);*/
	
	FILE *f;
	f=fopen("D:/text.out", "wb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		fwrite(a, sizeof(LV), n, f);
		fclose(f);
	}
}

void readF(LV* a, int &n)
{
	/*char dd[30];
	printf("Nhap duong dan:");
	fflush(stdin);
	gets(dd);*/
	
	int dem=0;
	FILE *f;
	f=fopen("D:/text.out", "rb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		while(!feof(f))
		{
			fread((a+dem), sizeof(LV), 1, f);
			dem++;
		}
		fclose(f);
	}
	n=dem-1;
}
