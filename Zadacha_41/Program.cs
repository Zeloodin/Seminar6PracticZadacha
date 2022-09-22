using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

using MyClassLibrary;

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// input:   10901,13432 2143.121 142113 13,11 1,13 1, 42 3. 3 23 1,42211  .142421 ,124231 ,24.,25,4642
// output:  10901,13432 2143,121 142113 13,11 1,13 1 42 3 3 23 1,42211 142421 124231 24 25,4642

// input:   10901.13432 2143.121 142113 13.11 1.13 1. 42 3. 3 23 1.42211  .142421 .124231 .24..25.4642
// output1: 10901.13432 2143.121 142113 13.11 1.13 1. 42 3. 3 23 1.42211  .142421 .124231
// output2: 0 0 142113 0 0 0 42 0 3 23 0 142421 124231 0 4642


// input:   25,005,004,932,92345
// output:  25,005 004,932 92345

// input:   923-454(345,345-,0.245,-3495)
// output:  923 -454 345,345 0,245 -3495



///TODO: В условии if(isItADotOrAComma), не добавляет в строку numList
///                 numList += ".";
///                 numList += match.Groups["second"].Value;
/// Использовал Regex, Linq.
/// Пользователь вводит числа через пробел.
/// Этот код фильтрует и выводит double список чисел.
/// Дата и время: 23.09.2022 02:19

// double[] FormattingAStringIntoAListOfNumbers(string stringWithNumbers)
// {
//     stringWithNumbers = stringWithNumbers.Replace(",",".");
//     string numList = string.Empty;


//     Regex pattern = new Regex(@"(?<first>[-+]*\d+)(?<point>[.,]*)(?<second>\d*)",
//                         RegexOptions.IgnoreCase); //| RegexOptions.Multiline);

//     MatchCollection matches = pattern.Matches(stringWithNumbers);

//     if (matches.Count > 0)
//     {

//         foreach (Match match in matches){
//             numList = numList + match.Groups["first"].Value;
            
//             bool isItADotOrAComma = false;
//             try
//             {
//                 if (Convert.ToString((match.Groups["point"].Value)) == "") isItADotOrAComma = true;
//             }
//             catch(System.IndexOutOfRangeException)
//             {
//                 isItADotOrAComma = true;
//             }

//             Console.WriteLine($"{isItADotOrAComma}");

//             if(isItADotOrAComma)
//             {
//                 numList += ".";
//                 numList += match.Groups["second"].Value;
//             }
//             numList += " ";


//             Console.WriteLine($"{isItADotOrAComma} {match.Groups["first"].Value} {match.Groups["point"].Value} {match.Groups["second"].Value}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Совпадений не найдено.");
//     }

//     int numListSplitLenght = numList.Split(" ").Length;
//     string[] numListSplit = numList.Split(" ");

//     double[] result = new double[numListSplitLenght-1];
//     for (int i = 0; i < numListSplitLenght-1; i++)
//     {
//         try
//         {
//             result[i] = Convert.ToDouble(numListSplit[i]);
//         }
//         catch(System.FormatException)
//         {

//         }
//     }
//     return result;
// }



// // string inputString = (Convert.ToString(Console.ReadLine()));

// string inputString ="10901,13432 2143.121 142113 13,11 1,13 1, 42 3. 3 23 1,42211  .142421 ,124231 ,24.,25,4642";


// // double[] outListNumber = 
// // FormattingAStringIntoAListOfNumbers(inputString);

// foreach (var i in FormattingAStringIntoAListOfNumbers(inputString))
// {
//     Console.Write($"{i} ");
// }
























