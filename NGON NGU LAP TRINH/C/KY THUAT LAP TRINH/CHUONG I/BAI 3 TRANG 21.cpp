#include <stdio.h>
#include <conio.h>

int main()
{
	//NHAP VAO MOT SO CHO BIET SO CO MAY CHU SO VA TONG CAC CHU SO
 	int n, dem=0, s=0;
 	do{
 	    printf("\nn>0 nhap n= ");
	     scanf("%d", &n);
	 }while(n<=0);
	 int m=n;
 	for(int i=0;n>9; i++)
	{
  	   s+=(n%10);
  	   n/=10;
  	   dem++;
 	}
	 s+=n;
	 printf("\n%d co %d chu so va tong cac chu so bang %d",m, dem+1,s);
 	
	 getch();
	 return 0;
}
