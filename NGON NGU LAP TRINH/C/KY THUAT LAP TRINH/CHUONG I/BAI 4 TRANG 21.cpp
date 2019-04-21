#include <stdio.h>
#include <conio.h>

int main()
{    //tinh n!!
	int n, tich=1;
	do{
 	    printf("\nn>0 nhap n= ");
	     scanf("%d", &n);
	}while(n<=0);
	if (n%2==1)
		for(int i=1; i<=n; i+=2)
			 tich*=i;
	else
		for(int i=2; i<=n; i+=2)
			 tich*=i;
	printf("\n%d!! = %d", n, tich);
	
	getch();
	return 0;
}

