#include "stdio.h"
#include "stdlib.h"

typedef struct Danh_Sach
{
	char mssv[10];
	char tenSV[20];
}DS;

typedef struct Lop_Hoc
{
	char maLop[10];
	char tenLop[20];
	int siSo;
	DS danhSL[10];	
}LH;


void nhapSV(DS &a);
void xuatSV(DS a);
void nhapnSV(DS a[], int n);
void xuatnSV(DS a[], int n);
void nhapLop(LH &a);
void xuatLop(LH a);
void writeF(LH a);
void readF(LH &a);

int main()
{
	LH a;
	//nhapLop(a);
	//xuatLop(a);
	//writeF(a);
	//a.danhSL=(DS*)malloc(sizeof(DS)*10);
	readF(a);
	//a.danhSL=(DS*)realloc(a.danhSL,sizeof(DS)*a.siSo);
	xuatLop(a);
	
	
	return 0;
}

void nhapSV(DS &a)
{
	printf("\n\t-----------------");
	printf("\n\tNhap mssv: ");
	fflush(stdin);
	scanf("%s", a.mssv);
	
	printf("\tNhap ten SV: ");
	fflush(stdin);
	gets(a.tenSV);
	printf("\t-----------------\n");
}

void xuatSV(DS a)
{
	printf("\nMSSV: %s\t\tTen SV: %s", a.mssv, a.tenSV);
}

void nhapnSV(DS a[], int n)
{
	for(int i=0; i<n; i++)
	{
		nhapSV(a[i]);
	}
}

void xuatnSV(DS a[], int n)
{
	printf("\nDanh sach:\n");
	for(int i=0; i<n; i++)
	{
		xuatSV(a[i]);
	}
}

void nhapLop(LH &a)
{
	printf("\n----------------------------------");
	printf("\n\tNhap ma lop: ");
	fflush(stdin);
	scanf("%s", a.maLop);
	
	printf("\tNhap ten lop: ");
	fflush(stdin);
	gets(a.tenLop);
	do{
		printf("\tNhap si so: ");
		scanf("%d", &a.siSo);
		if(a.siSo<0) printf("Ban nhap sai!\n");
	}while(a.siSo<0);
	
	printf("Nhap Danh Sach Lop:");
	//a.danhSL=(DS*)malloc(sizeof(DS)*a.siSo);
	nhapnSV(a.danhSL, a.siSo);

	printf("-----------------------------------\n");
}

void xuatLop(LH a)
{
	printf("\n%s\t%s\t%d\n", a.maLop, a.tenLop, a.siSo);
	xuatnSV(a.danhSL, a.siSo);
}

void writeF(LH a)
{
	FILE *f;
	f=fopen("D:/text.out", "wb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		fwrite(&a, sizeof(LH), 1, f);
		fclose(f);
	}
}

void readF(LH &a)
{
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
			fread(&a, sizeof(LH), 1, f);
		}
		
		fclose(f);
	}
}
