using System;
using System.Globalization;
using System.Linq;

namespace Utilities;

public class StringTools
{
    //Removes all text from a string, leaving only numbers and separators.
    public static float StringToFloat(string self)
    {
        CultureInfo cultureInfo = new CultureInfo("en-US", false);
        string stripAlphabet = new string(self.Where(c=>(Char.IsDigit(c) || c=='.'|| c==',')).ToArray());
        //stripAlphabet.Replace(",", ".");
        //string.Format(cultureInfo, stripAlphabet);
        float.TryParse(stripAlphabet.Replace(",", "."), cultureInfo, out float stringFloat);
        return stringFloat;
    }
    public static int StringToInt(string self)
    {
        CultureInfo cultureInfo = new CultureInfo("en-US", false);
        string stripAlphabet = new string(self.Where(c=>(Char.IsDigit(c) || c=='.'|| c==',')).ToArray());
        //stripAlphabet.Replace(",", ".");
        //string.Format(cultureInfo, stripAlphabet);
        int.TryParse(stripAlphabet.Replace(",", "."), cultureInfo, out int stringInt);
        return stringInt;
    }
}
