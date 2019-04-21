#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct LUANVAN
{
	char maSo[10];
	char tenLV[100];
	char hoTenSVTH[30];
	char hoTenGVHD[30];
	int namTH;
} LV;
void nhapLV(LV *a);
void xuatLV(LV *a);
void nhapDSLV(LV *a, int n);
void xuatDSLV(LV *a, int n);

int main()
{
	LV *a;		int n;
	do{
		printf("\nSo luong luan van can nhap: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai moi ban nhap lai\n");
	}while(n<=0);
	a=(LV*)malloc(sizeof(LV)*n);
	nhapDSLV(a, n);
	xuatDSLV(a, n);
	
	free(a);
	getch();
	return 0;
}

void nhapLV(LV *a)
{
	printf("\nNhap ma so luan van: ");
	fflush(stdin);	scanf("%s", a->maSo);
	
	printf("\nNhap ten luan van: ");
	fflush(stdin);	gets(a->tenLV);
	
	printf("\nHo ten sinh vien thuc hien: ");
	fflush(stdin);	gets(a->hoTenSVTH);
	
	printf("\nHo ten giao vien huong dan: ");
	fflush(stdin);	gets(a->hoTenGVHD);
	
	printf("\nNam thuc hien: ");
	scanf("%d", &a->namTH);
}
void xuatLV(LV *a)
{	

	printf("\n%s\t%s\tTen SVTH: %s\tTen GVHD: %s\t Nam: %d", a->maSo, a->tenLV, a->hoTenSVTH, a->hoTenGVHD, a->namTH);	
}

void nhapDSLV(LV *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhapLV(a+i);
	}
}
void xuatDSLV(LV *a, int n)
{
	for(int i=0; i<n; i++)
	{
		xuatLV(a+i);
	}
}
