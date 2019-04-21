#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>

int la_SNT(int n);

int main()
{	
	int so_luong=1000;
	int *so_nguyen, *snt, *doc;
	so_nguyen=(int*)malloc(sizeof(int)*so_luong);
	snt=(int*)malloc(sizeof(int)*so_luong);
	doc=(int*)malloc(sizeof(int)*so_luong);
	for(int i=0;i<so_luong;i++)
		so_nguyen[i]=i+1;
	int dem=0;
	for(int i=0; i<so_luong; i++)
		if(la_SNT(*(so_nguyen+i))==1)
		{	
			snt[dem] =so_nguyen[i];
			dem++;
		}
			
	int luaChon;
do{	
	system("cls");
	printf("\n 0.Exit\n 1.Tao tap tin chua so nguyen tu 1 den 1000\n");
	printf(" 2.Doc tap tin vua lap\n 3.Tao tap tin chua so nguyen to\n");

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
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"wt");
			if(f==NULL) printf("\n Loi mo file");
			else
			{
				for(int i=0; i<so_luong; i++)
					fprintf(f,"%d  ", so_nguyen[i]);
				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 2:
		{
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"rt");
			if(f==NULL) printf("\n Loi mo file");
			else
			{
				printf("\n Noi dung file vua doc: \n");
				
				for(int i=0; i<so_luong; i++)
					fscanf(f,"%d", doc+i);
				for(int i=0; i<so_luong; i++)
					printf(" %5d", *(doc+i));

				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
		case 3:
		{
			char dd[50];
			printf("\n Nhap duong dan: ");
			fflush(stdin);	gets(dd);
			FILE *f;
			f=fopen(dd,"wt");
			if(f==NULL) printf("\n Loi mo file");
			else
			{
				for(int i=0; i<dem; i++)
					fprintf(f, "%d  ", snt[i]);
				fclose(f);
			}
			printf("\n An phim bat ky de tiep tuc\n");
			getch();
			break;
		}
	}
}while(luaChon!=0);
	
	free(so_nguyen);	free(snt);	free(doc);
	printf("\n An phim bat ky de thoat");
	getch();
	return 0;
}
int la_SNT(int n)
{
    if(n<2) return 0;
    for(int i=2; i<n; i++)
        if(n%i==0) return 0;
    return 1;
}
