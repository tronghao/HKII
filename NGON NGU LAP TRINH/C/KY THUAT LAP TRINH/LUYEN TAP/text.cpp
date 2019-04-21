#include "stdio.h"

typedef struct Nhan_Vien
{
	char maNV[5];
	char tenNV[20];
	float luong;
	int namSinh;
}NV;

void nhap(NV &a);
void xuat(NV a);
void nhapn(NV a[], int n);
void xuatn(NV a[], int n);
void writeF(NV a[], int n);
void readF(NV a[], int &n);

int main()
{
	NV a[2]; int n;
	//nhapn(a, 2);
	//xuatn(a, 2);
	//writeF(a, 2);
	scanf("%d", &n);
	readF(a, n);
	xuatn(a, n);
	return 0;
}

void nhap(NV &a)
{
	printf("\nNhap ma nhan vien: ");
	fflush(stdin);
 	scanf("%s", a.maNV);
	
	printf("Nhap ten nhan vien: ");
	fflush(stdin);
	gets(a.tenNV);
	
	printf("Luong: ");
	scanf("%f", &a.luong);
	
	printf("Nam Sinh: ");
	scanf("%d", &a.namSinh);
}

void xuat(NV a)
{
	printf("\nMa NV: %s\tTen NV: %s\t\tLuong: %.2f\t\tNam Sinh: %d", a.maNV, a.tenNV, a.luong, a.namSinh);
}

void nhapn(NV a[], int n)
{
	for(int i=0; i<n; i++)
	{
		nhap(a[i]);
	}
}

void xuatn(NV a[], int n)
{
	printf("Danh Sach:\n");
	for(int i=0; i<n; i++)
	{
		xuat(a[i]);
	}
}

void writeF(NV a[], int n)
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


void readF(NV a[], int &n)
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
			fread(&a[dem], sizeof(NV), 1, f);
			dem++;
		}
	
		fclose(f);
	}
	n=dem-1;
}
