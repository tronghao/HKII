#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct SOTIETKIEM
{
	char maSo[15];
	char tenKH[100];
	int CMND[11];
	int *ngayMoSo;
	float soTienGui;
} STK;
void nhapKH(STK *a);
void xuatKH(STK *a);
void nhapDSKH(STK *a, int n);
void xuatDSKH(STK *a, int n);

int main()
{
	STK *a;		int n;
	do{
		printf("\nSo luong khach hang: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai moi ban nhap lai\n");
	}while(n<=0);
	a=(STK*)malloc(sizeof(STK)*n);
	nhapDSKH(a, n);
	xuatDSKH(a, n);
	
	free(a);
	getch();
	return 0;
}

void nhapKH(STK *a)
{
	printf("\nNhap ma so: ");
	fflush(stdin);	scanf("%s", a->maSo);
	
	printf("\nNhap ten khach hang: ");
	fflush(stdin);	gets(a->tenKH);
	
	printf("\nSo CMND: ");
	scanf("%d", &a->CMND);
	
	a->ngayMoSo=(int*)malloc(sizeof(int)*3);
	printf("\nThoi gian mo so: ");
		do{
		printf("\n\tNgay: ");
		scanf("%d", (a->ngayMoSo+0));
		if((*(a->ngayMoSo+0)<=0||*(a->ngayMoSo+0)>31)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayMoSo+0)<=0||*(a->ngayMoSo+0)>31);
		
		do{
		printf("\n\tThang: ");
		scanf("%d", (a->ngayMoSo+1));
		if((*(a->ngayMoSo+1)<=0||*(a->ngayMoSo+1)>12)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayMoSo+1)<=0||*(a->ngayMoSo+1)>12);
		
		do{
		printf("\n\tNam: ");
		scanf("%d", (a->ngayMoSo+2));
		if((*(a->ngayMoSo+2)<=1900||*(a->ngayMoSo+2)>2020)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayMoSo+2)<=0||*(a->ngayMoSo+2)>2020);
	
	printf("\nSo tien gui: ");
	scanf("%f", &a->soTienGui);
}
void xuatKH(STK *a)
{	

	printf("\n%s\t%s\tCMND: %d\t%d/%d/%d\tSo tien gui: %.5f", a->maSo, a->tenKH, a->CMND, *(a->ngayMoSo+0),*(a->ngayMoSo+1),*(a->ngayMoSo+2), a->soTienGui);	
}

void nhapDSKH(STK *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhapKH(a+i);
	}
}
void xuatDSKH(STK *a, int n)
{
	for(int i=0; i<n; i++)
	{
		xuatKH(a+i);
	}
}
