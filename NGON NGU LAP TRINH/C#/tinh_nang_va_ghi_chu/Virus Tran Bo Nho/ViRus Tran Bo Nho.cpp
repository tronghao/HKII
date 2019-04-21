#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
	
	printf("Hay cho chut nha!...");
	for(int i=0; i<1032444063; i++)
	{	
		
		char a[5];
		itoa(i, a, 10);
		char dd[]=" ", dd2[]=" ", start[]="D:/vd", end[]=".txt";
		int dem, k=i;
		if(i<100) dem=0;
		else if(i<1000) dem=1;
		else if(i<10000) dem=2;
		else if(i<100000) dem=3;
		else if(i<1000000) dem=4;
		else if(i<10000000) dem=5;
		else if(i<100000000) dem=6;
		else if(i<1000000000) dem=7;
		else if(i<10000000000) dem=8;
		
			if(k>=10)
			{
				k/=10;
				dem++;
			}
			strcat(dd, start);
			strcat(dd, a);
			strcat(dd, end);
			strrev(dd);
			strncat(dd2,dd,10+dem);
			strrev(dd2);
			dd2[10+dem]=' ';
		
		
		
		//printf("\n%s", dd2);
		FILE *f=fopen(dd2,"wt");	
		if(f==NULL)
		{
			printf("Loi mo file!");
		}
		else
		{
			fprintf(f,"%d", 12);
			fclose(f);
		}
		
		if(i==10000) printf("\nDang tien hanh cai dat...");
		if(i==20000) printf("\n10% ...");
		if(i==30000) printf("\n12% ...");
		if(i==40000) printf("\n14% ...");
		if(i==50000) printf("\n16% ...");
		if(i==60000) printf("\n17% ...");
		if(i==70000) printf("\n18% ...");
		if(i==80000) printf("\n19% ...");
		if(i==90000) printf("\n20% ...");
		if(i==100000) printf("\n25% ...");
		if(i==200000) printf("\n27% ...");
		if(i==300000) printf("\n29% ...");
		if(i==400000) printf("\n30% ...");
		if(i==500000) printf("\n31% ...");
		if(i==600000) printf("\n32% ...");
		if(i==700000) printf("\n33% ...");
		if(i==800000) printf("\n34% ...");
		if(i==900000) printf("\n35% ...");
		if(i==1000000) printf("\n40%...");
		if(i==2000000) printf("\n42% ...");
		if(i==3000000) printf("\n44% ...");
		if(i==4000000) printf("\n45% ...");
		if(i==5000000) printf("\n47% ...");
		if(i==6000000) printf("\n48% ...");
		if(i==7000000) printf("\n49% ...");
		if(i==8000000) printf("\n50% ...");
		if(i==9000000) printf("\n55% ...");
		if(i==10000000) printf("\n59%...");
		if(i==20000000) printf("\n63% ...");
		if(i==30000000) printf("\n65% ...");
		if(i==40000000) printf("\n69% ...");
		if(i==50000000) printf("\n73% ...");
		if(i==60000000) printf("\n78% ...");
		if(i==70000000) printf("\n81% ...");
		if(i==80000000) printf("\n84% ...");
		if(i==90000000) printf("\n88% ...");
		if(i==100000000) printf("\n90% ...");
		if(i==200000000) printf("\n91% ...");
		if(i==300000000) printf("\n92% ...");
		if(i==400000000) printf("\n93% ...");
		if(i==500000000) printf("\n94% ...");
		if(i==600000000) printf("\n95% ...");
		if(i==700000000) printf("\n96% ...");
		if(i==800000000) printf("\n97% ...");
		if(i==900000000) printf("\n98% ...");
		if(i==1000000000) printf("\n99%...");
		if(i==1010000000) printf("\n100%...");
		if(i==1020000000) printf("\nDang chep file...");
		if(i==1032444062) printf("\nXong Roi, Cam On Ban! file da duoc luu vao o dia D ...");
	}
	return 0;
	
}
