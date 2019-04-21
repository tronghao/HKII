#include <stdio.h>
#include <conio.h>


int main() 
{
    //tinh tong hai da thuc bac n
    int a[10], b[10], n;
        do{
        printf("\nnhap bac cua da thuc n=");
        scanf("%d", &n);
        if(n<=0 || n>10) printf("ban nhap sai moi ban nhap lai\n");
    }while(n<=0 || n>10);

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
    for(int i=0; i<=n; i++)
    {
    	if(i==n)
		{ 	printf("nhap he so tu do:");
			scanf("%d", &b[i]);
		}
		else{
        printf("nhap he so bac %d:", n-i);
        scanf("%d", &b[i]);
        }
    }
    int c[10];
    for(int i=0; i<=n; i++)
    {	
        c[i]=(a[i]+b[i]);
  	}
	printf("\ntong 2 da thuc la: ");
    
    for(int i=0; i<=n; i++)
    {
    	if(i==n) printf("%d", c[i]);
        else printf("%d x^%d + ", c[i], n-i);
    }
    
    getch();
	return 0;
}

