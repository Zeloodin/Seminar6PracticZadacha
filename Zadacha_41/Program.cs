using MyClassLibrary;

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// input:   10901,13432 2143.121 142113 13,11 1,13 1, 42 3. 3 23 1,42211  .142421 ,124231 ,24.,25,4642
// output:  10901,13432 2143,121 142113 13,11 1,13 1 42 3 3 23 1,42211 142421 124231 24 25,4642

// input:   10901.13432 2143.121 142113 13.11 1.13 1. 42 3. 3 23 1.42211  .142421 .124231 .24..25.4642
// output1: 10901.13432 2143.121 142113 13.11 1.13 1. 42 3. 3 23 1.42211  .142421 .124231



// input:   25,005,004,932,92345
// output:  25,005 004,932 92345

// input:   923-454(345,345-,0.245,-3495)
// output:  923 -454 345,345 0,245 -3495

string SelectedNumberFromIndexMinToMax(string inputString, int minIndex, int maxIndex)
{
    string strNum = string.Empty;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        strNum += inputString[i];
    }
    return strNum;
}


double[] FormattingAStringIntoAListOfNumbers(string stringWithNumbers)
{
    stringWithNumbers = stringWithNumbers.Replace(",",".");

    int minIndex = 0 , maxIndex = 0;
    int minIndexSecond = 0 , maxIndexSecond = 0;

    int dotOrCommaIndex = 0;
    int counterNumberOfDotComma = 0;
    string numList = string.Empty;

    for (int indexString = 0; indexString < stringWithNumbers.Length; indexString++)
    {
        if(char.IsNumber(stringWithNumbers[indexString])) // В индексе находится число?
        {
            if(minIndex == 0){            // Если minIndex == 0, значит
                minIndex = indexString;      // вставляем число индекса в переменную minIndex.
                counterNumberOfDotComma = 0; // И обнуляем счётчик counterNumberOfDotComma.
            }
            maxIndex = indexString;         // В maxIndex присваиваем число индекса.
        }
        else if(stringWithNumbers[indexString] == Convert.ToChar(".")){  // В индексе находится точка?
            if (counterNumberOfDotComma == 0)
            {
                counterNumberOfDotComma++; // Инкременет counterNumberOfDotComma++
                dotOrCommaIndex = indexString;
            }
        }
        else if(stringWithNumbers[indexString] == Convert.ToChar(" ")){ // В индексе находится пробел?

            numList += $"{SelectedNumberFromIndexMinToMax(stringWithNumbers, minIndex, maxIndex)} ";
            
        }
        else if(indexString >= stringWithNumbers.Length)
        {
            
            numList += $"{SelectedNumberFromIndexMinToMax(stringWithNumbers, minIndex, maxIndex)} ";
        }

        Console.WriteLine($"\n{stringWithNumbers}\n{SelectedNumberFromIndexMinToMax(stringWithNumbers, minIndex, maxIndex)}\n{minIndex} {maxIndex}\n{numList}\n"); /////////////////////////////

    }
    // string[] strArrayNumList = (numList).Split(" ");
    // double[] result = Array.ConvertAll(strArrayNumList,
    //                                     delegate(string s) {return double.Parse(s); });
    // return result;

    double[] res = {(0.0),(0.0)};
    return res;
}



// string inputString = (Convert.ToString(Console.ReadLine()));

string inputString ="10901,13432 2143.121 142113 13,11 1,13 1, 42 3. 3 23 1,42211  .142421 ,124231 ,24.,25,4642";


double[] outListNumber = FormattingAStringIntoAListOfNumbers(inputString);

foreach (var i in outListNumber)
{
    Console.Write(i);
}
























