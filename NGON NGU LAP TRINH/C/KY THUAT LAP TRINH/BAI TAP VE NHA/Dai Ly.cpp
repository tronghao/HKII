#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct DONHANG
{
	char maSo[15];
	char tenKH[100];
	int SDT[11];
	int *ngayNhan;
	char email[50];
} DH;
void nhapDH(DH *a);
void xuatDH(DH *a);
void nhapDSDH(DH *a, int n);
void xuatDSDH(DH *a, int n);

int main()
{
	DH *a;		int n;
	do{
		printf("\nSo luong khach hang: ");
		scanf("%d", &n);
		if(n<=0) printf("Ban nhap sai moi ban nhap lai\n");
	}while(n<=0);
	a=(DH*)malloc(sizeof(DH)*n);
	nhapDSDH(a, n);
	xuatDSDH(a, n);
	
	free(a);
	getch();
	return 0;
}

void nhapDH(DH *a)
{
	printf("\nNhap ma so don hang: ");
	fflush(stdin);	scanf("%s", a->maSo);
	
	printf("\nNhap ten khach hang: ");
	fflush(stdin);	gets(a->tenKH);
	
	printf("\nSo dien thoai: ");
	scanf("%d", &a->SDT);
	
	a->ngayNhan=(int*)malloc(sizeof(int)*3);
	printf("\nThoi gian nhan: ");
		do{
		printf("\n\tNgay nhan: ");
		scanf("%d", (a->ngayNhan+0));
		if((*(a->ngayNhan+0)<=0||*(a->ngayNhan+0)>31)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayNhan+0)<=0||*(a->ngayNhan+0)>31);
		
		do{
		printf("\n\tThang nhan: ");
		scanf("%d", (a->ngayNhan+1));
		if((*(a->ngayNhan+1)<=0||*(a->ngayNhan+1)>12)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayNhan+1)<=0||*(a->ngayNhan+1)>12);
		
		do{
		printf("\n\tNam nhan: ");
		scanf("%d", (a->ngayNhan+2));
		if((*(a->ngayNhan+2)<=1900||*(a->ngayNhan+2)>2020)) printf("\tMong ban kiem tra lai\n\n");
		}while(*(a->ngayNhan+2)<=0||*(a->ngayNhan+2)>2020);
	
	printf("\nEmail: ");
	fflush(stdin);	scanf("%s", &a->email);
}
void xuatDH(DH *a)
{	

	printf("\n%s\t%s\tSDT: %d\t%d/%d/%d\tEmail: %s", a->maSo, a->tenKH, a->SDT, *(a->ngayNhan+0),*(a->ngayNhan+1),*(a->ngayNhan+2), a->email);	
}

void nhapDSDH(DH *a, int n)
{
	for(int i=0; i<n; i++)
	{
		nhapDH(a+i);
	}
}
void xuatDSDH(DH *a, int n)
{
	for(int i=0; i<n; i++)
	{
		xuatDH(a+i);
	}
}
