#include "stdio.h"

int main()
{
	/*
	//bai 8
	int n;
	do{
		printf("Nhap so nguyen duong:");
		scanf("%d", &n);
	}while(n<=0);

	int a[50], dem=0;
	for(int i=1; i<=n; i++)
	{
		if(n%i == 0)
		{
			a[dem] = i;
			dem++;
		}
	}
	printf("Cac uoc so cua %d la: ", n);
	for(int i=0; i<dem; i++)
	{
		printf("%3d", a[i]);
	}
	
	*/

	/*
	//bai 9
	int n;
	do{
		printf("Nhap so nguyen duong:");
		scanf("%d", &n);
	}while(n<=0);

	int dem=1;
	while(n>=10)
	{
		
		//a[dem]= n%10;
		n/=10;
		dem++;
	}
	printf("So cac chu so cua %d la: %d", n, dem);
	*/

	//bai 10
	int n;
	do{
		printf("Nhap so xe:");
		scanf("%d", &n);
	}while(n<=1000 || n>9999);

	int tong=0;
	while(n>=10)
	{
		tong+=n%10;
		
		n/=10;
		
	}
	tong+=n;
	printf("Bang so xe %d co %d nut", n, tong%10);

	

	scanf("%d", &n);
	return 0;
}
