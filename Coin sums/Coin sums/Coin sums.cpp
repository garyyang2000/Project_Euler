// Coin sums.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int a[]={1,2,5,10,20,50,100,200};
	int b[202][8]={0};
	for(int i=0;i<=201;i++)
	{
		b[i][0]=1;
	}
	for(int i=1;i<=201;i++)
	{
		printf("For %d: %d",i,b[i][0]);
		for(int j=1;j<8;j++)
		{
			b[i][j]=0;
			if (i>a[j])
			{
				b[i][j]+=b[i][j-1];
				b[i][j]+= b[i-a[j]][j];
			}else{
				b[i][j]=b[i][j-1];
			
			}
			printf(" %d",b[i][j]);
		}
		printf("\r\n");
	}
	printf("/r/n");
	return 0;
}

