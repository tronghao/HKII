#include "stdio.h"
#include "stdlib.h"

typedef struct Dai_ly
{
	char maSo[5];
	char tenKH[20];
	int sdt;
	int ngay;
	int thang;
	int nam;
	char email[20];
}DL;

void nhap(DL *a);
void xuat(DL *a);
void nhapn(DL *a, int n);
void xuatn(DL *a, int n, char * name);
void writeF(DL *a, int n);
void readF(DL *a, int &n);

int main()
{
	DL *a, *b;	int n, m;
	
	do{
		printf("\nSo luong KH can nhap: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai!\n");	
	}while(n<=0);
	
	//tao mang
	a=(DL*)malloc(sizeof(DL)*n);
	b=(DL*)malloc(sizeof(DL)*10);

	//nhap mang
	nhapn(a, n);
	
	//xuat mang
	xuatn(a, n, "Danh Sach Nhan Vien");
	
	//ghi file
	writeF(a, n);

	//doc file
	readF(b, m);
	b=(DL*)realloc(b, sizeof(DL)*m);
	xuatn(b, m, "Danh sach doc file");

	free(a); free(b);
	return 0;
}

void nhap(DL *a)
{
	printf("\n--------------------");
	printf("\nNhap ma: ");
	fflush(stdin);
	scanf("%s", a->maSo);
	
	printf("\nNhap ten KH: ");
	fflush(stdin);
	gets(a->tenKH);
	
	printf("\nNhap sdt: ");
	fflush(stdin);
	scanf("%d", &a->sdt);
	
	printf("DATE:\n");
	do{
		printf("\tNgay:");
		scanf("%d", &a->ngay);
		if(a->ngay <0|| a->ngay>31) printf("\tBan nhap sai!\n");
	}while(a->ngay <0|| a->ngay>31);
	
	do{
		printf("\tThang:");
		scanf("%d", &a->thang);
		if(a->thang <0|| a->thang>12) printf("\tBan nhap sai!\n");
	}while(a->thang <0|| a->thang>12);
	
	do{
		printf("\tNam:");
		scanf("%d", &a->nam);
		if(a->nam <0) printf("\tBan nhap sai!\n");
	}while(a->nam <0);
	
	
	printf("\nEmail: ");
	fflush(stdin);
	gets(a->email);
	printf("--------------------\n");
}

void xuat(DL *a)
{
	printf("\n%-6s\t%-20s\t%-11d\t%-25s\t%5d/%d/%d", a->maSo, a->tenKH, a->sdt, a->email, a->ngay, a->thang, a->nam);
}

void nhapn(DL *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhap(a+i);
	}
}

void xuatn(DL *a, int n, char * name)
{
	printf("\n--------------------");
	printf("\n%s:\n", name);
	printf("\n%-6s\t%-20s\t%-11s\t%-25s\t%12s", "Ma So", "Ten KH", "SDT", "Email","Ngay nhan");
	for(int i=0; i<n; i++)
	{
		xuat(a+i);
	}
	printf("\n--------------------\n");
}

void writeF(DL *a, int n)
{
	FILE *f;
	f=fopen("D:/text.out", "wb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		fwrite(a, sizeof(DL), n, f);
		fclose(f);
	}
}

void readF(DL *a, int &n)
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
			fread((a+dem), sizeof(DL), 1, f);
			dem++;
		
		}
		fclose(f);	
	}
	n=dem-1;;
}

