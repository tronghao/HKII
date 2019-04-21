#include <stdio.h>
#include <conio.h>

void nhap(int a[][10], int m, int n, char c);

int main() 
{
    //A[m][n]; B[m][n]; Tinh A+B, A-B
    int a[10][10], b[10][10],m, n;
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
    nhap(a, m,n, 'A');
    nhap(b, m, n, 'B');
    int c[10][10], d[10][10];
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
            c[i][j]=(a[i][j]+b[i][j]);
            
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
            d[i][j]=(a[i][j]-b[i][j]);
    
    printf("\ntong hai ma tran la:\n");        
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            printf("%3d", c[i][j]);
            
        } 
		printf("\n");
	}
	printf("\nhieu hai ma tran la:\n");        
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            printf("%3d", d[i][j]);
            
        } 
		printf("\n");           
	}  
	
    getch();
    return 0;
}

void nhap(int a[][10], int m, int n, char c)
{
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
        {
            printf("\n%c[%d][%d] = ", c,i+1,j+1);
            scanf("%d", &a[i][j]);
        }
}

