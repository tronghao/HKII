#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct NHANVIEN
{
	char maNV[5];
	char tenNV[30];
	float luongNV;
	int namSinh;
} NV;
void nhapNV(NV *a);
void xuatNV(NV *a);
void nhapDSNV(NV *a, int n);
void xuatDSNV(NV *a, int n);

int main()
{
	NV *a;		int n;
	do{
		printf("\nNhap so luong nhan vien: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai moi ban nhap lai\n");
	}while(n<=0);
	a=(NV*)malloc(sizeof(NV)*n);
	nhapDSNV(a, n);
	xuatDSNV(a, n);
	
	free(a);
	getch();
	return 0;
}

void nhapNV(NV *a)
{
	printf("\nNhap ma nhan vien: ");
	fflush(stdin);	scanf("%s", a->maNV);
	
	printf("\nNhap ten nhan vien: ");
	fflush(stdin);	gets(a->tenNV);
	
	printf("\nNhap nam sinh: ");
	scanf("%d", &a->namSinh);
	
	printf("\nNhap luong cua nhan vien: ");
	scanf("%f", &a->luongNV);
}
void xuatNV(NV *a)
{	
	printf("\n%s\t%s\t%d\t%8.2f", a->maNV, a->tenNV, a->namSinh, a->luongNV);	
}

void nhapDSNV(NV *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhapNV(a+i);
	}
}
void xuatDSNV(NV *a, int n)
{
	for(int i=0; i<n; i++)
	{
		xuatNV(a+i);
	}
}
