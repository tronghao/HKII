#include <stdio.h>
#include <conio.h>

int snt (int n);

int main()
{    
	//in cac so nguyen to nho hon n
    int n, dem=0;
    do{
        printf("\nn>0 nhap n= ");
        scanf("%d", &n);
    }while(n<=0);
    printf("cac so nguyen to nho hon n:\n\n");
    for(int i=1; i<n; i++)
        if (snt(i)==1) 
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
