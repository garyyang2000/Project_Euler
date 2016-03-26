// Digit fifth powers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	long i=0;
	long sum=0;
	long total=0;
	for (i=33;i<354294;i++)
	{
		long d=i,j=0;
		
		while (d>=1)
		{
			j=d%10;
			d=(int)d/10;
			sum+=j*j*j*j*j;
		}
		if (sum==i) {printf("New fifth digit found: %d\r\n",i);total+=i;}
		sum=0;

	}
	printf("Sum of these digits is %d",total);
	return 0;
}

