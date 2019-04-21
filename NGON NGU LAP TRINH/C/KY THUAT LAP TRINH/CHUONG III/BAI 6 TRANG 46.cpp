#include <stdio.h>
#include <conio.h>


int main() 
{
    //tinh hieu P(x) bac n va Q(x) bac m
    int a[10], b[10], n, m, max, flag;
    do{
        printf("\nnhap bac cua da thuc P(x) n=");
        scanf("%d", &n);
        if(n<=0 || n>10) printf("ban nhap sai moi ban nhap lai\n");
    }while(n<=0 || n>10);
    do{
        printf("\nnhap bac cua da thuc Q(x) m=");
        scanf("%d", &m);
        if(m<=0 || m>10) printf("ban nhap sai moi ban nhap lai\n");
    }while(m<=0 || m>10);
    
    printf("\nnhap da thuc P(x)\n");
    for(int i=0; i<=n; i++)
    {
    	if(i==n)
		{ 	printf("nhap he so tu do:");
			scanf("%d", &a[i]);
		}
		else{
        	printf("nhap he so bac %d:", n-i);
       		scanf("%d", &a[i]);
        }
    }
    
    printf("\nnhap da thuc Q(x)\n");
    for(int i=0; i<=m; i++)
    {
    	if(i==m)
		{ 	printf("nhap he so tu do:");
			scanf("%d", &b[i]);
		}
		else{
        printf("nhap he so bac %d:", n-i);
        scanf("%d", &b[i]);
        }
    }
    
    if(n>=m)
    {
        max=n;
        flag=1;
    }
    else
    {
        max=m;
        flag=0;
    }
    
    int c[10], dem=0;
    for(int i=0; i<=max; i++)
    {
        if(m==n) 
			{
				if(flag==1) 
				{
					c[i]=a[i]-b[dem];
					dem++;
				}
				else
				{
					c[i]=a[dem]-b[i];
					dem++;
				}
			}
        else if(flag==1) 
				{
					c[i]=a[i];
					n--;
				}
            else
			{
				c[i]=(-1)*b[i];
				m--;
			}
    }
    
    
    printf("\nhieu 2 da thuc la: ");
 
    for(int i=0; i<=max; i++)
    {
    	if(i==max) printf("%d", c[i]);
        else printf("%d x^%d + ", c[i], max-i);
    }
    
    getch();
	return 0;
}

