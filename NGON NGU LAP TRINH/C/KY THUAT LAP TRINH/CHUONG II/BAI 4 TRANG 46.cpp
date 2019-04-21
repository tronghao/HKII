#include <stdio.h>
#include <conio.h>

void nhap(int a[][10], int m, int n, char c);

int main() 
{
    //A[m][n]; B[n][m]; Tinh AxB
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
    nhap(b, n,m, 'B');
    printf("\nma tran a\n");
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            printf("%4d", a[i][j]);
            
        }       
        printf("\n");    
	}
	printf("\nma tran b\n");
	for(int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {
            printf("%4d", b[i][j]);
            
        }       
        printf("\n");    
	}
    int matrantich[10][10];
    for(int i=0; i<m; i++)
        for(int j=0; j<n; j++)
        {
        	matrantich[i][j]=0;
    		for(int k=0;k<n;k++)  
			{  
				matrantich[i][j]+=a[i][k]*b[k][j];  
			}  
		}
    printf("tich hai ma tran la:\n");        
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<m; j++)
        {
            printf("%4d", matrantich[i][j]);
            
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

