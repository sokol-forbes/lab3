#include "pch.h"
#include <utility>
#include <limits.h>
#include "MathLibrary.h"
#include <string>
#include <iostream>

using namespace std;

//�����
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

//��������
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

//���������
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

//�������
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

//������� ���� �����
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

//�����������
int Hello()
{
    cout << "Hello there";

    return 0;
};