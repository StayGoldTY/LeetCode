using System.Text;

namespace LeetCode;

public class Q709
{
    public static string ToLowerCase(string s) {
        StringBuilder ret = new StringBuilder(); ;
        foreach (char c in s)
        {

           var charNew =  (int)c >= 65 && (int)c <= 90 ? (char)(c | 32) :(char) c;
           ret.Append(charNew);
           
        }
        return ret.ToString();
    }
}