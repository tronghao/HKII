#include <stdio.h>
#include <conio.h>



int main()
{    
	//in cac so nguyen to nho hon n
    int a[200], dem=0;
    a[0]=1; a[1]=1;
    for(int i=2; i<200; i++)
   		 a[i]=a[i-2]+a[i-1];
   	
   	//a)nhap so n va in ra n so fibonacii dau tien
   	int n;
   	do{
   		printf("\nnhap so luong so fibonacii can in\n");
		printf("n>0 nhap n= ");
		scanf("%d", &n);
	}while(n<=0);
	printf("\n");
   	for(int i=0; i<=n-1; i++)
    	{
    		printf("\t%4d",  a[i]);
			dem++;
			if(dem%10==0) 
				printf("\n\n");
		}
    
    //b)nhap so n va in ra so fibonacii <=n
	int m;
   	do{
   		printf("\n\nin cac so fibonacii<=m\n");
		printf("m>0 nhap m= ");
		scanf("%d", &m);
	}while(m<=0);
	printf("\n");
   	for(int i=0; a[i]<=m; i++)
    	{
    		printf("\t%4d",  a[i]);
			dem++;
			if(dem%10==0) 
				printf("\n\n");
		}
    
	getch();
	return 0;
}

