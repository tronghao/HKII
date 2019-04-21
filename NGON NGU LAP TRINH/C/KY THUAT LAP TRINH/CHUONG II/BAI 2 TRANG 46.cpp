#include <stdio.h>
#include <conio.h>

void nhap(int a[], int n, char c);
void xuat(int a[], int n);
int snt(int n);

int main()
{
    int a[50], b[50], m, n;
    do{
        printf("\nnhap so phan tu A n=");
        scanf("%d", &n);
        if(n<=0) printf("ban nhap sai moi ban nhap lai\n");
    }while(n<=0);
    do{
        printf("\nnhap so phan tu B m=");
        scanf("%d", &m);
        if(m<=0) printf("ban nhap sai moi ban nhap lai\n\n");
    }while(m<=0);
    nhap(a,n,'A');
    nhap(b,m,'B');
    int c[50], dem=0, flag=0;
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {
           	if(a[i]==b[j])
           	{	
			    for(int k=0; k<dem;k++)
             	    if(a[i]==c[k])
             		{
					   flag=1;
	           		}
	           		if(flag==1) flag=0;
	           		else 
					{
					  	c[dem]=a[i];
					   	dem++;
					}
			}
	    }
            
    }
    printf("\ngiao cua A va B la:");
    if(dem==0) printf("  ***KHONG CO***");
	else 
	{
		xuat(c,dem);
	}
    
    
  
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<dem; j++)
            if(a[i]==c[j])
            	flag=1;
        if(flag==1) flag=0;
	       	else 
			{
				c[dem]=a[i];
			   	dem++;
			}
	}
	flag=0;
	for(int i=0; i<m; i++)
    {
        for(int j=0; j<dem; j++)
            if(b[i]==c[j])
            	flag=1;
        if(flag==1) flag=0;
	       	else 
			{
				c[dem]=b[i];
			   	dem++;
			}
	}
    printf("\nhop cua A va B la:\n");
    xuat(c, dem);
    
    
    dem=0;
    int asnt[50], bsnt[50];
    for(int i=0; i<n; i++)
    {
        if(snt(a[i])==1)
        {
            asnt[dem]=a[i];
            dem++;
        }
    }
    int dem2=0;
    for(int i=0; i<m; i++)
    {
        if(snt(b[i])==1)
        {
            bsnt[dem2]=b[i];
            dem2++;
        }
    }
    int dem3=0;
    flag=0;
   for(int i=0; i<dem; i++)
    {
        for(int j=0; j<dem2; j++)
        {
           	if(asnt[i]==bsnt[j])
           	{	
			    for(int k=0; k<dem3;k++)
             	    if(asnt[i]==c[k])
             		{
					   flag=1;
	           		}
	           		if(flag==1) flag=0;
	           		else 
					{
					  	c[dem3]=asnt[i];
					   	dem3++;
					}
			}
	    }
            
    }
    printf("\nso nguyen to chung cua A va B:");
    if(dem3==0) printf("  ***KHONG CO***");
	else 
	{
		printf("\n");
		xuat(c,dem3);
	}
    
    getch();
 	return 0;
}

void nhap(int a[], int n, char c)
{
    for(int i=0; i<n; i++)
    {
        printf("%c[%d] = ", c, i+1);
        scanf("%d", &a[i]);
        
    }
}

void xuat(int a[], int n)
{
    for(int i=0; i<n; i++)
        printf("%7d", a[i]);
}

int snt(int n)
{
    if(n<2) return 0;
    for(int i=2; i<n; i++)
        if(n%i==0) return 0;
    return 1;
}
