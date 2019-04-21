#include <stdio.h>
#include <conio.h>

int tong_uoc(int n);

int main()
{    //in cac so hoan hao nho hon n
	int n, tich=1, dem=0;
	do{
		printf("\nn>0 nhap n= ");
		scanf("%d", &n);
	}while(n<=0);
	printf("\ncac so nho hon %d va co tong uoc bang chinh no:\n\n", n);
	for(int i=1; i<=n; i++)
		if(i==tong_uoc(i)) 
		{
			printf("\t\t%4d)%6d", dem+1, i);
			dem++;
			if(dem%3==0) 
				printf("\n\n");
		}
	if(dem==0) printf("*** KHONG CO ***");
	
	getch();
	return 0;
}

int tong_uoc(int n)
{
	int s=0;
	for(int i=1; i<n; i++)
	{
		if(n%i==0) s+=i;
	}
	return s;
}
