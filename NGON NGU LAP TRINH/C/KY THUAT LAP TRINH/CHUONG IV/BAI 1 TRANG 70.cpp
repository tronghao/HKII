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
	dtb=(float*)malloc(sizeof(float)*so_luong);	
	m=(MS*)malloc(sizeof(MS)*so_luong);
	for(int i=0; i<so_luong; i++)
	{
		printf("\n ****\n nhap thong tin sinh vien %d\n", i+1);
		nhap(dssv+i);
	}
	int luaChon;
do{	
	system("cls");
	printf("\n 0.Exit\n 1.Xuat danh sach sinh vien\n");
	printf(" 2.Tim sinh vien theo ma so\n 3.Danh sach sinh vien loai gioi\n");
	printf(" 4.Tim sinh vien theo ten\n 5.Danh sach sinh vien theo diem trung binh tang dan\n");
	printf(" 6.Danh sach sinh vien theo thu tu alphabet\n");
	
	do{
		printf("\n Lua chon cua ban: ");
		scanf("%d", &luaChon);
		if(luaChon<0||luaChon>6) printf(" ***\nVui long chon lai\n***");
	}while(luaChon<0||luaChon>6);
	

	switch(luaChon)
	{
		case 0: 
		{	
			break;
		}
		case 1:
		{
			printf("\n\n ***Danh sach sinh vien***\n");
			for(int i=0; i<so_luong; i++)
			{
				printf("\n %d)", i+1);
				xuat(dssv+i);
			}
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 2:
		{
			printf("\n nhap ma so can tim: ");
			fflush(stdin);
			gets(find);
			for(int i=0; i<so_luong; i++)
			{
				if(strcmp(find, (dssv+i)->mssv)==0)
				{
					xuat(dssv+i);
					dem++;
				}
			}
			if(dem==0) printf("\n Sinh vien co ma so %s khong ton tai", find);	
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 3:
		{
			dem=0;
			printf("\n\n Danh sach sinh vien loai gioi:");
			for(int i=0; i<so_luong; i++)
			{
				if(((dssv+i)->dtb)>=8)
				{
					printf("\n %d)", dem+1);
					printf(" %s %s", (dssv+i)->ho_lot, (dssv+i)->ten);
					dem++;
				}
			}
			if(dem==0) printf("\n ***KHONG CO***", find);	
			printf("\n\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 4:
		{
			printf("\n\n nhap ten can tim: ");
			fflush(stdin);
			gets(find);
			dem=0;
			for(int i=0; i<so_luong; i++)
			{
				if(strcmp(find, (dssv+i)->ten)==0)
				{
					xuat(dssv+i);
					dem++;
				}
			}
			if(dem==0) printf("\n Sinh vien %s khong ton tai\n", find);	
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 5:
		{
			float tam;
			for(int i=0; i<so_luong; i++)
			{
				dtb[i]=(dssv+i)->dtb;
			}
			for(int i=0; i<so_luong-1; i++)
			{
			for(int j=i+1; j<so_luong; j++)
				if(dtb[i]>dtb[j])
				{
					tam=dtb[j];
					dtb[j]=dtb[i];
					dtb[i]=tam;
				}
			}
			dem=0;
			printf("\n Danh sach sinh vien sap xep theo diem trung binh tang dan:\n");
			for(int i=0; i<so_luong; i++)
			{
				for(int j=0; j<so_luong; j++)
					if(dtb[i]==(dssv+j)->dtb)
					{
						printf("\n %d)", dem+1);
						printf("   %s %s", (dssv+j)->ho_lot, (dssv+j)->ten);
						int k=strlen((dssv+j)->ho_lot)+strlen((dssv+j)->ten);
						for(int i=0; i<(20-k); i++)
							printf(" ");
						printf("\t DTB = %.2f", (dssv+j)->dtb);
						dem++;
					}
			}	
			printf("\n\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 6:
		{
			char ss1[30], ss2[30], tam[30];
			for(int i=0; i<so_luong; i++)
			{
				strcpy((m+i)->ms,(dssv+i)->mssv);
				strcpy((m+i)->tenn,(dssv+i)->ten);
			}
			int flag=1;
			for(int i=0; i<so_luong-1; i++)
			{
				for(int j=i+1; j<so_luong; j++)
				{
					flag=1;
					strcpy(ss1,(m+i)->tenn); strupr(ss1);
					strcpy(ss2,(m+j)->tenn); strupr(ss2);
					for(int i=0; i<30; i++)
					{
						if((int)ss1[i]>(int)ss2[i])
						{
							strcpy(tam,(m+j)->ms);
							strcpy((m+j)->ms,(m+i)->ms);
							strcpy((m+i)->ms,tam);
						
							strcpy(tam,(m+j)->tenn);
							strcpy((m+j)->tenn,(m+i)->tenn);
							strcpy((m+i)->tenn,tam);
							flag=0;
							break;
						}
						if((int)ss1[i]==(int)ss2[i])
						{
							continue;
						}
						if((int)ss1[i]<(int)ss2[i]) 
						{
							flag=0;
							break;
						}
					}
					if(flag==1)
					{
							strcpy(tam,(m+j)->ms);
							strcpy((m+j)->ms,(m+i)->ms);
							strcpy((m+i)->ms,tam);
						
							strcpy(tam,(m+j)->tenn);
							strcpy((m+j)->tenn,(m+i)->tenn);
							strcpy((m+i)->tenn,tam);
					}
				}
			dem=0;
			printf("\n Danh sach sinh vien sap xep theo thu tu alphabet:\n");
			for(int i=0; i<so_luong; i++)
			{
				for(int j=0; j<so_luong; j++)
					if(strcmp((m+i)->ms,(dssv+j)->mssv) == 0)
					{
						printf("\n %d)", dem+1);
						xuat(dssv+j);
						dem++;
					}
			}	
			printf("\n\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
	}
}
}while(luaChon!=0);
	
	free(dssv);	free(dtb); free(m);
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
	printf("\t DTB = %.2f \t Nam sinh: %d\n", dssv->dtb, dssv->yearB);
}
