#include <stdio.h>
#include <math.h>
#include <conio.h>

int sdx(int n);

int main()
{   
	//cho so n in n khi da loai bo 0 va 5
	int a[30];
	int dem=0, n;
	do{
		printf("\nn>0 nhap n= ");
		scanf("%d", &n);
	}while(n<=0);
	for(int i=1; n>=10; i++)
	{
		a[i]=(n%10);
		n/=10;
		dem++;
	}
	a[dem+1]=n;
	dem++;
	printf("\nsau khi loai bo so 0 va 5 ta duoc: ");
	for(int i=dem; i>0; i--)
		if(a[i]!=0 && a[i]!=5) printf("%d", a[i]);
	
	getch();
	return 0;
}
