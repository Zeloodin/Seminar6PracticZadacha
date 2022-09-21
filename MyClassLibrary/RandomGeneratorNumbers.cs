namespace MyClassLibrary;
public class RandomGeneratorNumbers
{
    static public double[] FillingAnArrayWithConsecutiveNumbers(int numLenght, ref double[] arrNum)
    {
        for(int n = 0; n < numLenght; n++)
        {
            arrNum[n] = n;
        }
        
        return arrNum;
    }

    static public double[] GeneratorOfRandomNonRepeatingNumbersIntoAnArray(double[] arrNum, ref double[] listNumber)
    { 
        double[] arrNumbers = arrNum;
        for(int i = 0; i < arrNum.Length; i++)
        {
            int rndTempNum = new Random().Next(0, arrNumbers.Length - i); // - i
            listNumber[i] = arrNumbers[rndTempNum];
            double tempNum = arrNumbers[rndTempNum];
            arrNumbers[rndTempNum] = arrNumbers[arrNumbers.Length - i - 1];
            arrNumbers[arrNumbers.Length - i - 1] = tempNum;
            
        }
        return listNumber;
    }

    static public double[] RandomNonRepeatingNumberGenerator(int lenghtNum)
    {
        int lenghtListNumber = lenghtNum;
        double[] arrayNumber = new double[lenghtListNumber];
        double[] listNumber = new double[lenghtListNumber];
        FillingAnArrayWithConsecutiveNumbers(numLenght:lenghtListNumber, ref arrayNumber);
        GeneratorOfRandomNonRepeatingNumbersIntoAnArray(arrNum: arrayNumber, listNumber: ref listNumber);
        return listNumber;
    }
}
