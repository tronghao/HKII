#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

typedef struct SV
{
	char mssv[30];
	char ten[30];
	float dtb;
	int yearB;
};
void nhap(SV *dssv);
void xuat(SV *dssv);

int main()
{
	SV *dssv;
	int so_luong;
	do{
		printf("\n nhap so luong sinh vien: ");
		scanf("%d", &so_luong);
		if(so_luong<=0||so_luong>10) printf("\n vui long kiem tra lai\n\n");
	}while(so_luong<=0||so_luong>10);
	dssv=(SV*)malloc(sizeof(SV)*so_luong);
	for(int i=0; i<so_luong; i++)
	{
		printf("\n ****\n nhap thong tin sinh vien %d\n", i+1);
		nhap(dssv+i);
	}

	printf("\n\n ***Danh sach sinh vien***\n");
	for(int i=0; i<so_luong; i++)
	{
		printf("\n %d)", i);
		xuat(dssv+i,i+1);
	}

	char find[30];
	printf("\n nhap ma so can tim: ");
	fflush(stdin);
	gets(find);
	int dem=0;
	for(int i=0; i<so_luong; i++)
	{
		if(strcmp(find, (dssv+i)->mssv)==0)
			{
				xuat(dssv+i);
				dem++;
			}
	}
	if(dem==0) printf("\n Sinh vien co ma so %s khong ton tai", find);

		free(dssv);
	getch();
	return 0;
}

void nhap(SV *dssv)
{
	printf("\n Nhap ma so sinh vien: "); 
	fflush(stdin);
	gets(dssv->mssv);

	printf("\n Nhap ho ten sinh vien: "); 
	fflush(stdin); 
	gets(dssv->ten);

	float t;		
	do{
		printf("\n Nhap diem trung binh: ");

		scanf("%f", &t);
		if(t<0||t>10) printf("\nvui long kiem tra lai\n\n");
	}while(t<0||t>10);
	dssv->dtb=t;

	int y;	
	do{
		printf("\n Nhap nam sinh: ");

		scanf("%d", &y);
		if(y<1900||y>2018) printf("\nvui long kiem tra lai\n\n");
	}while(y<1900||y>2018);
	dssv->yearB=y;
}

void xuat(SV *dssv)
{
	printf("\n %s\t", dssv->mssv);
	puts(dssv->ten);
	printf("\t DTB = %.2f \t Nam sinh: %d\n", dssv->dtb, dssv->yearB);
}