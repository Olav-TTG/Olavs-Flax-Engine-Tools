using System;
using System.Linq;

namespace Utilities;

public class StringTools
{
    public static float StringToFloat(string self) //Removes all text from a string, leaving only numbers and separators.
    {
        string stripAlphabet = new string(self.Where(c=>(Char.IsDigit(c) || c=='.'|| c==',')).ToArray());
        float stringFloat;
        float.TryParse(stripAlphabet, out stringFloat);
        return stringFloat;
    }
}
