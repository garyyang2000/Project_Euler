// Digit cancelling fractions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int a1[5]={0},b1[5]={0};
	int index =0;
	for (int i =1;i<100;i++)
		for(int j=1;j<100;j++)
		{
			int a = i/10,b =i%10;
			int c=j/10,d=j%10;
			if ((b==c)&&(i*d==j*a)&&(d!=0))
			{
				printf("Found new digits: %d/%d!\r\n",i,j);
				a1[index]=i;b1[index]=j;
				index++;
			}
		}
		printf("total %d digits found!",index);
	return 0;
}

