#include "stdio.h"

typedef struct So_Tiet_Kiem
{
	char maSo[5];
	char tenKH[20];
	long CMND;
	int ngay;
	int thang;
	int nam;
	float tienGui;
}STK;

void nhap(STK *a);
void xuat(STK *a);
void nhapn(STK *a, int n);
void xuatn(STK *a, int n, char *b);
void writeF(STK *a, int n);
void readF(STK *a, int &n);
int main()
{
	STK a[5], b[5];
	int m;
	//nhapn(a, 2);
	//xuatn(a, 2, "Danh Sach");
	//writeF(a, 2);
	readF(b, m);
	xuatn(b, m, "Danh Sach doc file:");
	
	
	return 0;
}

void nhap(STK *a)
{
	printf("\n----------------");
	printf("\nNhap ma so: ");
	fflush(stdin);
	scanf("%s", a->maSo);
	
	printf("Nhap ten KH: ");
	fflush(stdin);
	gets(a->tenKH);
	
	printf("CMND: ");
	fflush(stdin);
	scanf("%ld", &a->CMND);
	
	printf("Ngay mo so: ");
	do{
		printf("\tNhap ngay thang nam: ");
		scanf("%d%d%d", &a->ngay, &a->thang, &a->nam);
		if(a->ngay <= 0 || a->ngay >31 || a->thang <=0 || a->thang >12 || a->nam <=0) printf("Ban nhap sai!\n");
	}while(a->ngay <= 0 || a->ngay >31 || a->thang <=0 || a->thang >12 || a->nam <=0);
	
	printf("Tien Gui: ");
	fflush(stdin);
	scanf("%f", &a->tienGui);
	printf("----------------\n");
}

void xuat(STK *a)
{
	printf("\n%-5s\t%-15s\t%-10ld\t%5d/%d/%d\t%7.2f", a->maSo, a->tenKH ,a->CMND, a->ngay, a->thang, a->nam, a->tienGui);
}

void nhapn(STK *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhap((a+i));
	}
}

void xuatn(STK *a, int n, char *b)
{
	printf("----------------\n");
printf("%s\n", b);
	printf("%-5s\t%-15s\t%-10s\t%12s\t%7s", "Ma so", "Ten KH", "CMND", "Ngay mo so", "Tien Gui");
	for(int i=0; i<n; i++)
	{
		xuat((a+i));
	}		
	printf("\n----------------\n");
}

void writeF(STK *a, int n)
{
	FILE *f;
	f=fopen("D:/text.out", "wb");
	if(f==NULL)
	{
		printf("Loi mo file!");
	}
	else
	{
		fwrite(a, sizeof(STK), n, f);
		fclose(f);
	}
}

void readF(STK *a, int &n)
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
			fread((a+dem), sizeof(STK), 1, f);
			dem++;	
		}
		
		fclose(f);
	}
	n=dem-1;
}
