namespace MyClassLibrary;

public class ArrayMy
{
    public static void WriteArray<T>(T[] inputArray,  string spaceEnd = "")
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(inputArray[i] + spaceEnd);
        }
    }
}
