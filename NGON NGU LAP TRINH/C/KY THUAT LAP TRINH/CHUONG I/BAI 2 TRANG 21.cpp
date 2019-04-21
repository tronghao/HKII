#include <stdio.h>
#include <conio.h>

int snt (int n);
int tong(int n);

int main()
{    
	//so co 5 chu so va tong bang n cho truoc (1<=n<=45)
	int n, dem=0;
	do{
		printf("\n0<n<46 nhap n= ");
		scanf("%d", &n);
	}while(n<0||n>46);
	printf("\ncac so nguyen to co 5 chu so va tong cac chu so bang %d:\n\n", n, n);
	for(int i=10000; i<100000; i++)
		if (snt(i)==1 && tong(i)==n) 
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

int snt (int n)
{
	if(n==1) return 0;
	for(int i=2; i<n; i++)
	{
		if (n%i==0) return 0;
	}
	return 1;
}
int tong(int n)
{
	int s=0;
	for(int i=0; i<5; i++)
	{
		s+=(n%10);
		n/=10;
	}
	return s;
}
