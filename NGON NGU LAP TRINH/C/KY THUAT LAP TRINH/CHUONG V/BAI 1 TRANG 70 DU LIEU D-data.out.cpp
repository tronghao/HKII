#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>

typedef struct SV
{
	
	char mssv[30];
	char ho_lot[30];
	char ten[30];
	int gt;
	float dtb;
	int yearB;
};

typedef struct MS
{	
	char ms[30];
	char tenn[30];
};

void nhap(SV *dssv);
void xuat(SV *dssv);

int main()
{	
	
	

	SV *dssv;
	float *dtb;
	MS *m;
	char find[30];	int dem=0;
	int so_luong;
	do{
		printf("\n nhap so luong sinh vien: ");
		scanf("%d", &so_luong);
		if(so_luong<=0||so_luong>10) printf("\n vui long kiem tra lai\n\n");
	}while(so_luong<=0||so_luong>10);
	dssv=(SV*)malloc(sizeof(SV)*so_luong);

	/*char dd[50];
	printf("\n Nhap duong dan: ");
	fflush(stdin);	gets(dd);
	FILE *f;
	f=fopen(dd,"rb");
	if(f==NULL) printf("\n Loi mo file");
	else
	{
		fread(dssv, sizeof(SV), so_luong, f);
		fclose(f);
	}
	*/
	int luaChon;
do{	
	system("cls");
	printf("\n 0.Exit\n 1.Nhap thong tin sinh vien\n 2.Ghi thong tin sinh vien vao tap tin nhi phan\n");
	printf(" 3.Doc tap tin nhi phan va in ra danh sach sinh vien nam\n 4.Danh sach sinh vien loai gioi\n");
	
	do{
		printf("\n Lua chon cua ban: ");
		scanf("%d", &luaChon);
		if(luaChon<0||luaChon>4) printf(" ***\nVui long chon lai\n***");
	}while(luaChon<0||luaChon>4);
	

	switch(luaChon)
	{
		case 0: 
		{	
			break;
		}
		case 1: 
		{	
			for(int i=0; i<so_luong; i++)
			{
				printf("\n ****\n nhap thong tin sinh vien %d\n", i+1);
				nhap(dssv+i);
			}
			break;
		}
		case 2:
		{
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"rb");
			if(f==NULL) printf("\n Loi mo file");
			else
			{
				fread(dssv, sizeof(SV), so_luong, f);
					xuat(dssv);
				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc");
			getch();
			break;
			
			/*
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"wb");
			if(f==NULL) printf("\n Loi mo file");
			else
			{
				fwrite(dssv, sizeof(SV), so_luong, f);
				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc");
			getch();
			break;*/
		}
		case 3:
		{
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"rb");
			if(f==NULL) printf("\n Loi mo file");
			else
			{	
			
				int found=0;
				while(!feof(f))
				{
					fread(dssv, sizeof(SV), so_luong, f);
						if(dssv->gt==1)
						{
							printf("\n %d) ", found);
							xuat(dssv);
							found++;
						}
				}
				if(found==0) printf("\n Trong danh sach khong co sinh vien co gioi tinh nam");
				
				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc");
			getch();
			break;
		}
		case 4:
		{
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			printf("\n\n Danh sach sinh vien loai gioi:");
			FILE *f;
			f=fopen(dd,"rb");
			if(f==NULL) printf("\n Loi mo file");
			else
			{	int found=0;
				while(!feof(f))
				{
					fread(dssv, sizeof(SV), so_luong, f);
						if(dssv->dtb>=8)
						{
							printf("\n %d) ", found);
							xuat(dssv);
							found++;
						}
				}
				if(found==0) printf("\n Trong danh sach khong co sinh vien co diem trung binh 8.0 tro len");
				
				fclose(f);
			}
			getch();
			printf("\n An phim bat ky de tiep tuc");
			break;
		}
	}

}while(luaChon!=0);
	
	free(dssv);	
	printf("\n An phim bat ky de thoat");
	getch();
	return 0;
}

void nhap(SV *dssv)
{
	printf("\n Nhap ma so sinh vien: "); 
	fflush(stdin);
	gets(dssv->mssv);

	printf("\n Nhap ho va ten lot sinh vien: "); 
	fflush(stdin); 
	gets(dssv->ho_lot);
	
	printf("\n Nhap ten sinh vien: "); 
	fflush(stdin); 
	gets(dssv->ten);

	float t;		
	do{
		printf("\n Nhap diem trung binh: ");

		scanf("%f", &t);
		if(t<0||t>10) printf("\nvui long kiem tra lai\n\n");
	}while(t<0||t>10);
	dssv->dtb=t;
	int gioi_tinh;
	do{
		printf("\n 1.Nam   2.Nu\n Gioi tinh:");

		scanf("%d", &gioi_tinh);
		if(gioi_tinh!=1&&gioi_tinh!=2) printf("\nvui long kiem tra lai\n\n");
	}while(gioi_tinh!=1&&gioi_tinh!=2);
	dssv->gt=gioi_tinh;
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
	printf("\t %s\t", dssv->mssv);
	printf(" %s %s", dssv->ho_lot, dssv->ten);
	int k=strlen(dssv->ho_lot)+strlen(dssv->ten);
	for(int i=0; i<(20-k); i++)
		printf(" ");
	if(dssv->gt==1) printf("\tGioi tinh: Nam");
	else	printf("\tGioi tinh: Nu");
	printf("\t DTB = %.2f \t Nam sinh: %d\n", dssv->dtb, dssv->yearB);
}
