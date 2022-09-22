namespace MyClassLibrary;


public class ConvertMy
{
    
    public static bool TypeToBoolean<T>(T inputType)
    {
        return Convert.ToBoolean(inputType);
    }


    public static byte TypeToByte<T>(T inputType)
    {
        return Convert.ToByte(inputType);
    }


    public static char TypeToChar<T>(T inputType)
    {
        return Convert.ToChar(inputType);
    }


    public static decimal TypeToDecimal<T>(T inputType)
    {
        return Convert.ToDecimal(inputType);
    }


    public static double TypeToDouble<T>(T inputType)
    {
        return Convert.ToDouble(inputType);
    }


    public static short TypeToInt16<T>(T inputType)
    {
        return Convert.ToInt16(inputType);
    }


    public static int TypeToInt32<T>(T inputType)
    {
        return Convert.ToInt32(inputType);
    }


    public static long TypeToInt64<T>(T inputType)
    {
        return Convert.ToInt64(inputType);
    }


    public static sbyte TypeToSByte<T>(T inputType)
    {
        return Convert.ToSByte(inputType);
    }

    public static string TypeToString<T>(T inputType)
    {
        return Convert.ToString(inputType)!;
    }


    public static ushort TypeToUInt16<T>(T inputType)
    {
        return Convert.ToUInt16(inputType);
    }


    public static uint TypeToUInt32<T>(T inputType)
    {
        return Convert.ToUInt32(inputType);
    }


    public static ulong TypeToUInt64<T>(T inputType)
    {
        return Convert.ToUInt64(inputType);
    }



}

