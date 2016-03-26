// Circular primes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <cmath> 
int judge_prime(int i)
        {

            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0) return 0;
            }
            return 1;
        }
int circular(int i)
{
	int a=0,b=0;
	int digi[6]={0};
	int index=0;
	a=i;
	//index = (int)log10(a);
	
	while (a>0)
	{
		digi[index]=a%10;
		index++;
		a=a/10;
	}

	a=0;
	b=0;
	for(int j=index-1;j>=0;j--)
	{
		for(int k=j;k>=0;k--)
		{
			a=a*10+digi[k];
			
		}
		for(int t=index-1;t>j;t--)
				a=a*10+digi[t];
		if(judge_prime(a)==0) 
		{b=-1;break;}
		a=0;
	}
	if (b==-1)
	{
		return 0;
	}
	else return 1;
}
int _tmain(int argc, _TCHAR* argv[])
{
	int counter=0;
	counter=circular(197);

	counter=0;
	int j=0;
	
	for (int i=2;i<1000000;i++)
	{
		if (judge_prime(i)!=0)
		{	
			j=circular(i);
			if (j==1) printf("\r\nFor %d : %d",i,j);
			counter+=j;
		
		}
	}
	printf("\r\n Total %d primes found!", counter);
	return 0;
}

