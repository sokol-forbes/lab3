#include "pch.h"
#include <utility>
#include <limits.h>
#include "MathLibrary.h"
#include <string>
#include <iostream>

using namespace std;

//сумма
int sum()
{
    int a;
    a = 0;
    int b;
    b = 0;

    cout << "Enter a number: ";
    cin >> a;

    cout << "Enter b number: ";
    cin >> b;

    return a + b;
}

//разность
int difference()
{
    int a;
    a = 0;
    int b;
    b = 0;

    cout << "Enter a number: ";
    cin >> a;

    cout << "Enter b number: ";
    cin >> b;

    return a - b;
}

//умножение
int multiplication()
{
    int a;
    a = 0;
    int b;
    b = 0;

    cout << "Enter a number: ";
    cin >> a;

    cout << "Enter b number: ";
    cin >> b;

    return a * b;
}

//деление
double division()
{
    int a;
    a = 0;
    int b;
    b = 0;

    cout << "Enter a number: ";
    cin >> a;

    cout << "Enter b number: ";
    cin >> b;
    
    if (b != 0)
    {
        return (a / b);
    }
    else
    {
        cout << "Wrong b number" << endl;
    }
}

//среднее двух чисел
double average()
{
    int a;
    a = 0;
    int b;
    b = 0;

    cout << "Enter a number: ";
    cin >> a;

    cout << "Enter b number: ";
    cin >> b;

    return (a + b) / 2;
}

//приветствие
int Hello()
{
    cout << "Hello there";

    return 0;
};