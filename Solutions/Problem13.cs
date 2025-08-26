namespace Solutions;

/*
https://leetcode.com/problems/roman-to-integer/description/

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. 
The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. 
However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer.

Example 1:
    Input: s = "III"
    Output: 3
    Explanation: III = 3.

Example 2:
    Input: s = "LVIII"
    Output: 58
    Explanation: L = 50, V= 5, III = 3.

Example 3:
    Input: s = "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:
    1 <= s.length <= 15
    s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    It is guaranteed that s is a valid roman numeral in the range [1, 3999].
*/
public class Problem13
{
    public int RomanToInt(string s)
    {
        int val = 0;
        char sub = ' ';

        for (int i = 0; i < s.Length; i++)
        {
            if (sub == ' ' && (s[i] == 'I' || s[i] == 'X' || s[i] == 'C'))
            {
                sub = s[i];
            }
            else if (sub == 'I' && s[i] == 'V')
            {
                val += 4;
                sub = ' ';
            }
            else if (sub == 'I' && s[i] == 'X')
            {
                val += 9;
                sub = ' ';
            }
            else if (sub == 'X' && s[i] == 'L')
            {
                val += 40;
                sub = ' ';
            }
            else if (sub == 'X' && s[i] == 'C')
            {
                val += 90;
                sub = ' ';
            }
            else if (sub == 'C' && s[i] == 'D')
            {
                val += 400;
                sub = ' ';
            }
            else if (sub == 'C' && s[i] == 'M')
            {
                val += 900;
                sub = ' ';
            }
            else if (sub != ' ')
            {
                val += RomanCharToInt(sub);
                sub = s[i];
            }
            else
            {
                val += RomanCharToInt(s[i]);
            }
        }

        if (sub != ' ')
        {
            val += RomanCharToInt(sub);
        }

        return val;
    }

    private static int RomanCharToInt(char ch) => ch switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentException(),
    };
}