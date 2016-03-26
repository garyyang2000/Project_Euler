// Digit factorials.cpp : Defines the entry point for the console application.
//
#include <iostream>
#include "stdafx.h"

int fac[]={1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880};
int factorial(int n)
{
	int ans=0;
	while(n)
	{
		ans+=fac[n%10];
		n/=10;
	}
	return ans;
}
int _tmain(int argc, _TCHAR* argv[])
{
	int ans=0;
	for(int i=10;i<10000000;i++)
	{   
		if(i==factorial(i))
		{
			ans+=i;printf("New digit found :%d\r\n", i);
		}
	}
	printf("The answer is %ld", ans);

	return 0;
}

