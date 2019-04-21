#include <stdio.h>
#include <conio.h>
#include <math.h>

int tong_3(int n);

int main()
{    
	//so co 3 chu so va tong lap phuong bang chinh no (so AMSTRONG)
	int dem=0;	
	printf("\ncac so co 3 chu so va tong lap cac chu so bang chinh no la:\n\n");
	for(int i=100; i<1000; i++)
		if (tong_3(i)==i) 
		{	
		printf("\t\t%4d)%6d", dem+1, i);
			dem++;
			if(dem%4==0) 
				printf("\n\n");
		}
	
	getch();
	return 0;
}

int tong_3(int n)
{
	int s=0;
	for(int i=0; i<3; i++)
	{
		s+=(pow((n%10),3));
		n/=10;
	}
	s+=(pow(n,3));
	return s;
}
