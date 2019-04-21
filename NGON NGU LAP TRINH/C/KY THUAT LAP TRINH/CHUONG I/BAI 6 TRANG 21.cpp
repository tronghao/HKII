#include <stdio.h>
#include <math.h>
#include <conio.h>

int sdx(int n);

int main()
{   
	//liet ke cac so doi xung nam giua hai so m va n cho truoc
	int m, n, tich=1, dem=0;
	do{
		printf("\nstart: m>0 nhap m= ");
		scanf("%d", &m);
	}while(m<=0);
	do{
		printf("\nend: n>0 nhap n= ");
		scanf("%d", &n);
	}while(n<=0||n<m);
	printf("\ncac so doi xung nam giua %d va %d:\n\n", m, n);
	for(int i=m; i<=n; i++)
	{
		if(sdx(i)==1)
		{	
			printf("\t\t%4d)%4d", dem+1, i);
			dem++;
			if(dem%3==0) 
				printf("\n\n");
		}
	}
	if(dem==0) printf("*** KHONG CO ***");
	
	getch();
	return 0;
}

int sdx(int n)
{
	int a[30];
	int dem=0, m=n, s=0;
	if (n<10) return 0;
	for(int i=1; n>=10; i++)
	{
		a[i]=(n%10);
		n/=10;
		dem++;
	}
	a[dem+1]=n;
	dem++;
	int tam=dem;
	for(int j=1; j<=dem; j++)
	{
		s+=(a[j] * pow(10,tam-1));
		tam--;
		
	}
	if(m==s) return 1;
	else return 0;

}
