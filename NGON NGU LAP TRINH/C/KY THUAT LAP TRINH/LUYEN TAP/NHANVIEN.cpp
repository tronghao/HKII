#include "stdio.h"
#include "stdlib.h"

typedef struct Nhan_Vien
{
	char maNV[5];
	char tenNV[20];
	float luongNV;
	int namSinh;
}NV;

void nhap(NV *a);
void xuat(NV *a);
void nhapn(NV *a, int n);
void xuatn(NV *a, int n, char * name);
void sapTang(NV *a, int n);
void writeF(NV *a, int n);
void readF(NV *a, int &n);

int main()
{
	system("color F1");
	NV *a, *b;	int n, m;
	
	do{
		printf("\nSo luong NV can nhap: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai!\n");	
	}while(n<=0);
	
	//tao mang
	a=(NV*)malloc(sizeof(NV)*n);
	b=(NV*)malloc(sizeof(NV)*10);
	/*
	//nhap mang
	nhapn(a, n);
	
	//xuat mang
	xuatn(a, n, "Danh Sach Nhan Vien");
	
	//sapTang
	sapTang(a, n);
	xuatn(a, n, "Danh Sach sau sap tang");
	
	//ghi file
	writeF(a, n);
	*/
	//doc file
	readF(b, m);
	b=(NV*)realloc(b, sizeof(NV)*m);
	xuatn(b, m, "Danh sach doc file");
	
	free(a); free(b);
	return 0;
}

void nhap(NV *a)
{
	printf("\n--------------------");
	printf("\nNhap ma NV: ");
	fflush(stdin);
	scanf("%s", a->maNV);
	
	printf("\nNhap ten NV: ");
	fflush(stdin);
	gets(a->tenNV);
	
	printf("\nLuong: ");
	scanf("%f", &a->luongNV);
	
	printf("\nNam Sinh: ");
	scanf("%d", &a->namSinh);
	printf("--------------------\n");
}

void xuat(NV *a)
{
	printf("\n%-6s\t%-20s\t%-8d\t%-11.2f", a->maNV, a->tenNV, a->namSinh, a->luongNV);
}

void nhapn(NV *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhap(a+i);
	}
}

void xuatn(NV *a, int n, char * name)
{
	printf("\n--------------------");
	printf("\n%s:\n", name);
	printf("\n%-6s\t%-20s\t%-8s\t%-11s", "Ma NV", "Ten NV", "Nam Sinh", "Luong(dong)");
	for(int i=0; i<n; i++)
	{
		xuat(a+i);
	}
	printf("\n--------------------\n");
}

void sapTang(NV *a, int n)
{
	NV tam;
	for(int i=0; i<n-1; i++)
	{
		for(int j=i+1; j<n; j++)
		{
			if((a+i)->luongNV > (a+j)->luongNV)
			{
				tam=*(a+i);
				*(a+i)=*(a+j);
				*(a+j)=tam;
			}
		}
	}
}

void writeF(NV *a, int n)
{
	FILE *f;
	f=fopen("D:/text.out", "wb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		fwrite(a, sizeof(NV), n, f);
		fclose(f);
	}
}

void readF(NV *a, int &n)
{
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
			fread((a+dem), sizeof(NV), 1, f);
			dem++;
		
		}
		fclose(f);	
	}
	n=dem-1;;
}


