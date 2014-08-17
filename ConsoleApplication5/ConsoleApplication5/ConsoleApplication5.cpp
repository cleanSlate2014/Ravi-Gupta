// ConsoleApplication5.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<stdio.h>
#include<conio.h>
#include<string.h>



int _tmain(int argc, _TCHAR* argv[])
{
	 char keywords[20][20];
     char code[6][20] = {"if","else","break","then","case","switch"};
     char input[500];
     int cmp,flag=0;
     double constant[10];
     printf("Enter Your Code");
     gets(input);
     for(int i=0;i<6;i++)
     {
             cmp = strcmp(input,code[i]);
             if(cmp == 0)
             {
                    flag = 1;
             }
     }
     if(flag == 0)
     {
             printf("It is not a Keyword");
     }
     else
     {
         printf("It is a Keyword");
     }
     

	return 0;
}

