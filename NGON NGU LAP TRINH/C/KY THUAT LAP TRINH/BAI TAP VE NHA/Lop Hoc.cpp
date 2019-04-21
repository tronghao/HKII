#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct LOPHOC
{
	char maLop[10];
	char tenLop[30];
	int siSo;
} LH;
typedef struct HOCSINH
{
	char maSo[10];
	char hoTen[30];
	int namSinh;
}HS;
void nhapHS(HS *a);
void xuatHS(HS *a);
void nhapDSHS(HS *a, int n);
void xuatDSHS(HS *a, int n);
void nhapLop(LH *a);
void xuatLop(LH *a, HS *b, int n);

int main()
{
	LH *b;
	b=(LH*)malloc(sizeof(LH));
	nhapLop(b);
	
	printf("Nhap danh sach lop:\n");
	HS *a;		int n;
	do{
		printf("\n\tSo luong sinh vien: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai moi ban nhap lai\n");
	}while(n<=0);
	a=(HS*)malloc(sizeof(HS)*n);
	nhapDSHS(a, n);
	xuatLop(b, a, n);
	
	
	free(a); free(b);
	getch();
	return 0;
}

void nhapHS(HS *a)
{
	printf("\n\tNhap ma so sinh vien: ");
	fflush(stdin);	scanf("%s", a->maSo);
	
	printf("\n\tNhap ho ten sinh vien: ");
	fflush(stdin);	gets(a->hoTen);
	
	printf("\n\tNam sinh: ");
	scanf("%d", &a->namSinh);
}
void xuatHS(HS *a)
{	

	printf("\n\t%s\t%-20s\tNam sinh: %d", a->maSo, a->hoTen, a->namSinh);	
}

void nhapDSHS(HS *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhapHS(a+i);
	}
}
void xuatDSHS(HS *a, int n)
{
	for(int i=0; i<n; i++)
	{
		xuatHS(a+i);
	}
}

void nhapLop(LH *a)
{
	printf("\nNhap ma lop: ");
	fflush(stdin);	scanf("%s", a->maLop);
	
	printf("\nNhap ten lop: ");
	fflush(stdin);	gets(a->tenLop);
	
	do{
		printf("\nSi so: ");
		scanf("%d", &a->siSo);
		if(a->siSo<=0) printf("Ban hay kiem tra lai\n\n");
	}while(a->siSo<=0);
	
}

void xuatLop(LH *a, HS *b, int n)
{
	printf("\n%s\t%s\tSi so: %d", a->maLop, a->tenLop, a->siSo);
	printf("\nDanh sach sinh vien:\n");
	xuatDSHS(b, n);
}
