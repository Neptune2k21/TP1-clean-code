namespace Tp1.CleanCode;

public class ConvertiseurService
{
    public static string ConvertRomain(int num)
    {
        /*if (num == 1)
        {
            return "I";
        }
        else
        {
            return"II";
        }*/
        Dictionary<int, string> chiffreRomain=  new Dictionary<int, string>
        {
            {1, "I"}, {4, "IV"}, {5, "V"}, {10, "X"}, {50, "L"}, {100, "C"} 
        };
        string result = "";
        foreach(var number in chiffreRomain)
        {
            while (num >= number.Key)
            {
                result += number.Value;
                num -= number.Key;
            }
        }
        return result;
    }

}
