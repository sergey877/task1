﻿//Прибавление и умножение смешанных типов данных
int i1=5;
int i2=6;
int sum=i1+i2;
Console.WriteLine(sum);

long l1=6;// при смешанном прибавлении данных выбирают наибольшее или дробное если участвуют целые и дробные
long sum2=l1+i1;
Console.WriteLine(sum2);

double d1=5.5;
double sum3=d1+i1;
Console.WriteLine(sum3);

int product1=i1*i2; // умножение разных типов данных
long product2 = l1*i1;
double product3=d1*i1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient=i1/i2;
Console.WriteLine(quotient);//неправильно пример

d1=6;
double quotient2 =i1/d1;
Console.WriteLine(quotient2);