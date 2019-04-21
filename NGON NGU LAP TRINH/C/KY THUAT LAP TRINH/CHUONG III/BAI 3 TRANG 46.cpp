#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

void nhap(int *a, int m, int n, char c);

int main() 
{
    //A[m][n]; B[m][n]; Tinh A+B, A-B
    int *a, *b,m, n;
    do{
        printf("\nm>0 nhap m=");
        scanf("%d", &m);
        if(m<=0 || m>10) printf("ban nhap sai moi ban nhap lai\n");
    }while(m<=0 || m>10);
    do{
        printf("\nn>0 nhap n=");
        scanf("%d", &n);
        if(n<=0 || n>10) printf("ban nhap sai moi ban nhap lai\n");
    }while(n<=0 || n>10);
    a=(int*)malloc(m*n*sizeof(int));
    b=(int*)malloc(m*n*sizeof(int));
    nhap(a, m,n, 'A');
    nhap(b, m, n, 'B');
    int *c, *d;
    c=(int*)malloc(10*sizeof(int));
    d=(int*)malloc(10*sizeof(int));
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
            *(c+i*n+j)=(*(a+i*n+j)+*(b+i*n+j));
            
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
            *(d+i*n+j)=(*(a+i*n+j)-*(b+i*n+j));
    
    printf("\ntong hai ma tran la:\n");        
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            printf("%3d", *(c+i*n+j));
            
        } 
		printf("\n");
	}
	printf("\nhieu hai ma tran la:\n");        
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            printf("%3d", *(d+i*n+j));
            
        } 
		printf("\n");           
	}  
	free(a);	free(b);	free(c);	free(d);
    getch();
    return 0;
}

void nhap(int *a, int m, int n, char c)
{
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
        {
            printf("\n%c[%d][%d] = ", c,i+1,j+1);
            scanf("%d", (a+i*n+j));
        }
}

