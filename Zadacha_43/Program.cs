// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using MyClassLibrary;

                                                //   0     1     2     3
string[] variableForValuesToString = new string[] {"b1", "k1", "b2", "k2"};
double[] inputVariable = new double[variableForValuesToString.Length];


for (int valueI = 0; valueI < variableForValuesToString.Length; valueI++)
{
    Console.Write($"Введите число в переменную {variableForValuesToString[valueI]}: ");
    inputVariable[valueI] = Convert.ToDouble(Console.ReadLine());
}

double k1 = inputVariable[1], b1 = inputVariable[0];
double k2 = inputVariable[3] ,b2 = inputVariable[2];

double[] varXAndY = GeometryMy.CrossPoint(k1,b1,k2,b2);
double varX = varXAndY[0];
double varY = varXAndY[1];

Console.WriteLine(GeometryMy.IsNanOrIsInfinity(varX, varY));


