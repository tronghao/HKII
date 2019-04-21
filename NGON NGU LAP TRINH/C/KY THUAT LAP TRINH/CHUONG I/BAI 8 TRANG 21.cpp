#include <stdio.h>
#include <conio.h>

int snt (int n);

int main()
{    
	//phan tich n ra thua so nguyen to
    int n, dem=0, a[30];
    do{
        printf("\nn>0 nhap n= ");
        scanf("%d", &n);
    }while(n<=0);
    printf("\n%d = ", n);
    int m=n;
    if(snt(n)==1) printf("1 x %d", n);
    else
    	{
    		for(int i=1; snt(m)==0; i++)
    		{
    			if(m%2==0) {a[i]=2; dem++; m=m/2;}
				else if(m%3==0) {a[i]=3; dem++; m=m/3;}
				else if(m%5==0) {a[i]=5; dem++; m=m/5;}
				else if (m%7==0) {a[i]=7; dem++; m=m/7;}
			}
			printf("1 x ");
			for(int i=1; i<=dem; i++)
			{
				printf("%d x ", a[i]);
			}
			printf("%d", m);
		}
        
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
